Public Class Form1


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            english_dictionary.My.Settings.last_search_word = Me.search_textBox1.Text
            english_dictionary.My.Settings.auto_load_last_word = Me.auto_load_checkBox2.Checked
            english_dictionary.My.Settings.Save()

        Catch ex As Exception
            MessageBox.Show("Error!" + ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'En_dic_ds.en_dic_table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.search_type_comboBox1.SelectedIndex = 3

        Try
            Dim b As Boolean
            b = english_dictionary.My.Settings.auto_load_last_word
            If b = True Then
                Me.search_textBox1.Text = english_dictionary.My.Settings.last_search_word
                Button1_Click(sender, e)
            End If
            '-----------------------------------------
            Me.auto_load_checkBox2.Checked = b
            '-----------------------------------------

        Catch ex As Exception
            MessageBox.Show("Error!" + ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Me.En_dic_tableTableAdapter.Fill(Me.En_dic_ds.en_dic_table)

        Try
            '-----------------show and hide panel-----------------
            Me.plog_label_Label3.Text = "Loading Data..."
            Me.progress_Panel2.Visible = True
            Me.progress_Panel2.Refresh()
            '-----------------------------------
            Me.En_dic_tableTableAdapter.FillBy_all_words_asc(Me.En_dic_ds.en_dic_table)
            '-----------------------------------


        Catch ex As Exception
            Me.progress_Panel2.Visible = False
            MessageBox.Show("Error!" + ex.Message)
        End Try
        Me.progress_Panel2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.search_textBox1.Text = "" Then
            Exit Sub
        End If

        Try
            '-----------------show and hide panel-----------------
            Me.plog_label_Label3.Text = "Searching..."
            Me.progress_Panel2.Visible = True
            Me.progress_Panel2.Refresh()
            '-----------------------------------
            If Me.search_type_comboBox1.SelectedIndex = 0 Then '=
                Me.En_dic_tableTableAdapter.FillBy_exact_word(Me.En_dic_ds.en_dic_table, Me.search_textBox1.Text)
            End If
            '-------------------------
            If Me.search_type_comboBox1.SelectedIndex = 1 Then 'start with
                Me.En_dic_tableTableAdapter.FillBy_like_words(Me.En_dic_ds.en_dic_table, Me.search_textBox1.Text + "%")
            End If
            '-------------------------
            If Me.search_type_comboBox1.SelectedIndex = 2 Then 'end with
                Me.En_dic_tableTableAdapter.FillBy_like_words(Me.En_dic_ds.en_dic_table, "%" + Me.search_textBox1.Text)
            End If
            '-------------------------
            If Me.search_type_comboBox1.SelectedIndex = 3 Then 'every where
                Me.En_dic_tableTableAdapter.FillBy_like_words(Me.En_dic_ds.en_dic_table, "%" + Me.search_textBox1.Text + "%")
            End If

            Me.En_dic_tableBindingSource.Sort = "word ASC"

        Catch ex As Exception
            Me.progress_Panel2.Visible = False
            MessageBox.Show("Error!" + ex.Message)
        End Try
        '-----------------show and hide panel-----------------
        Me.progress_Panel2.Visible = False
        '-----------------------------------

    End Sub

    Private Sub search_textBox1_TextChanged(sender As Object, e As EventArgs) Handles search_textBox1.TextChanged
        If Me.auto_search_checkBox1.Checked = True Then
            Button1_Click(sender, e)
        End If
    End Sub


End Class

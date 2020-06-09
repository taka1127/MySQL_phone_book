Public Class search_form
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles date_panel2.Paint

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles from_dateTimePicker1.ValueChanged

    End Sub

    Private Sub search_item_cbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles search_item_cbox.SelectedIndexChanged
        If Me.search_item_cbox.SelectedIndex = 1 Then
            Me.date_panel2.Visible = True
            Me.date_panel2.BringToFront()
        Else
            Me.date_panel2.Visible = False
            Me.date_panel2.SendToBack()
        End If
    End Sub

    Private Sub search_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Phone_book_ds.customer_list' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.search_item_cbox.SelectedIndex = 0
        Me.date_panel2.Visible = False

    End Sub

    Private Sub search_type_cbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles search_type_cbox.SelectedIndexChanged
        If Me.search_type_cbox.SelectedIndex = 4 Then
            Me.and_Label2.Visible = True
            Me.second_value_tb.Visible = True
        Else
            Me.and_Label2.Visible = False
            Me.second_value_tb.Visible = False
        End If
    End Sub

    Private Sub Customer_listBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Phone_book_ds)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Customer_listTableAdapter.Fill(Me.Phone_book_ds.customer_list)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.search_item_cbox.SelectedIndex = 1 Then '生年月日の検索
            Me.Customer_listTableAdapter.FillBy_date_of_birth(Me.Phone_book_ds.customer_list,
                                                         Me.from_dateTimePicker1.Value, Me.to_dateTimePicker2.Value)
        End If
        '-----------------------------------------------------------------------------------
        If Me.search_item_cbox.SelectedIndex = 0 Then '名前の検索
            '---------------------------------------------
            If Me.search_type_cbox.SelectedIndex = -1 Then
                MessageBox.Show("検索条件を選択してください!")
                Exit Sub
            End If
            '---------------------------------------------
            If Me.search_type_cbox.SelectedIndex = 0 Then '=
                Me.Customer_listTableAdapter.FillBy_like_last_name(Me.Phone_book_ds.customer_list, Me.first_value_tb.Text)
            End If
            '----------------------------------------------
            If Me.search_type_cbox.SelectedIndex = 1 Then 'Start With
                Me.Customer_listTableAdapter.FillBy_like_last_name(Me.Phone_book_ds.customer_list, Me.first_value_tb.Text + "%")
            End If
            '----------------------------------------------
            If Me.search_type_cbox.SelectedIndex = 2 Then 'End With
                Me.Customer_listTableAdapter.FillBy_like_last_name(Me.Phone_book_ds.customer_list, "%" + Me.first_value_tb.Text)
            End If
            '----------------------------------------------

            If Me.search_type_cbox.SelectedIndex = 3 Then '=Every where
                Me.Customer_listTableAdapter.FillBy_like_last_name(Me.Phone_book_ds.customer_list, "%" + Me.first_value_tb.Text + "%")
            End If
            '----------------------------------------------

            If Me.search_type_cbox.SelectedIndex = 4 Then 'Between
                Me.Customer_listTableAdapter.FillBy_between_last_name(Me.Phone_book_ds.customer_list, Me.first_value_tb.Text, Me.second_value_tb.Text)

            End If
            '----------------------------------------------

            If Me.search_type_cbox.SelectedIndex = 5 Then 'not equal
                Me.Customer_listTableAdapter.FillBy_not_equal_last_name(Me.Phone_book_ds.customer_list, Me.first_value_tb.Text)
            End If
            '----------------------------------------------



        End If
        '-----------------------------------------------------------------------------------
    End Sub
End Class
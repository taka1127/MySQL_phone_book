Public Class Form1
    Private Sub En_dic_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles En_dic_tableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.En_dic_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.En_dic_ds)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'En_dic_ds.en_dic_table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Me.En_dic_tableTableAdapter.Fill(Me.En_dic_ds.en_dic_table)
        '----------------------------------
        Me.progress_Panel2.Visible = True
        Me.progress_Panel2.Refresh()
        '-----------------------------------
        Me.En_dic_tableTableAdapter.FillBy_all_words_asc(Me.En_dic_ds.en_dic_table)
        Me.progress_Panel2.Visible = False
    End Sub
End Class

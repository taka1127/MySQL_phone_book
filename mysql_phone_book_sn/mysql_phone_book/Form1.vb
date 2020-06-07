Public Class Form1
    Private Sub Customer_listBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Phone_book_ds)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Phone_book_ds.customer_list' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Customer_listTableAdapter.Fill(Me.Phone_book_ds.customer_list)

    End Sub

    Private Sub Customer_listDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Customer_listDataGridView.CellContentClick

    End Sub
End Class

Public Class Form1
    Private Sub Customer_listBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Phone_book_ds)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Phone_book_ds.customer_list' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        '''Me.Customer_listTableAdapter.Fill(Me.Phone_book_ds.customer_list)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Customer_listTableAdapter.Fill(Me.Phone_book_ds.customer_list)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Customer_listTableAdapter.FillBy_last_name(Me.Phone_book_ds.customer_list, Me.last_name_search_tb.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As Integer
        Int32.TryParse(Me.id_search_tb.Text, id)
        Me.Customer_listTableAdapter.FillBy_id(Me.Phone_book_ds.customer_list, id)
    End Sub
End Class

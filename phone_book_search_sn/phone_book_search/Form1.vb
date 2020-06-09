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
        'Me.Customer_listTableAdapter.FillBy_last_name(Me.Phone_book_ds.customer_list, Me.last_name_search_tb.Text)
        Me.Customer_listTableAdapter.FillBy_like_last_name(Me.Phone_book_ds.customer_list, "%" + Me.last_name_search_tb.Text + "%")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As Integer
        Int32.TryParse(Me.id_search_tb.Text, id)
        Me.Customer_listTableAdapter.FillBy_id(Me.Phone_book_ds.customer_list, id)
    End Sub

    Private Sub last_name_search_tb_TextChanged(sender As Object, e As EventArgs) Handles last_name_search_tb.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles from_dateTimePicker1.ValueChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Customer_listTableAdapter.FillBy_date_of_birth(Me.Phone_book_ds.customer_list, Me.from_dateTimePicker1.Value, Me.to_dateTimePicker2.Value)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Dim frm As New search_form
        'frm.Show()
        'frm.BringToFront()
        '--------------------------
        My.Forms.search_form.Show()
        My.Forms.search_form.BringToFront()
    End Sub
End Class

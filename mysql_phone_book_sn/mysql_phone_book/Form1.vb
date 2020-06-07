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

    Private Sub DebtLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DebtTextBox_TextChanged(sender As Object, e As EventArgs) Handles DebtTextBox.TextChanged

    End Sub

    Private Sub Cell_numberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Date_of_birthDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_of_birthDateTimePicker.ValueChanged

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class

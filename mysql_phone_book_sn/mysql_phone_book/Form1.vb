Public Class Form1
    Private Sub Customer_listBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Phone_book_ds)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Phone_book_ds.customer_list' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Customer_listTableAdapter.Fill(Me.Phone_book_ds.customer_list)
        '------------------------------------
        Me.save_butt.Enabled = False
        Me.cancel_butt.Enabled = False
        '------------------------------------
        Me.Customer_listDataGridView.Enabled = True
        Me.Customer_listBindingNavigator.Enabled = True
        Me.GroupBox1.Enabled = False
        '------------------------------------
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

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub new_butt_Click(sender As Object, e As EventArgs) Handles new_butt.Click
        new_edit_delete_butt("new_butt")
        '------------------------add new record--------------
        Me.Customer_listBindingSource.AddNew()
        '----------------------------------------------------
    End Sub

    Private Sub edit_butt_Click(sender As Object, e As EventArgs) Handles edit_butt.Click
        '------------------------empty record checker--------------
        Dim rc As Integer
        rc = Me.Phone_book_ds.customer_list.Rows.Count
        If rc = 0 Then
            MessageBox.Show("編集するレコードを選択してください!")
            Exit Sub
        End If
        '----------------------------------------------------
        new_edit_delete_butt("edit_butt")
    End Sub

    Private Sub delete_butt_Click(sender As Object, e As EventArgs) Handles delete_butt.Click
        '------------------------empty record checker--------------
        Dim rc As Integer
        rc = Me.Phone_book_ds.customer_list.Rows.Count
        If rc = 0 Then
            MessageBox.Show("削除するレコードを選択してください!")
            Exit Sub
        End If
        '----------------------------------------------------
        new_edit_delete_butt("delete_butt")
        '------------------------delete record--------------
        Me.Customer_listBindingSource.RemoveCurrent()

        '----------------------------------------------------
    End Sub

    Sub new_edit_delete_butt(butt_name As String)
        Me.new_butt.Enabled = False
        Me.edit_butt.Enabled = False
        Me.delete_butt.Enabled = False
        '------------------------------------
        Me.save_butt.Enabled = True
        Me.cancel_butt.Enabled = True
        '------------------------------------
        Me.Customer_listDataGridView.Enabled = False
        Me.Customer_listBindingNavigator.Enabled = False
        '------------------------------------
        If butt_name = "delete_butt" Then
            Me.GroupBox1.Enabled = False
        Else
            Me.GroupBox1.Enabled = True
        End If
        Me.GroupBox1.Enabled = True
        '------------------------------------
    End Sub

    Private Sub save_butt_Click(sender As Object, e As EventArgs) Handles save_butt.Click
        save_cancel_butt()
        '--------------save changes----------
        Me.Customer_listBindingSource.EndEdit()
        Dim r As Integer
        r = Me.Customer_listTableAdapter.Update(Me.Phone_book_ds.customer_list)
        '------------------------------------
        If r > 0 Then
            MessageBox.Show("保存しました！")
        Else
            MessageBox.Show("保存できませんでした...")
        End If
        '------------------------------------
    End Sub

    Private Sub cancel_butt_Click(sender As Object, e As EventArgs) Handles cancel_butt.Click
        save_cancel_butt()
        '--------------cancel changes----------
        Me.Phone_book_ds.customer_list.RejectChanges()
        Me.Customer_listBindingSource.CancelEdit()
        '------------------------------------
    End Sub

    Sub save_cancel_butt()
        '------------------------------------
        Me.save_butt.Enabled = False
        Me.cancel_butt.Enabled = False
        '------------------------------------
        Me.new_butt.Enabled = True
        Me.edit_butt.Enabled = True
        Me.delete_butt.Enabled = True
        '------------------------------------
        Me.Customer_listDataGridView.Enabled = True
        Me.Customer_listBindingNavigator.Enabled = True
        Me.GroupBox1.Enabled = False
        '------------------------------------
    End Sub

    Private Sub Date_of_birthLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Date_of_birthDateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class

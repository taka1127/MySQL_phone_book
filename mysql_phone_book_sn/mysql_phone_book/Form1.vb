Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Phone_book_ds.customer_list' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Customer_listTableAdapter.Fill_all(Me.Phone_book_ds.customer_list)
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
        '------------------------新規作成時のNo Imageの画像を追加-------------
        Me.cu_image_pictureBox1.Image = mysql_phone_book.My.Resources.NO_IMAGE1
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

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Customer_listTableAdapter.FillBy_p_info(Me.Phone_book_ds.customer_list)
    End Sub

    Private Sub Last_nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Last_nameTextBox.TextChanged

    End Sub

    Private Sub CommentLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub First_nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles First_nameTextBox.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles cu_image_pictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.OpenFileDialog1.ShowDialog()
        Dim fn As String
        fn = Me.OpenFileDialog1.FileName
        If fn = "OpenFileDialog1" Then
            Exit Sub
        End If
        '---------load image-------------
        Me.cu_image_pictureBox1.Image = Image.FromFile(fn)
    End Sub
End Class

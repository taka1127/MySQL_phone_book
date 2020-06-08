Public Class Form1
    Private Sub Customer_listBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.Customer_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Phone_book_ds)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'Phone_book_ds.customer_list' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        '''''Me.Customer_listTableAdapter.Fill(Me.Phone_book_ds.customer_list)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Customer_listTableAdapter.Fill(Me.Phone_book_ds.customer_list)
    End Sub
End Class

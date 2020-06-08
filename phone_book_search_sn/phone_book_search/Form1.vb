Public Class Form1
    Private Sub Customer_listBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Customer_listBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Customer_listBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'DataSet1.customer_list' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        '''Me.Customer_listTableAdapter.Fill(Me.DataSet1.customer_list)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Customer_listTableAdapter.Fill(Me.DataSet1.customer_list)
    End Sub
End Class

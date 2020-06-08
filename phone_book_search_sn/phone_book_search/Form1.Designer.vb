<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofbirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandlineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerimageDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofbirthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellnumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandlineDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerimageDataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Customer_listDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Customer_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Phone_book_ds = New phone_book_search.phone_book_ds()
        Me.Customer_listTableAdapter = New phone_book_search.phone_book_dsTableAdapters.customer_listTableAdapter()
        Me.TableAdapterManager = New phone_book_search.phone_book_dsTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.Customer_listDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Customer_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phone_book_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 69)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "検索"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "名前で検索"
        '
        'BackgroundWorker1
        '
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'DateofbirthDataGridViewTextBoxColumn
        '
        Me.DateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth"
        Me.DateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth"
        Me.DateofbirthDataGridViewTextBoxColumn.Name = "DateofbirthDataGridViewTextBoxColumn"
        '
        'DebtDataGridViewTextBoxColumn
        '
        Me.DebtDataGridViewTextBoxColumn.DataPropertyName = "debt"
        Me.DebtDataGridViewTextBoxColumn.HeaderText = "debt"
        Me.DebtDataGridViewTextBoxColumn.Name = "DebtDataGridViewTextBoxColumn"
        '
        'CellnumberDataGridViewTextBoxColumn
        '
        Me.CellnumberDataGridViewTextBoxColumn.DataPropertyName = "cell_number"
        Me.CellnumberDataGridViewTextBoxColumn.HeaderText = "cell_number"
        Me.CellnumberDataGridViewTextBoxColumn.Name = "CellnumberDataGridViewTextBoxColumn"
        '
        'LandlineDataGridViewTextBoxColumn
        '
        Me.LandlineDataGridViewTextBoxColumn.DataPropertyName = "land_line"
        Me.LandlineDataGridViewTextBoxColumn.HeaderText = "land_line"
        Me.LandlineDataGridViewTextBoxColumn.Name = "LandlineDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        '
        'CustomerimageDataGridViewImageColumn
        '
        Me.CustomerimageDataGridViewImageColumn.DataPropertyName = "customer_image"
        Me.CustomerimageDataGridViewImageColumn.HeaderText = "customer_image"
        Me.CustomerimageDataGridViewImageColumn.Name = "CustomerimageDataGridViewImageColumn"
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'FirstnameDataGridViewTextBoxColumn1
        '
        Me.FirstnameDataGridViewTextBoxColumn1.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn1.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn1.Name = "FirstnameDataGridViewTextBoxColumn1"
        '
        'LastnameDataGridViewTextBoxColumn1
        '
        Me.LastnameDataGridViewTextBoxColumn1.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn1.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn1.Name = "LastnameDataGridViewTextBoxColumn1"
        '
        'AgeDataGridViewTextBoxColumn1
        '
        Me.AgeDataGridViewTextBoxColumn1.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn1.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn1.Name = "AgeDataGridViewTextBoxColumn1"
        '
        'DateofbirthDataGridViewTextBoxColumn1
        '
        Me.DateofbirthDataGridViewTextBoxColumn1.DataPropertyName = "date_of_birth"
        Me.DateofbirthDataGridViewTextBoxColumn1.HeaderText = "date_of_birth"
        Me.DateofbirthDataGridViewTextBoxColumn1.Name = "DateofbirthDataGridViewTextBoxColumn1"
        '
        'DebtDataGridViewTextBoxColumn1
        '
        Me.DebtDataGridViewTextBoxColumn1.DataPropertyName = "debt"
        Me.DebtDataGridViewTextBoxColumn1.HeaderText = "debt"
        Me.DebtDataGridViewTextBoxColumn1.Name = "DebtDataGridViewTextBoxColumn1"
        '
        'CellnumberDataGridViewTextBoxColumn1
        '
        Me.CellnumberDataGridViewTextBoxColumn1.DataPropertyName = "cell_number"
        Me.CellnumberDataGridViewTextBoxColumn1.HeaderText = "cell_number"
        Me.CellnumberDataGridViewTextBoxColumn1.Name = "CellnumberDataGridViewTextBoxColumn1"
        '
        'LandlineDataGridViewTextBoxColumn1
        '
        Me.LandlineDataGridViewTextBoxColumn1.DataPropertyName = "land_line"
        Me.LandlineDataGridViewTextBoxColumn1.HeaderText = "land_line"
        Me.LandlineDataGridViewTextBoxColumn1.Name = "LandlineDataGridViewTextBoxColumn1"
        '
        'EmailDataGridViewTextBoxColumn1
        '
        Me.EmailDataGridViewTextBoxColumn1.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn1.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn1.Name = "EmailDataGridViewTextBoxColumn1"
        '
        'AddressDataGridViewTextBoxColumn1
        '
        Me.AddressDataGridViewTextBoxColumn1.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn1.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn1.Name = "AddressDataGridViewTextBoxColumn1"
        '
        'CommentDataGridViewTextBoxColumn1
        '
        Me.CommentDataGridViewTextBoxColumn1.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn1.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn1.Name = "CommentDataGridViewTextBoxColumn1"
        '
        'CustomerimageDataGridViewImageColumn1
        '
        Me.CustomerimageDataGridViewImageColumn1.DataPropertyName = "customer_image"
        Me.CustomerimageDataGridViewImageColumn1.HeaderText = "customer_image"
        Me.CustomerimageDataGridViewImageColumn1.Name = "CustomerimageDataGridViewImageColumn1"
        '
        'Customer_listDataGridView
        '
        Me.Customer_listDataGridView.AutoGenerateColumns = False
        Me.Customer_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_listDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewImageColumn1})
        Me.Customer_listDataGridView.DataSource = Me.Customer_listBindingSource
        Me.Customer_listDataGridView.Location = New System.Drawing.Point(0, 75)
        Me.Customer_listDataGridView.Name = "Customer_listDataGridView"
        Me.Customer_listDataGridView.RowTemplate.Height = 21
        Me.Customer_listDataGridView.Size = New System.Drawing.Size(534, 277)
        Me.Customer_listDataGridView.TabIndex = 1
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 358)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(545, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(449, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "全表示"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "first_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "last_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date_of_birth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "date_of_birth"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "debt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "debt"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cell_number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cell_number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "land_line"
        Me.DataGridViewTextBoxColumn8.HeaderText = "land_line"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn9.HeaderText = "email"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn10.HeaderText = "address"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "comment"
        Me.DataGridViewTextBoxColumn11.HeaderText = "comment"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "customer_image"
        Me.DataGridViewImageColumn1.HeaderText = "customer_image"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'Customer_listBindingSource
        '
        Me.Customer_listBindingSource.DataMember = "customer_list"
        Me.Customer_listBindingSource.DataSource = Me.Phone_book_ds
        '
        'Phone_book_ds
        '
        Me.Phone_book_ds.DataSetName = "phone_book_ds"
        Me.Phone_book_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_listTableAdapter
        '
        Me.Customer_listTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_listTableAdapter = Me.Customer_listTableAdapter
        Me.TableAdapterManager.UpdateOrder = phone_book_search.phone_book_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(545, 383)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Customer_listDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "顧客情報　検索"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Customer_listDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Customer_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phone_book_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Phone_book_ds As phone_book_ds
    Friend WithEvents Customer_listBindingSource As BindingSource
    Friend WithEvents Customer_listTableAdapter As phone_book_dsTableAdapters.customer_listTableAdapter
    Friend WithEvents TableAdapterManager As phone_book_dsTableAdapters.TableAdapterManager
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofbirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CellnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LandlineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerimageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateofbirthDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DebtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CellnumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LandlineDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerimageDataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Customer_listDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Button2 As Button
End Class

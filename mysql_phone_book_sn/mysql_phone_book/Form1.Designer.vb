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
        Dim IdLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim Land_lineLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim DebtLabel As System.Windows.Forms.Label
        Dim Cell_numberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Customer_listBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Customer_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Phone_book_ds = New mysql_phone_book.phone_book_ds()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Customer_listDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.Customer_listTableAdapter = New mysql_phone_book.phone_book_dsTableAdapters.customer_listTableAdapter()
        Me.TableAdapterManager = New mysql_phone_book.phone_book_dsTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Land_lineTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cell_numberTextBox = New System.Windows.Forms.TextBox()
        Me.DebtTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Customer_listBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IdLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        Land_lineLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        DebtLabel = New System.Windows.Forms.Label()
        Cell_numberLabel = New System.Windows.Forms.Label()
        CType(Me.Customer_listBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customer_listBindingNavigator.SuspendLayout()
        CType(Me.Customer_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phone_book_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_listDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(57, 20)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(32, 22)
        IdLabel.TabIndex = 2
        IdLabel.Text = "ID:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(57, 54)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(28, 22)
        First_nameLabel.TabIndex = 4
        First_nameLabel.Text = "姓"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(57, 88)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(28, 22)
        Last_nameLabel.TabIndex = 6
        Last_nameLabel.Text = "名"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(57, 122)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(46, 22)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "年齢"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.Location = New System.Drawing.Point(57, 157)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(82, 22)
        Date_of_birthLabel.TabIndex = 10
        Date_of_birthLabel.Text = "生年月日"
        '
        'Land_lineLabel
        '
        Land_lineLabel.AutoSize = True
        Land_lineLabel.Location = New System.Drawing.Point(57, 258)
        Land_lineLabel.Name = "Land_lineLabel"
        Land_lineLabel.Size = New System.Drawing.Size(82, 22)
        Land_lineLabel.TabIndex = 16
        Land_lineLabel.Text = "固定電話"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(57, 292)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(107, 22)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "メールアドレス"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(57, 326)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(46, 22)
        AddressLabel.TabIndex = 20
        AddressLabel.Text = "住所"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(57, 360)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(60, 22)
        CommentLabel.TabIndex = 22
        CommentLabel.Text = "コメント"
        '
        'DebtLabel
        '
        DebtLabel.AutoSize = True
        DebtLabel.Location = New System.Drawing.Point(57, 197)
        DebtLabel.Name = "DebtLabel"
        DebtLabel.Size = New System.Drawing.Size(46, 22)
        DebtLabel.TabIndex = 23
        DebtLabel.Text = "負債"
        AddHandler DebtLabel.Click, AddressOf Me.DebtLabel_Click
        '
        'Cell_numberLabel
        '
        Cell_numberLabel.AutoSize = True
        Cell_numberLabel.Location = New System.Drawing.Point(57, 228)
        Cell_numberLabel.Name = "Cell_numberLabel"
        Cell_numberLabel.Size = New System.Drawing.Size(82, 22)
        Cell_numberLabel.TabIndex = 24
        Cell_numberLabel.Text = "携帯電話"
        AddHandler Cell_numberLabel.Click, AddressOf Me.Cell_numberLabel_Click
        '
        'Customer_listBindingNavigator
        '
        Me.Customer_listBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Customer_listBindingNavigator.AutoSize = False
        Me.Customer_listBindingNavigator.BindingSource = Me.Customer_listBindingSource
        Me.Customer_listBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Customer_listBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Customer_listBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Customer_listBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Customer_listBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator3, Me.Customer_listBindingNavigatorSaveItem, Me.ToolStripSeparator2})
        Me.Customer_listBindingNavigator.Location = New System.Drawing.Point(0, 659)
        Me.Customer_listBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Customer_listBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Customer_listBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Customer_listBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Customer_listBindingNavigator.Name = "Customer_listBindingNavigator"
        Me.Customer_listBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Customer_listBindingNavigator.Size = New System.Drawing.Size(826, 49)
        Me.Customer_listBindingNavigator.TabIndex = 0
        Me.Customer_listBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 44)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 49)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 49)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 49)
        '
        'Customer_listDataGridView
        '
        Me.Customer_listDataGridView.AutoGenerateColumns = False
        Me.Customer_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_listDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Customer_listDataGridView.DataSource = Me.Customer_listBindingSource
        Me.Customer_listDataGridView.Location = New System.Drawing.Point(12, 469)
        Me.Customer_listDataGridView.Name = "Customer_listDataGridView"
        Me.Customer_listDataGridView.RowHeadersWidth = 62
        Me.Customer_listDataGridView.RowTemplate.Height = 27
        Me.Customer_listDataGridView.Size = New System.Drawing.Size(627, 190)
        Me.Customer_listDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "first_name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "last_name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "age"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date_of_birth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "date_of_birth"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "debt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "debt"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cell_number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cell_number"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "land_line"
        Me.DataGridViewTextBoxColumn8.HeaderText = "land_line"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn9.HeaderText = "email"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn10.HeaderText = "address"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "comment"
        Me.DataGridViewTextBoxColumn11.HeaderText = "comment"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'Customer_listTableAdapter
        '
        Me.Customer_listTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_listTableAdapter = Me.Customer_listTableAdapter
        Me.TableAdapterManager.UpdateOrder = mysql_phone_book.phone_book_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(173, 17)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 28)
        Me.IdTextBox.TabIndex = 3
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(173, 51)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(200, 28)
        Me.First_nameTextBox.TabIndex = 5
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(173, 85)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(200, 28)
        Me.Last_nameTextBox.TabIndex = 7
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(173, 119)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 28)
        Me.AgeTextBox.TabIndex = 9
        '
        'Date_of_birthDateTimePicker
        '
        Me.Date_of_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Customer_listBindingSource, "debt", True))
        Me.Date_of_birthDateTimePicker.Location = New System.Drawing.Point(173, 157)
        Me.Date_of_birthDateTimePicker.Name = "Date_of_birthDateTimePicker"
        Me.Date_of_birthDateTimePicker.Size = New System.Drawing.Size(200, 28)
        Me.Date_of_birthDateTimePicker.TabIndex = 11
        '
        'Land_lineTextBox
        '
        Me.Land_lineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "land_line", True))
        Me.Land_lineTextBox.Location = New System.Drawing.Point(173, 255)
        Me.Land_lineTextBox.Name = "Land_lineTextBox"
        Me.Land_lineTextBox.Size = New System.Drawing.Size(200, 28)
        Me.Land_lineTextBox.TabIndex = 17
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(173, 289)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 28)
        Me.EmailTextBox.TabIndex = 19
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(173, 323)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 28)
        Me.AddressTextBox.TabIndex = 21
        '
        'CommentTextBox
        '
        Me.CommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "comment", True))
        Me.CommentTextBox.Location = New System.Drawing.Point(173, 357)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(200, 28)
        Me.CommentTextBox.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Cell_numberLabel)
        Me.GroupBox1.Controls.Add(Me.Cell_numberTextBox)
        Me.GroupBox1.Controls.Add(DebtLabel)
        Me.GroupBox1.Controls.Add(Me.DebtTextBox)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.CommentTextBox)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(CommentLabel)
        Me.GroupBox1.Controls.Add(First_nameLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(Me.First_nameTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Last_nameLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.Last_nameTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(Me.Land_lineTextBox)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(Land_lineLabel)
        Me.GroupBox1.Controls.Add(Date_of_birthLabel)
        Me.GroupBox1.Controls.Add(Me.Date_of_birthDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 411)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Cell_numberTextBox
        '
        Me.Cell_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "cell_number", True))
        Me.Cell_numberTextBox.Location = New System.Drawing.Point(173, 225)
        Me.Cell_numberTextBox.Name = "Cell_numberTextBox"
        Me.Cell_numberTextBox.Size = New System.Drawing.Size(200, 28)
        Me.Cell_numberTextBox.TabIndex = 25
        '
        'DebtTextBox
        '
        Me.DebtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customer_listBindingSource, "debt", True))
        Me.DebtTextBox.Location = New System.Drawing.Point(173, 191)
        Me.DebtTextBox.Name = "DebtTextBox"
        Me.DebtTextBox.Size = New System.Drawing.Size(200, 28)
        Me.DebtTextBox.TabIndex = 24
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 49)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 49)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 49)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator4, Me.ToolStripButton2, Me.ToolStripSeparator5, Me.ToolStripButton3, Me.ToolStripSeparator6, Me.ToolStripButton4, Me.ToolStripSeparator7, Me.ToolStripButton5, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(826, 66)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.mysql_phone_book.My.Resources.Resources.new_butt
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(112, 61)
        Me.ToolStripButton1.Text = "新規追加"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.mysql_phone_book.My.Resources.Resources.edit_butt
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(76, 61)
        Me.ToolStripButton2.Text = "編集"
        Me.ToolStripButton2.ToolTipText = "Add NEW"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.mysql_phone_book.My.Resources.Resources.delete_butt
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(76, 61)
        Me.ToolStripButton3.Text = "削除"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.mysql_phone_book.My.Resources.Resources.save_butt
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(76, 61)
        Me.ToolStripButton4.Text = "保存"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.mysql_phone_book.My.Resources.Resources.cancel_butt
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(109, 61)
        Me.ToolStripButton5.Text = "キャンセル"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(112, 44)
        Me.BindingNavigatorAddNewItem.Text = "新規追加 F2"
        Me.BindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BindingNavigatorAddNewItem.ToolTipText = "新規追加"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(76, 44)
        Me.BindingNavigatorDeleteItem.Text = "削除 F3"
        Me.BindingNavigatorDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 44)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 44)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 44)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 44)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'Customer_listBindingNavigatorSaveItem
        '
        Me.Customer_listBindingNavigatorSaveItem.Image = CType(resources.GetObject("Customer_listBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Customer_listBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Customer_listBindingNavigatorSaveItem.Name = "Customer_listBindingNavigatorSaveItem"
        Me.Customer_listBindingNavigatorSaveItem.Size = New System.Drawing.Size(131, 44)
        Me.Customer_listBindingNavigatorSaveItem.Text = "データの保存 F5"
        Me.Customer_listBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(852, 566)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Customer_listDataGridView)
        Me.Controls.Add(Me.Customer_listBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer List"
        CType(Me.Customer_listBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customer_listBindingNavigator.ResumeLayout(False)
        Me.Customer_listBindingNavigator.PerformLayout()
        CType(Me.Customer_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phone_book_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_listDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Phone_book_ds As phone_book_ds
    Friend WithEvents Customer_listBindingSource As BindingSource
    Friend WithEvents Customer_listTableAdapter As phone_book_dsTableAdapters.customer_listTableAdapter
    Friend WithEvents TableAdapterManager As phone_book_dsTableAdapters.TableAdapterManager
    Friend WithEvents Customer_listBindingNavigator As BindingNavigator
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
    Friend WithEvents Customer_listBindingNavigatorSaveItem As ToolStripButton
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
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents Date_of_birthDateTimePicker As DateTimePicker
    Friend WithEvents Land_lineTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CommentTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DebtTextBox As TextBox
    Friend WithEvents Cell_numberTextBox As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
End Class

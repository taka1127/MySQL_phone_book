<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_form
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search_form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.search_type_cbox = New System.Windows.Forms.ComboBox()
        Me.search_item_cbox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.and_Label2 = New System.Windows.Forms.Label()
        Me.second_value_tb = New System.Windows.Forms.TextBox()
        Me.first_value_tb = New System.Windows.Forms.TextBox()
        Me.date_panel2 = New System.Windows.Forms.Panel()
        Me.to_dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.from_dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Phone_book_ds = New phone_book_search.Phone_book_ds()
        Me.Customer_listBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_listTableAdapter = New phone_book_search.Phone_book_dsTableAdapters.customer_listTableAdapter()
        Me.TableAdapterManager = New phone_book_search.Phone_book_dsTableAdapters.TableAdapterManager()
        Me.Customer_listBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Customer_listBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Customer_listDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.date_panel2.SuspendLayout()
        CType(Me.Phone_book_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_listBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_listBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customer_listBindingNavigator.SuspendLayout()
        CType(Me.Customer_listDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.search_type_cbox)
        Me.GroupBox1.Controls.Add(Me.search_item_cbox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.date_panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "検索データ"
        '
        'search_type_cbox
        '
        Me.search_type_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.search_type_cbox.FormattingEnabled = True
        Me.search_type_cbox.Items.AddRange(New Object() {"＝", "始まりが該当(Start With)", "末尾が該当(End With)", "いずれかに該当(Every Where)", "Between", "以外(Not Equal)"})
        Me.search_type_cbox.Location = New System.Drawing.Point(208, 32)
        Me.search_type_cbox.Name = "search_type_cbox"
        Me.search_type_cbox.Size = New System.Drawing.Size(121, 23)
        Me.search_type_cbox.TabIndex = 3
        '
        'search_item_cbox
        '
        Me.search_item_cbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_item_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.search_item_cbox.FormattingEnabled = True
        Me.search_item_cbox.Items.AddRange(New Object() {"名前", "生年月日"})
        Me.search_item_cbox.Location = New System.Drawing.Point(81, 32)
        Me.search_item_cbox.Name = "search_item_cbox"
        Me.search_item_cbox.Size = New System.Drawing.Size(121, 23)
        Me.search_item_cbox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(21, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "検索"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "検索条件"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.and_Label2)
        Me.Panel1.Controls.Add(Me.second_value_tb)
        Me.Panel1.Controls.Add(Me.first_value_tb)
        Me.Panel1.Location = New System.Drawing.Point(335, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 4
        '
        'and_Label2
        '
        Me.and_Label2.AutoSize = True
        Me.and_Label2.Location = New System.Drawing.Point(76, 42)
        Me.and_Label2.Name = "and_Label2"
        Me.and_Label2.Size = New System.Drawing.Size(28, 15)
        Me.and_Label2.TabIndex = 5
        Me.and_Label2.Text = "And"
        Me.and_Label2.Visible = False
        '
        'second_value_tb
        '
        Me.second_value_tb.Location = New System.Drawing.Point(18, 60)
        Me.second_value_tb.Name = "second_value_tb"
        Me.second_value_tb.Size = New System.Drawing.Size(154, 21)
        Me.second_value_tb.TabIndex = 1
        Me.second_value_tb.Visible = False
        '
        'first_value_tb
        '
        Me.first_value_tb.Location = New System.Drawing.Point(18, 12)
        Me.first_value_tb.Name = "first_value_tb"
        Me.first_value_tb.Size = New System.Drawing.Size(154, 21)
        Me.first_value_tb.TabIndex = 0
        '
        'date_panel2
        '
        Me.date_panel2.Controls.Add(Me.to_dateTimePicker2)
        Me.date_panel2.Controls.Add(Me.from_dateTimePicker1)
        Me.date_panel2.Controls.Add(Me.Label3)
        Me.date_panel2.Controls.Add(Me.Label2)
        Me.date_panel2.Location = New System.Drawing.Point(208, 20)
        Me.date_panel2.Name = "date_panel2"
        Me.date_panel2.Size = New System.Drawing.Size(332, 160)
        Me.date_panel2.TabIndex = 5
        '
        'to_dateTimePicker2
        '
        Me.to_dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.to_dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.to_dateTimePicker2.Location = New System.Drawing.Point(174, 15)
        Me.to_dateTimePicker2.Name = "to_dateTimePicker2"
        Me.to_dateTimePicker2.Size = New System.Drawing.Size(102, 21)
        Me.to_dateTimePicker2.TabIndex = 4
        '
        'from_dateTimePicker1
        '
        Me.from_dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.from_dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.from_dateTimePicker1.Location = New System.Drawing.Point(41, 15)
        Me.from_dateTimePicker1.Name = "from_dateTimePicker1"
        Me.from_dateTimePicker1.Size = New System.Drawing.Size(102, 21)
        Me.from_dateTimePicker1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "まで"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "～"
        '
        'Phone_book_ds
        '
        Me.Phone_book_ds.DataSetName = "Phone_book_ds"
        Me.Phone_book_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_listBindingSource
        '
        Me.Customer_listBindingSource.DataMember = "customer_list"
        Me.Customer_listBindingSource.DataSource = Me.Phone_book_ds
        '
        'Customer_listTableAdapter
        '
        Me.Customer_listTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customer_listTableAdapter = Me.Customer_listTableAdapter
        Me.TableAdapterManager.UpdateOrder = phone_book_search.Phone_book_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customer_listBindingNavigator
        '
        Me.Customer_listBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Customer_listBindingNavigator.BindingSource = Me.Customer_listBindingSource
        Me.Customer_listBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Customer_listBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Customer_listBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Customer_listBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Customer_listBindingNavigatorSaveItem})
        Me.Customer_listBindingNavigator.Location = New System.Drawing.Point(0, 573)
        Me.Customer_listBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Customer_listBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Customer_listBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Customer_listBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Customer_listBindingNavigator.Name = "Customer_listBindingNavigator"
        Me.Customer_listBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Customer_listBindingNavigator.Size = New System.Drawing.Size(578, 25)
        Me.Customer_listBindingNavigator.TabIndex = 1
        Me.Customer_listBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        Me.BindingNavigatorDeleteItem.Visible = False
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Customer_listBindingNavigatorSaveItem
        '
        Me.Customer_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Customer_listBindingNavigatorSaveItem.Image = CType(resources.GetObject("Customer_listBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Customer_listBindingNavigatorSaveItem.Name = "Customer_listBindingNavigatorSaveItem"
        Me.Customer_listBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Customer_listBindingNavigatorSaveItem.Text = "データの保存"
        Me.Customer_listBindingNavigatorSaveItem.Visible = False
        '
        'Customer_listDataGridView
        '
        Me.Customer_listDataGridView.AllowUserToAddRows = False
        Me.Customer_listDataGridView.AllowUserToDeleteRows = False
        Me.Customer_listDataGridView.AutoGenerateColumns = False
        Me.Customer_listDataGridView.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.Customer_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_listDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Customer_listDataGridView.DataSource = Me.Customer_listBindingSource
        Me.Customer_listDataGridView.Location = New System.Drawing.Point(12, 198)
        Me.Customer_listDataGridView.Name = "Customer_listDataGridView"
        Me.Customer_listDataGridView.ReadOnly = True
        Me.Customer_listDataGridView.RowTemplate.Height = 40
        Me.Customer_listDataGridView.Size = New System.Drawing.Size(546, 368)
        Me.Customer_listDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "顧客ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "苗字"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "名前"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "年齢"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date_of_birth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "生年月日"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "customer_image"
        Me.DataGridViewImageColumn1.HeaderText = "customer_image"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "debt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "負債"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cell_number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "携帯電話"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "land_line"
        Me.DataGridViewTextBoxColumn8.HeaderText = "固定電話"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn9.HeaderText = "メールアドレス"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn10.HeaderText = "住所"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "comment"
        Me.DataGridViewTextBoxColumn11.HeaderText = "コメント"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(453, 573)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "全表示"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'search_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(578, 598)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Customer_listDataGridView)
        Me.Controls.Add(Me.Customer_listBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "search_form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "検索フォーム"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.date_panel2.ResumeLayout(False)
        Me.date_panel2.PerformLayout()
        CType(Me.Phone_book_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_listBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_listBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customer_listBindingNavigator.ResumeLayout(False)
        Me.Customer_listBindingNavigator.PerformLayout()
        CType(Me.Customer_listDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents and_Label2 As Label
    Friend WithEvents second_value_tb As TextBox
    Friend WithEvents first_value_tb As TextBox
    Friend WithEvents search_type_cbox As ComboBox
    Friend WithEvents search_item_cbox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents date_panel2 As Panel
    Friend WithEvents from_dateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents to_dateTimePicker2 As DateTimePicker
    Friend WithEvents Phone_book_ds As Phone_book_ds
    Friend WithEvents Customer_listBindingSource As BindingSource
    Friend WithEvents Customer_listTableAdapter As Phone_book_dsTableAdapters.customer_listTableAdapter
    Friend WithEvents TableAdapterManager As Phone_book_dsTableAdapters.TableAdapterManager
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
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class

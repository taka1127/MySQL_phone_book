<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.auto_load_checkBox2 = New System.Windows.Forms.CheckBox()
        Me.auto_search_checkBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.search_textBox1 = New System.Windows.Forms.TextBox()
        Me.search_type_comboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.En_dic_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.En_dic_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.En_dic_ds = New english_dictionary.en_dic_ds()
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
        Me.En_dic_tableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.En_dic_tableDataGridView = New System.Windows.Forms.DataGridView()
        Me.En_dic_tableTableAdapter = New english_dictionary.en_dic_dsTableAdapters.en_dic_tableTableAdapter()
        Me.TableAdapterManager = New english_dictionary.en_dic_dsTableAdapters.TableAdapterManager()
        Me.progress_Panel2 = New System.Windows.Forms.Panel()
        Me.plog_label_Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EndictableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.En_dic_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.En_dic_tableBindingNavigator.SuspendLayout()
        CType(Me.En_dic_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.En_dic_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.En_dic_tableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.progress_Panel2.SuspendLayout()
        CType(Me.EndictableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.auto_load_checkBox2)
        Me.Panel1.Controls.Add(Me.auto_search_checkBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.search_textBox1)
        Me.Panel1.Controls.Add(Me.search_type_comboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 82)
        Me.Panel1.TabIndex = 0
        '
        'auto_load_checkBox2
        '
        Me.auto_load_checkBox2.AutoSize = True
        Me.auto_load_checkBox2.Location = New System.Drawing.Point(309, 60)
        Me.auto_load_checkBox2.Name = "auto_load_checkBox2"
        Me.auto_load_checkBox2.Size = New System.Drawing.Size(94, 16)
        Me.auto_load_checkBox2.TabIndex = 5
        Me.auto_load_checkBox2.Text = "自動読み込み"
        Me.auto_load_checkBox2.UseVisualStyleBackColor = True
        '
        'auto_search_checkBox1
        '
        Me.auto_search_checkBox1.AutoSize = True
        Me.auto_search_checkBox1.Location = New System.Drawing.Point(131, 60)
        Me.auto_search_checkBox1.Name = "auto_search_checkBox1"
        Me.auto_search_checkBox1.Size = New System.Drawing.Size(72, 16)
        Me.auto_search_checkBox1.TabIndex = 4
        Me.auto_search_checkBox1.Text = "自動検索"
        Me.auto_search_checkBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.english_dictionary.My.Resources.Resources.search_24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(387, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'search_textBox1
        '
        Me.search_textBox1.Location = New System.Drawing.Point(258, 23)
        Me.search_textBox1.Name = "search_textBox1"
        Me.search_textBox1.Size = New System.Drawing.Size(123, 19)
        Me.search_textBox1.TabIndex = 2
        '
        'search_type_comboBox1
        '
        Me.search_type_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.search_type_comboBox1.FormattingEnabled = True
        Me.search_type_comboBox1.Items.AddRange(New Object() {"=", "Starts with", "Ends with", "Every where"})
        Me.search_type_comboBox1.Location = New System.Drawing.Point(131, 22)
        Me.search_type_comboBox1.Name = "search_type_comboBox1"
        Me.search_type_comboBox1.Size = New System.Drawing.Size(121, 20)
        Me.search_type_comboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Word"
        '
        'En_dic_tableBindingNavigator
        '
        Me.En_dic_tableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.En_dic_tableBindingNavigator.AutoSize = False
        Me.En_dic_tableBindingNavigator.BindingSource = Me.En_dic_tableBindingSource
        Me.En_dic_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.En_dic_tableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.En_dic_tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.En_dic_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.En_dic_tableBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.En_dic_tableBindingNavigator.Location = New System.Drawing.Point(0, 531)
        Me.En_dic_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.En_dic_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.En_dic_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.En_dic_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.En_dic_tableBindingNavigator.Name = "En_dic_tableBindingNavigator"
        Me.En_dic_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.En_dic_tableBindingNavigator.Size = New System.Drawing.Size(539, 31)
        Me.En_dic_tableBindingNavigator.TabIndex = 1
        Me.En_dic_tableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'En_dic_tableBindingSource
        '
        Me.En_dic_tableBindingSource.DataMember = "en_dic_table"
        Me.En_dic_tableBindingSource.DataSource = Me.En_dic_ds
        '
        'En_dic_ds
        '
        Me.En_dic_ds.DataSetName = "en_dic_ds"
        Me.En_dic_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 28)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'En_dic_tableBindingNavigatorSaveItem
        '
        Me.En_dic_tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.En_dic_tableBindingNavigatorSaveItem.Image = CType(resources.GetObject("En_dic_tableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.En_dic_tableBindingNavigatorSaveItem.Name = "En_dic_tableBindingNavigatorSaveItem"
        Me.En_dic_tableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 28)
        Me.En_dic_tableBindingNavigatorSaveItem.Text = "データの保存"
        Me.En_dic_tableBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.english_dictionary.My.Resources.Resources.load_all
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 28)
        Me.ToolStripButton1.Text = "Show All"
        '
        'En_dic_tableDataGridView
        '
        Me.En_dic_tableDataGridView.AllowUserToAddRows = False
        Me.En_dic_tableDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.En_dic_tableDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.En_dic_tableDataGridView.AutoGenerateColumns = False
        Me.En_dic_tableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.En_dic_tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.En_dic_tableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.En_dic_tableDataGridView.DataSource = Me.En_dic_tableBindingSource
        Me.En_dic_tableDataGridView.Location = New System.Drawing.Point(4, 88)
        Me.En_dic_tableDataGridView.Name = "En_dic_tableDataGridView"
        Me.En_dic_tableDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.En_dic_tableDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.En_dic_tableDataGridView.RowTemplate.Height = 21
        Me.En_dic_tableDataGridView.Size = New System.Drawing.Size(531, 261)
        Me.En_dic_tableDataGridView.TabIndex = 2
        '
        'En_dic_tableTableAdapter
        '
        Me.En_dic_tableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.en_dic_tableTableAdapter = Me.En_dic_tableTableAdapter
        Me.TableAdapterManager.UpdateOrder = english_dictionary.en_dic_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'progress_Panel2
        '
        Me.progress_Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.progress_Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.progress_Panel2.Controls.Add(Me.plog_label_Label3)
        Me.progress_Panel2.Controls.Add(Me.Label2)
        Me.progress_Panel2.Location = New System.Drawing.Point(165, 153)
        Me.progress_Panel2.Name = "progress_Panel2"
        Me.progress_Panel2.Size = New System.Drawing.Size(200, 100)
        Me.progress_Panel2.TabIndex = 3
        Me.progress_Panel2.Visible = False
        '
        'plog_label_Label3
        '
        Me.plog_label_Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.plog_label_Label3.ForeColor = System.Drawing.Color.Blue
        Me.plog_label_Label3.Location = New System.Drawing.Point(-1, 54)
        Me.plog_label_Label3.Name = "plog_label_Label3"
        Me.plog_label_Label3.Size = New System.Drawing.Size(200, 24)
        Me.plog_label_Label3.TabIndex = 1
        Me.plog_label_Label3.Text = "Loading Data..."
        Me.plog_label_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(41, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please Wait..."
        '
        'EndictableBindingSource
        '
        Me.EndictableBindingSource.DataMember = "en_dic_table"
        Me.EndictableBindingSource.DataSource = Me.En_dic_ds
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.En_dic_tableBindingSource, "definition", True))
        Me.TextBox2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 353)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(531, 175)
        Me.TextBox2.TabIndex = 4
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "word"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Word"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "wordtype"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Wordtype"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "definition"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Definition"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(539, 562)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.progress_Panel2)
        Me.Controls.Add(Me.En_dic_tableDataGridView)
        Me.Controls.Add(Me.En_dic_tableBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KSG English Dictionary(英字辞典)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.En_dic_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.En_dic_tableBindingNavigator.ResumeLayout(False)
        Me.En_dic_tableBindingNavigator.PerformLayout()
        CType(Me.En_dic_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.En_dic_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.En_dic_tableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.progress_Panel2.ResumeLayout(False)
        Me.progress_Panel2.PerformLayout()
        CType(Me.EndictableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents search_textBox1 As TextBox
    Friend WithEvents search_type_comboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents auto_load_checkBox2 As CheckBox
    Friend WithEvents auto_search_checkBox1 As CheckBox
    Friend WithEvents En_dic_ds As en_dic_ds
    Friend WithEvents En_dic_tableBindingSource As BindingSource
    Friend WithEvents En_dic_tableTableAdapter As en_dic_dsTableAdapters.en_dic_tableTableAdapter
    Friend WithEvents TableAdapterManager As en_dic_dsTableAdapters.TableAdapterManager
    Friend WithEvents En_dic_tableBindingNavigator As BindingNavigator
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
    Friend WithEvents En_dic_tableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents En_dic_tableDataGridView As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents progress_Panel2 As Panel
    Friend WithEvents plog_label_Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EndictableBindingSource As BindingSource
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

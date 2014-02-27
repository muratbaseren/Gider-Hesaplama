<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.grpProductDetail = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.pnProductDetail = New System.Windows.Forms.Panel()
        Me.txtProductComment = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudProductQuantity = New System.Windows.Forms.NumericUpDown()
        Me.dtpProductPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpProductBuyDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.cmnuTotalMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgwResult = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFullTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectRowsTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTotalInvisible = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTotalVisible = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintWebPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintTextFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.DbExpenceDataSet = New WinGiderHesaplama.DbExpenceDataSet()
        Me.DbExpenceDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New WinGiderHesaplama.DbExpenceDataSetTableAdapters.CategoryTableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.grpProductDetail.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnProductDetail.SuspendLayout()
        CType(Me.nudProductQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResult.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.cmnuTotalMain.SuspendLayout()
        CType(Me.dgwResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpCategory.SuspendLayout()
        CType(Me.DbExpenceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbExpenceDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpProductDetail
        '
        Me.grpProductDetail.Controls.Add(Me.Panel1)
        Me.grpProductDetail.Controls.Add(Me.pnProductDetail)
        Me.grpProductDetail.Location = New System.Drawing.Point(15, 71)
        Me.grpProductDetail.Name = "grpProductDetail"
        Me.grpProductDetail.Size = New System.Drawing.Size(247, 275)
        Me.grpProductDetail.TabIndex = 3
        Me.grpProductDetail.TabStop = False
        Me.grpProductDetail.Text = "Kayýt Ekleme \ Düzenleme \ Silme"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Location = New System.Drawing.Point(6, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 75)
        Me.Panel1.TabIndex = 16
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(154, 40)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 31)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Sil"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(77, 40)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ýptal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(154, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Kaydet"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(77, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 31)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Yeni"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'pnProductDetail
        '
        Me.pnProductDetail.Controls.Add(Me.txtProductComment)
        Me.pnProductDetail.Controls.Add(Me.Label7)
        Me.pnProductDetail.Controls.Add(Me.nudProductQuantity)
        Me.pnProductDetail.Controls.Add(Me.dtpProductPaymentDate)
        Me.pnProductDetail.Controls.Add(Me.Label5)
        Me.pnProductDetail.Controls.Add(Me.Label4)
        Me.pnProductDetail.Controls.Add(Me.dtpProductBuyDate)
        Me.pnProductDetail.Controls.Add(Me.Label3)
        Me.pnProductDetail.Controls.Add(Me.txtProductPrice)
        Me.pnProductDetail.Controls.Add(Me.Label2)
        Me.pnProductDetail.Controls.Add(Me.txtProductName)
        Me.pnProductDetail.Controls.Add(Me.Label1)
        Me.pnProductDetail.Location = New System.Drawing.Point(6, 19)
        Me.pnProductDetail.Name = "pnProductDetail"
        Me.pnProductDetail.Size = New System.Drawing.Size(235, 168)
        Me.pnProductDetail.TabIndex = 15
        '
        'txtProductComment
        '
        Me.txtProductComment.Location = New System.Drawing.Point(77, 138)
        Me.txtProductComment.Name = "txtProductComment"
        Me.txtProductComment.Size = New System.Drawing.Size(152, 20)
        Me.txtProductComment.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Açýklama"
        '
        'nudProductQuantity
        '
        Me.nudProductQuantity.Location = New System.Drawing.Point(77, 86)
        Me.nudProductQuantity.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudProductQuantity.Name = "nudProductQuantity"
        Me.nudProductQuantity.Size = New System.Drawing.Size(58, 20)
        Me.nudProductQuantity.TabIndex = 21
        '
        'dtpProductPaymentDate
        '
        Me.dtpProductPaymentDate.Checked = False
        Me.dtpProductPaymentDate.Location = New System.Drawing.Point(77, 112)
        Me.dtpProductPaymentDate.Name = "dtpProductPaymentDate"
        Me.dtpProductPaymentDate.ShowCheckBox = True
        Me.dtpProductPaymentDate.Size = New System.Drawing.Size(152, 20)
        Me.dtpProductPaymentDate.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ödeme Günü"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Adet"
        '
        'dtpProductBuyDate
        '
        Me.dtpProductBuyDate.Location = New System.Drawing.Point(77, 61)
        Me.dtpProductBuyDate.Name = "dtpProductBuyDate"
        Me.dtpProductBuyDate.Size = New System.Drawing.Size(152, 20)
        Me.dtpProductBuyDate.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Alým Günü"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(77, 35)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(152, 20)
        Me.txtProductPrice.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ürün Tutar"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(77, 10)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(152, 20)
        Me.txtProductName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ürün Adý"
        '
        'grpResult
        '
        Me.grpResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResult.Controls.Add(Me.grpTotal)
        Me.grpResult.Controls.Add(Me.dgwResult)
        Me.grpResult.Controls.Add(Me.MenuStrip1)
        Me.grpResult.Location = New System.Drawing.Point(265, 12)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(435, 334)
        Me.grpResult.TabIndex = 4
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Sonuçlar"
        '
        'grpTotal
        '
        Me.grpTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpTotal.ContextMenuStrip = Me.cmnuTotalMain
        Me.grpTotal.Controls.Add(Me.Label6)
        Me.grpTotal.Controls.Add(Me.txtTotal)
        Me.grpTotal.ForeColor = System.Drawing.SystemColors.Desktop
        Me.grpTotal.Location = New System.Drawing.Point(239, 243)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(191, 65)
        Me.grpTotal.TabIndex = 7
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Tutar Toplamý"
        Me.grpTotal.Visible = False
        '
        'cmnuTotalMain
        '
        Me.cmnuTotalMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuTotal})
        Me.cmnuTotalMain.Name = "cmnuTotalMain"
        Me.cmnuTotalMain.Size = New System.Drawing.Size(171, 26)
        '
        'cmnuTotal
        '
        Me.cmnuTotal.Name = "cmnuTotal"
        Me.cmnuTotal.Size = New System.Drawing.Size(170, 22)
        Me.cmnuTotal.Text = "Tutar Alanýný Gizle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ContextMenuStrip = Me.cmnuTotalMain
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(139, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "YTL"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(6, 24)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(133, 29)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgwResult
        '
        Me.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwResult.Location = New System.Drawing.Point(3, 40)
        Me.dgwResult.Name = "dgwResult"
        Me.dgwResult.Size = New System.Drawing.Size(429, 291)
        Me.dgwResult.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTotal, Me.mnuSearch, Me.mnuPrint})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(429, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuTotal
        '
        Me.mnuTotal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFullTotal, Me.mnuSelectRowsTotal, Me.ToolStripMenuItem1, Me.mnuTotalInvisible, Me.mnuTotalVisible})
        Me.mnuTotal.Name = "mnuTotal"
        Me.mnuTotal.ShortcutKeyDisplayString = "Alt+H"
        Me.mnuTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuTotal.Size = New System.Drawing.Size(105, 20)
        Me.mnuTotal.Text = "Toplam &Hesapla"
        '
        'mnuFullTotal
        '
        Me.mnuFullTotal.Name = "mnuFullTotal"
        Me.mnuFullTotal.ShortcutKeyDisplayString = "Alt+T"
        Me.mnuFullTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuFullTotal.Size = New System.Drawing.Size(264, 22)
        Me.mnuFullTotal.Text = "&Toplam Tutar"
        '
        'mnuSelectRowsTotal
        '
        Me.mnuSelectRowsTotal.Name = "mnuSelectRowsTotal"
        Me.mnuSelectRowsTotal.ShortcutKeyDisplayString = "Alt+S"
        Me.mnuSelectRowsTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSelectRowsTotal.Size = New System.Drawing.Size(264, 22)
        Me.mnuSelectRowsTotal.Text = "Seçili &Satýrlarýn Toplam Tutarý"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(261, 6)
        '
        'mnuTotalInvisible
        '
        Me.mnuTotalInvisible.Checked = True
        Me.mnuTotalInvisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuTotalInvisible.Name = "mnuTotalInvisible"
        Me.mnuTotalInvisible.ShortcutKeyDisplayString = "Alt+Z"
        Me.mnuTotalInvisible.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuTotalInvisible.Size = New System.Drawing.Size(264, 22)
        Me.mnuTotalInvisible.Text = "Tutar Alaný Gi&zle"
        '
        'mnuTotalVisible
        '
        Me.mnuTotalVisible.Name = "mnuTotalVisible"
        Me.mnuTotalVisible.ShortcutKeyDisplayString = "Alt+E"
        Me.mnuTotalVisible.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuTotalVisible.Size = New System.Drawing.Size(264, 22)
        Me.mnuTotalVisible.Text = "Tutar Alaný Göst&er"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.ShortcutKeyDisplayString = "Alt+A"
        Me.mnuSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuSearch.Size = New System.Drawing.Size(43, 20)
        Me.mnuSearch.Text = "&Ara !"
        '
        'mnuPrint
        '
        Me.mnuPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintWebPage, Me.mnuPrintTextFile})
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.ShortcutKeyDisplayString = "Alt+Y"
        Me.mnuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuPrint.Size = New System.Drawing.Size(57, 20)
        Me.mnuPrint.Text = "&Yazdýr !"
        '
        'mnuPrintWebPage
        '
        Me.mnuPrintWebPage.Name = "mnuPrintWebPage"
        Me.mnuPrintWebPage.Size = New System.Drawing.Size(182, 22)
        Me.mnuPrintWebPage.Text = "Web Sayfasý Olarak"
        '
        'mnuPrintTextFile
        '
        Me.mnuPrintTextFile.Name = "mnuPrintTextFile"
        Me.mnuPrintTextFile.Size = New System.Drawing.Size(182, 22)
        Me.mnuPrintTextFile.Text = "Metin Belgesi Olarak"
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.cmbCategory)
        Me.grpCategory.Location = New System.Drawing.Point(15, 12)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(247, 53)
        Me.grpCategory.TabIndex = 5
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Kategoriler"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(6, 19)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(235, 21)
        Me.cmbCategory.TabIndex = 0
        '
        'DbExpenceDataSet
        '
        Me.DbExpenceDataSet.DataSetName = "DbExpenceDataSet"
        Me.DbExpenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbExpenceDataSetBindingSource
        '
        Me.DbExpenceDataSetBindingSource.DataSource = Me.DbExpenceDataSet
        Me.DbExpenceDataSetBindingSource.Position = 0
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.DbExpenceDataSetBindingSource
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'frmProduct
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(701, 357)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.grpResult)
        Me.Controls.Add(Me.grpProductDetail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProduct"
        Me.Text = "Kayýt Ýþlemleri"
        Me.grpProductDetail.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnProductDetail.ResumeLayout(False)
        Me.pnProductDetail.PerformLayout()
        CType(Me.nudProductQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
        Me.cmnuTotalMain.ResumeLayout(False)
        CType(Me.dgwResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpCategory.ResumeLayout(False)
        CType(Me.DbExpenceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbExpenceDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpProductDetail As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents pnProductDetail As System.Windows.Forms.Panel
    Friend WithEvents txtProductComment As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudProductQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpProductPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpProductBuyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProductPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpResult As System.Windows.Forms.GroupBox
    Friend WithEvents dgwResult As System.Windows.Forms.DataGridView
    Friend WithEvents grpCategory As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents DbExpenceDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbExpenceDataSet As WinGiderHesaplama.DbExpenceDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As WinGiderHesaplama.DbExpenceDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFullTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectRowsTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTotalInvisible As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTotalVisible As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuTotalMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintWebPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintTextFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class

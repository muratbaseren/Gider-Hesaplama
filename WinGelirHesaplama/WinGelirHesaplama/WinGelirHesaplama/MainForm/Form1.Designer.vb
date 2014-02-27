<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpCategory = New System.Windows.Forms.GroupBox
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbExpenceDataSet = New WinGiderHesaplama.DbExpenceDataSet
        Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker
        Me.grpResult = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgwResult = New System.Windows.Forms.DataGridView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssProductCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFullTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSelectedRowsTotal = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrintWebPage = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrintTextFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProcess = New System.Windows.Forms.MenuStrip
        Me.ÝþlemlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCategoryProcess = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCategoryEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuChangeProductCategory = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProductProcess = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProductEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoryTableAdapter = New WinGiderHesaplama.DbExpenceDataSetTableAdapters.CategoryTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grpTotal = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.grpCategory.SuspendLayout()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbExpenceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpResult.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgwResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.mnuProcess.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.cmbCategory)
        Me.grpCategory.Location = New System.Drawing.Point(12, 27)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(247, 65)
        Me.grpCategory.TabIndex = 0
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Kategoriler"
        '
        'cmbCategory
        '
        Me.cmbCategory.DataSource = Me.CategoryBindingSource
        Me.cmbCategory.DisplayMember = "cate_Name"
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Location = New System.Drawing.Point(6, 28)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(235, 21)
        Me.cmbCategory.TabIndex = 0
        Me.cmbCategory.ValueMember = "cate_ID"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.DbExpenceDataSet
        '
        'DbExpenceDataSet
        '
        Me.DbExpenceDataSet.DataSetName = "DbExpenceDataSet"
        Me.DbExpenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpSelectDate
        '
        Me.dtpSelectDate.Checked = False
        Me.dtpSelectDate.Location = New System.Drawing.Point(6, 29)
        Me.dtpSelectDate.Name = "dtpSelectDate"
        Me.dtpSelectDate.ShowCheckBox = True
        Me.dtpSelectDate.Size = New System.Drawing.Size(235, 20)
        Me.dtpSelectDate.TabIndex = 1
        '
        'grpResult
        '
        Me.grpResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResult.Controls.Add(Me.Panel1)
        Me.grpResult.Controls.Add(Me.StatusStrip1)
        Me.grpResult.Controls.Add(Me.MenuStrip1)
        Me.grpResult.Location = New System.Drawing.Point(12, 98)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(696, 288)
        Me.grpResult.TabIndex = 3
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Sonuçlar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgwResult)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 223)
        Me.Panel1.TabIndex = 3
        '
        'dgwResult
        '
        Me.dgwResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwResult.Location = New System.Drawing.Point(0, 0)
        Me.dgwResult.Name = "dgwResult"
        Me.dgwResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgwResult.Size = New System.Drawing.Size(690, 223)
        Me.dgwResult.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssProductCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 263)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(690, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssProductCount
        '
        Me.tssProductCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssProductCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssProductCount.Name = "tssProductCount"
        Me.tssProductCount.Size = New System.Drawing.Size(4, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTotal, Me.mnuSearch, Me.mnuPrint})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuTotal
        '
        Me.mnuTotal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFullTotal, Me.mnuSelectedRowsTotal})
        Me.mnuTotal.Name = "mnuTotal"
        Me.mnuTotal.ShortcutKeyDisplayString = "Alt+H"
        Me.mnuTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuTotal.Size = New System.Drawing.Size(94, 20)
        Me.mnuTotal.Text = "Toplam &Hesapla"
        '
        'mnuFullTotal
        '
        Me.mnuFullTotal.Name = "mnuFullTotal"
        Me.mnuFullTotal.ShortcutKeyDisplayString = "Alt+T"
        Me.mnuFullTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuFullTotal.Size = New System.Drawing.Size(245, 22)
        Me.mnuFullTotal.Text = "&Toplam Tutar"
        '
        'mnuSelectedRowsTotal
        '
        Me.mnuSelectedRowsTotal.Name = "mnuSelectedRowsTotal"
        Me.mnuSelectedRowsTotal.ShortcutKeyDisplayString = "Alt+S"
        Me.mnuSelectedRowsTotal.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSelectedRowsTotal.Size = New System.Drawing.Size(245, 22)
        Me.mnuSelectedRowsTotal.Text = "Seçili &Satýrlar Toplam Tutar"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.ShortcutKeyDisplayString = "Alt+A"
        Me.mnuSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuSearch.Size = New System.Drawing.Size(43, 20)
        Me.mnuSearch.Text = "Ar&a !"
        '
        'mnuPrint
        '
        Me.mnuPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintWebPage, Me.mnuPrintTextFile})
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.ShortcutKeyDisplayString = "Alt+Y"
        Me.mnuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuPrint.Size = New System.Drawing.Size(55, 20)
        Me.mnuPrint.Text = "&Yazdýr !"
        '
        'mnuPrintWebPage
        '
        Me.mnuPrintWebPage.Name = "mnuPrintWebPage"
        Me.mnuPrintWebPage.Size = New System.Drawing.Size(181, 22)
        Me.mnuPrintWebPage.Text = "Web Sayfasý Olarak"
        '
        'mnuPrintTextFile
        '
        Me.mnuPrintTextFile.Name = "mnuPrintTextFile"
        Me.mnuPrintTextFile.Size = New System.Drawing.Size(181, 22)
        Me.mnuPrintTextFile.Text = "Metin Belgesi Olarak"
        '
        'mnuProcess
        '
        Me.mnuProcess.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÝþlemlerToolStripMenuItem})
        Me.mnuProcess.Location = New System.Drawing.Point(0, 0)
        Me.mnuProcess.Name = "mnuProcess"
        Me.mnuProcess.Size = New System.Drawing.Size(720, 24)
        Me.mnuProcess.TabIndex = 4
        Me.mnuProcess.Text = "MenuStrip1"
        '
        'ÝþlemlerToolStripMenuItem
        '
        Me.ÝþlemlerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCategoryProcess, Me.mnuProductProcess, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.ÝþlemlerToolStripMenuItem.Name = "ÝþlemlerToolStripMenuItem"
        Me.ÝþlemlerToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ÝþlemlerToolStripMenuItem.Text = "Ýþlemler"
        '
        'mnuCategoryProcess
        '
        Me.mnuCategoryProcess.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCategoryEdit, Me.ToolStripMenuItem2, Me.mnuChangeProductCategory})
        Me.mnuCategoryProcess.Name = "mnuCategoryProcess"
        Me.mnuCategoryProcess.Size = New System.Drawing.Size(167, 22)
        Me.mnuCategoryProcess.Text = "Kategori Ýþlemleri"
        '
        'mnuCategoryEdit
        '
        Me.mnuCategoryEdit.Name = "mnuCategoryEdit"
        Me.mnuCategoryEdit.Size = New System.Drawing.Size(212, 22)
        Me.mnuCategoryEdit.Text = "Kategorileri Düzenle"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 6)
        '
        'mnuChangeProductCategory
        '
        Me.mnuChangeProductCategory.Name = "mnuChangeProductCategory"
        Me.mnuChangeProductCategory.Size = New System.Drawing.Size(212, 22)
        Me.mnuChangeProductCategory.Text = "Kayýt Kategorisi Deðiþtirme"
        '
        'mnuProductProcess
        '
        Me.mnuProductProcess.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProductEdit})
        Me.mnuProductProcess.Name = "mnuProductProcess"
        Me.mnuProductProcess.Size = New System.Drawing.Size(167, 22)
        Me.mnuProductProcess.Text = "Kayýt Ýþlemleri"
        '
        'mnuProductEdit
        '
        Me.mnuProductEdit.Name = "mnuProductEdit"
        Me.mnuProductEdit.Size = New System.Drawing.Size(164, 22)
        Me.mnuProductEdit.Text = "Kayýtlarý Düzenle"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(167, 22)
        Me.mnuExit.Text = "Çýkýþ"
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpSelectDate)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 65)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seçili Gün"
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.Label1)
        Me.grpTotal.Controls.Add(Me.txtTotal)
        Me.grpTotal.Location = New System.Drawing.Point(517, 27)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(191, 65)
        Me.grpTotal.TabIndex = 6
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Tutar Toplamý"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "YTL"
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 398)
        Me.Controls.Add(Me.grpTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpResult)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.mnuProcess)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuProcess
        Me.Name = "frmMain"
        Me.Text = "Windows Gider Hesaplama - Windows Calculating to Expense"
        Me.grpCategory.ResumeLayout(False)
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbExpenceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgwResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mnuProcess.ResumeLayout(False)
        Me.mnuProcess.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCategory As System.Windows.Forms.GroupBox
    Friend WithEvents grpResult As System.Windows.Forms.GroupBox
    Friend WithEvents dgwResult As System.Windows.Forms.DataGridView
    Friend WithEvents dtpSelectDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents mnuProcess As System.Windows.Forms.MenuStrip
    Friend WithEvents ÝþlemlerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCategoryProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProductProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCategoryEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChangeProductCategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProductEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DbExpenceDataSet As WinGiderHesaplama.DbExpenceDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As WinGiderHesaplama.DbExpenceDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFullTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectedRowsTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssProductCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents mnuPrintWebPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintTextFile As System.Windows.Forms.ToolStripMenuItem

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeCategory))
        Me.grpOldCategory = New System.Windows.Forms.GroupBox
        Me.btnOldSelectAll = New System.Windows.Forms.Button
        Me.lswOldProduct = New System.Windows.Forms.ListView
        Me.clmProd_ID = New System.Windows.Forms.ColumnHeader
        Me.clmProd_Name = New System.Windows.Forms.ColumnHeader
        Me.clmPrice = New System.Windows.Forms.ColumnHeader
        Me.clmBuyDate = New System.Windows.Forms.ColumnHeader
        Me.clmQuantity = New System.Windows.Forms.ColumnHeader
        Me.clmPayDate = New System.Windows.Forms.ColumnHeader
        Me.clmComment = New System.Windows.Forms.ColumnHeader
        Me.cmbOldCategory = New System.Windows.Forms.ComboBox
        Me.grpNewCategory = New System.Windows.Forms.GroupBox
        Me.btnNewSelectAll = New System.Windows.Forms.Button
        Me.lswNewProduct = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.cmbNewCategory = New System.Windows.Forms.ComboBox
        Me.btnSendRight = New System.Windows.Forms.Button
        Me.btnSendLeft = New System.Windows.Forms.Button
        Me.grpOldCategory.SuspendLayout()
        Me.grpNewCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOldCategory
        '
        Me.grpOldCategory.Controls.Add(Me.btnOldSelectAll)
        Me.grpOldCategory.Controls.Add(Me.lswOldProduct)
        Me.grpOldCategory.Controls.Add(Me.cmbOldCategory)
        Me.grpOldCategory.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpOldCategory.Location = New System.Drawing.Point(0, 0)
        Me.grpOldCategory.Name = "grpOldCategory"
        Me.grpOldCategory.Size = New System.Drawing.Size(430, 372)
        Me.grpOldCategory.TabIndex = 1
        Me.grpOldCategory.TabStop = False
        Me.grpOldCategory.Text = "Kaydýn Eski Kategorisi"
        '
        'btnOldSelectAll
        '
        Me.btnOldSelectAll.Location = New System.Drawing.Point(335, 26)
        Me.btnOldSelectAll.Name = "btnOldSelectAll"
        Me.btnOldSelectAll.Size = New System.Drawing.Size(89, 23)
        Me.btnOldSelectAll.TabIndex = 2
        Me.btnOldSelectAll.Text = "Tümünü Seç"
        Me.btnOldSelectAll.UseVisualStyleBackColor = True
        '
        'lswOldProduct
        '
        Me.lswOldProduct.CheckBoxes = True
        Me.lswOldProduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmProd_ID, Me.clmProd_Name, Me.clmPrice, Me.clmBuyDate, Me.clmQuantity, Me.clmPayDate, Me.clmComment})
        Me.lswOldProduct.FullRowSelect = True
        Me.lswOldProduct.Location = New System.Drawing.Point(6, 55)
        Me.lswOldProduct.Name = "lswOldProduct"
        Me.lswOldProduct.Size = New System.Drawing.Size(418, 305)
        Me.lswOldProduct.TabIndex = 1
        Me.lswOldProduct.UseCompatibleStateImageBehavior = False
        Me.lswOldProduct.View = System.Windows.Forms.View.Details
        '
        'clmProd_ID
        '
        Me.clmProd_ID.Text = "No"
        Me.clmProd_ID.Width = 40
        '
        'clmProd_Name
        '
        Me.clmProd_Name.Text = "Ürün Adý"
        Me.clmProd_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clmPrice
        '
        Me.clmPrice.Text = "Tutar"
        Me.clmPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmPrice.Width = 50
        '
        'clmBuyDate
        '
        Me.clmBuyDate.Text = "Alým Günü"
        Me.clmBuyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmBuyDate.Width = 70
        '
        'clmQuantity
        '
        Me.clmQuantity.Text = "Adet"
        Me.clmQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmQuantity.Width = 40
        '
        'clmPayDate
        '
        Me.clmPayDate.Text = "Ödeme Günü"
        Me.clmPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmPayDate.Width = 80
        '
        'clmComment
        '
        Me.clmComment.Text = "Açýklama"
        Me.clmComment.Width = 80
        '
        'cmbOldCategory
        '
        Me.cmbOldCategory.DisplayMember = "cate_Name"
        Me.cmbOldCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOldCategory.Location = New System.Drawing.Point(6, 28)
        Me.cmbOldCategory.Name = "cmbOldCategory"
        Me.cmbOldCategory.Size = New System.Drawing.Size(235, 21)
        Me.cmbOldCategory.TabIndex = 0
        Me.cmbOldCategory.ValueMember = "cate_ID"
        '
        'grpNewCategory
        '
        Me.grpNewCategory.Controls.Add(Me.btnNewSelectAll)
        Me.grpNewCategory.Controls.Add(Me.lswNewProduct)
        Me.grpNewCategory.Controls.Add(Me.cmbNewCategory)
        Me.grpNewCategory.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpNewCategory.Location = New System.Drawing.Point(492, 0)
        Me.grpNewCategory.Name = "grpNewCategory"
        Me.grpNewCategory.Size = New System.Drawing.Size(432, 372)
        Me.grpNewCategory.TabIndex = 2
        Me.grpNewCategory.TabStop = False
        Me.grpNewCategory.Text = "Kaydýn Yeni Kategorisi"
        '
        'btnNewSelectAll
        '
        Me.btnNewSelectAll.Location = New System.Drawing.Point(337, 26)
        Me.btnNewSelectAll.Name = "btnNewSelectAll"
        Me.btnNewSelectAll.Size = New System.Drawing.Size(89, 23)
        Me.btnNewSelectAll.TabIndex = 3
        Me.btnNewSelectAll.Text = "Tümünü Seç"
        Me.btnNewSelectAll.UseVisualStyleBackColor = True
        '
        'lswNewProduct
        '
        Me.lswNewProduct.CheckBoxes = True
        Me.lswNewProduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lswNewProduct.FullRowSelect = True
        Me.lswNewProduct.Location = New System.Drawing.Point(8, 55)
        Me.lswNewProduct.Name = "lswNewProduct"
        Me.lswNewProduct.Size = New System.Drawing.Size(418, 305)
        Me.lswNewProduct.TabIndex = 2
        Me.lswNewProduct.UseCompatibleStateImageBehavior = False
        Me.lswNewProduct.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ürün Adý"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tutar"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Alým Günü"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Adet"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 40
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Ödeme Günü"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Açýklama"
        Me.ColumnHeader7.Width = 80
        '
        'cmbNewCategory
        '
        Me.cmbNewCategory.DisplayMember = "cate_Name"
        Me.cmbNewCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewCategory.Location = New System.Drawing.Point(6, 28)
        Me.cmbNewCategory.Name = "cmbNewCategory"
        Me.cmbNewCategory.Size = New System.Drawing.Size(235, 21)
        Me.cmbNewCategory.TabIndex = 0
        Me.cmbNewCategory.ValueMember = "cate_ID"
        '
        'btnSendRight
        '
        Me.btnSendRight.Location = New System.Drawing.Point(436, 140)
        Me.btnSendRight.Name = "btnSendRight"
        Me.btnSendRight.Size = New System.Drawing.Size(49, 38)
        Me.btnSendRight.TabIndex = 3
        Me.btnSendRight.Text = ">>"
        Me.btnSendRight.UseVisualStyleBackColor = True
        '
        'btnSendLeft
        '
        Me.btnSendLeft.Location = New System.Drawing.Point(436, 184)
        Me.btnSendLeft.Name = "btnSendLeft"
        Me.btnSendLeft.Size = New System.Drawing.Size(49, 38)
        Me.btnSendLeft.TabIndex = 4
        Me.btnSendLeft.Text = "<<"
        Me.btnSendLeft.UseVisualStyleBackColor = True
        '
        'frmChangeCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 372)
        Me.Controls.Add(Me.btnSendLeft)
        Me.Controls.Add(Me.btnSendRight)
        Me.Controls.Add(Me.grpNewCategory)
        Me.Controls.Add(Me.grpOldCategory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChangeCategory"
        Me.Text = "Kayýt Kategori Deðiþtirme"
        Me.grpOldCategory.ResumeLayout(False)
        Me.grpNewCategory.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpOldCategory As System.Windows.Forms.GroupBox
    Friend WithEvents grpNewCategory As System.Windows.Forms.GroupBox
    Friend WithEvents btnSendRight As System.Windows.Forms.Button
    Friend WithEvents btnSendLeft As System.Windows.Forms.Button
    Friend WithEvents lswOldProduct As System.Windows.Forms.ListView
    Friend WithEvents clmProd_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmProd_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmBuyDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmPayDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmComment As System.Windows.Forms.ColumnHeader
    Friend WithEvents lswNewProduct As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbOldCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNewCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnOldSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnNewSelectAll As System.Windows.Forms.Button
End Class

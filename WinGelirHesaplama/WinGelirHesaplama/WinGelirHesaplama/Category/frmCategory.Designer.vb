<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategory))
        Me.grpCategoryDetail = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.pnCategoryDetail = New System.Windows.Forms.Panel
        Me.txtCategoryNewName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCategoryOrginalName = New System.Windows.Forms.TextBox
        Me.lblCategoryLabel = New System.Windows.Forms.Label
        Me.grpCategoryList = New System.Windows.Forms.GroupBox
        Me.lstCategory = New System.Windows.Forms.ListView
        Me.clmCategoryID = New System.Windows.Forms.ColumnHeader
        Me.clmCategoryName = New System.Windows.Forms.ColumnHeader
        Me.grpCategoryDetail.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnCategoryDetail.SuspendLayout()
        Me.grpCategoryList.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCategoryDetail
        '
        Me.grpCategoryDetail.Controls.Add(Me.Panel1)
        Me.grpCategoryDetail.Controls.Add(Me.pnCategoryDetail)
        Me.grpCategoryDetail.Location = New System.Drawing.Point(12, 12)
        Me.grpCategoryDetail.Name = "grpCategoryDetail"
        Me.grpCategoryDetail.Size = New System.Drawing.Size(247, 199)
        Me.grpCategoryDetail.TabIndex = 5
        Me.grpCategoryDetail.TabStop = False
        Me.grpCategoryDetail.Text = "Kategori Ekleme \ Düzenleme \ Silme"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Location = New System.Drawing.Point(6, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 75)
        Me.Panel1.TabIndex = 17
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
        'pnCategoryDetail
        '
        Me.pnCategoryDetail.Controls.Add(Me.txtCategoryNewName)
        Me.pnCategoryDetail.Controls.Add(Me.Label6)
        Me.pnCategoryDetail.Controls.Add(Me.txtCategoryOrginalName)
        Me.pnCategoryDetail.Controls.Add(Me.lblCategoryLabel)
        Me.pnCategoryDetail.Location = New System.Drawing.Point(6, 22)
        Me.pnCategoryDetail.Name = "pnCategoryDetail"
        Me.pnCategoryDetail.Size = New System.Drawing.Size(235, 84)
        Me.pnCategoryDetail.TabIndex = 16
        '
        'txtCategoryNewName
        '
        Me.txtCategoryNewName.Location = New System.Drawing.Point(77, 54)
        Me.txtCategoryNewName.Name = "txtCategoryNewName"
        Me.txtCategoryNewName.Size = New System.Drawing.Size(152, 20)
        Me.txtCategoryNewName.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 28)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Yeni Kategori Adý"
        '
        'txtCategoryOrginalName
        '
        Me.txtCategoryOrginalName.Location = New System.Drawing.Point(77, 22)
        Me.txtCategoryOrginalName.Name = "txtCategoryOrginalName"
        Me.txtCategoryOrginalName.ReadOnly = True
        Me.txtCategoryOrginalName.Size = New System.Drawing.Size(152, 20)
        Me.txtCategoryOrginalName.TabIndex = 12
        '
        'lblCategoryLabel
        '
        Me.lblCategoryLabel.Location = New System.Drawing.Point(3, 13)
        Me.lblCategoryLabel.Name = "lblCategoryLabel"
        Me.lblCategoryLabel.Size = New System.Drawing.Size(68, 29)
        Me.lblCategoryLabel.TabIndex = 11
        Me.lblCategoryLabel.Text = "Orjinal Kategori Adý"
        '
        'grpCategoryList
        '
        Me.grpCategoryList.Controls.Add(Me.lstCategory)
        Me.grpCategoryList.Location = New System.Drawing.Point(265, 12)
        Me.grpCategoryList.Name = "grpCategoryList"
        Me.grpCategoryList.Size = New System.Drawing.Size(200, 199)
        Me.grpCategoryList.TabIndex = 6
        Me.grpCategoryList.TabStop = False
        Me.grpCategoryList.Text = "Kategoriler"
        '
        'lstCategory
        '
        Me.lstCategory.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstCategory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmCategoryID, Me.clmCategoryName})
        Me.lstCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstCategory.FullRowSelect = True
        Me.lstCategory.Location = New System.Drawing.Point(3, 16)
        Me.lstCategory.MultiSelect = False
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(194, 180)
        Me.lstCategory.TabIndex = 0
        Me.lstCategory.UseCompatibleStateImageBehavior = False
        Me.lstCategory.View = System.Windows.Forms.View.Details
        '
        'clmCategoryID
        '
        Me.clmCategoryID.Text = "No"
        Me.clmCategoryID.Width = 80
        '
        'clmCategoryName
        '
        Me.clmCategoryName.Text = "Kategori"
        Me.clmCategoryName.Width = 100
        '
        'frmCategory
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(478, 224)
        Me.Controls.Add(Me.grpCategoryList)
        Me.Controls.Add(Me.grpCategoryDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCategory"
        Me.Text = "Kategori Düzenleme"
        Me.grpCategoryDetail.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnCategoryDetail.ResumeLayout(False)
        Me.pnCategoryDetail.PerformLayout()
        Me.grpCategoryList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCategoryDetail As System.Windows.Forms.GroupBox
    Friend WithEvents pnCategoryDetail As System.Windows.Forms.Panel
    Friend WithEvents txtCategoryNewName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCategoryOrginalName As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoryLabel As System.Windows.Forms.Label
    Friend WithEvents grpCategoryList As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lstCategory As System.Windows.Forms.ListView
    Friend WithEvents clmCategoryID As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmCategoryName As System.Windows.Forms.ColumnHeader
End Class

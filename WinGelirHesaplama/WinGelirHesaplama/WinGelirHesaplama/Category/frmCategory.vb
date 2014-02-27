Public Class frmCategory

#Region "Local Variables"
    Private Mode As String
    Private cate_ID As Integer
    Private cate_Name As String
#End Region

#Region "Methods"
    Private Sub ClearAreas()
        'Alanlarýn temizlenmesi..
        Me.txtCategoryOrginalName.Text = ""
        Me.txtCategoryNewName.Text = ""
    End Sub

    Private Sub EnableDisable()
        If Mode = "Update" Then
            Me.btnDelete.Enabled = True
            Me.btnNew.Enabled = True
        Else
            Me.btnDelete.Enabled = False
            Me.btnNew.Enabled = False
        End If
    End Sub

    Private Sub ReadCategories()
        Dim DataPr As DataProcess = New DataProcess
        Dim DT As DataTable = New DataTable

        Me.lstCategory.Items.Clear()

        DT = DataPr.CategoryList("Select cate_ID,cate_Name from Category WHERE cate_ID<>0")

        For i As Integer = 0 To DT.Rows.Count - 1
            Me.lstCategory.Items.Add(DT.Rows(i)(0).ToString)
            Me.lstCategory.Items(i).SubItems.Add(DT.Rows(i)(1).ToString)
        Next

        If Not Me.lstCategory.Items.Count = 0 Then
            Me.lstCategory.Items(0).Selected = True
        End If
    End Sub
#End Region

#Region "Events"

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReadCategories()
        Mode = "Update"
        Me.lstCategory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub lstCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCategory.SelectedIndexChanged
        For Each lvi As ListViewItem In Me.lstCategory.Items
            If lvi.Selected Then
                Me.txtCategoryOrginalName.Text = lvi.SubItems(1).Text
                cate_ID = lvi.Text
                cate_Name = lvi.SubItems(1).Text
            End If
        Next
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Mode = "Add"
        EnableDisable()
        ClearAreas()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Mode = "Update"
        EnableDisable()
        ClearAreas()
        If Me.lstCategory.Items.Count <> 0 Then
            Me.lstCategory.Items(0).Selected = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DataPr As DataProcess = New DataProcess
        Dim cmd As String = ""

        If Mode = "Update" Then
            cmd = "UPDATE Category SET cate_Name='" & Me.txtCategoryNewName.Text & "' WHERE cate_ID=" & cate_ID
            If DataPr.CategoryProcess(cmd) = 1 Then
                MessageBox.Show(Me.txtCategoryOrginalName.Text & " kategori adý " & Me.txtCategoryNewName.Text & " adýyla deðiþtirildi..", "Ýþlem Baþarýldý!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(Me.txtCategoryOrginalName.Text & " kategori adý " & Me.txtCategoryNewName.Text & " adýyla deðiþtirilemedi..", "Ýþlem Baþarýsýz!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        ElseIf Mode = "Add" Then
            cmd = "INSERT INTO Category(cate_Name) VALUES ('" & Me.txtCategoryNewName.Text & "')"
            If DataPr.CategoryProcess(cmd) = 1 Then
                MessageBox.Show(Me.txtCategoryNewName.Text & " adlý kategori eklenmiþtir..", "Ýþlem Baþarýldý!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(Me.txtCategoryNewName.Text & " adlý kategori eklenememiþtir..", "Ýþlem Baþarýsýz!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

            Mode = "Update"
            EnableDisable()
        End If

        ClearAreas()
        ReadCategories()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        DialogResult = MessageBox.Show(Me.txtCategoryOrginalName.Text & " adlý kategori silinsin mi?", "Kategori Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Dim DataPr As DataProcess = New DataProcess
            Dim cmd As String = ""
            cmd = "DELETE FROM Category WHERE cate_ID=" & cate_ID
            If DataPr.CategoryProcess(cmd) = 1 Then
                MessageBox.Show(Me.txtCategoryOrginalName.Text & " adlý kategori silinmiþtir..", "Ýþlem Baþarýlý!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(Me.txtCategoryOrginalName.Text & " adlý kategori silinememiþtir..", "Ýþlem Baþarýsýz!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        ClearAreas()
        ReadCategories()
    End Sub
#End Region


End Class
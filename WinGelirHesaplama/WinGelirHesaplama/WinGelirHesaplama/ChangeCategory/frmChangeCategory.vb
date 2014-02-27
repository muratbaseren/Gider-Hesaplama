Public Class frmChangeCategory

#Region "Local Variables"
    Private IsChecked As Boolean = False
#End Region

#Region "Methods"
    Private Sub CategoryRefresh()
        Dim DataPr As DataProcess = New DataProcess
        Dim DT As DataTable = New DataTable
        Dim DT2 As DataTable = New DataTable
        DT = DataPr.CategoryList("Select cate_ID,cate_Name from Category where cate_ID<>0")
        DT2 = DataPr.CategoryList("Select cate_ID,cate_Name from Category where cate_ID<>0")
        Me.cmbNewCategory.DataSource = DT2
        Me.cmbOldCategory.DataSource = DT
        Me.cmbNewCategory.DisplayMember = DT2.Columns(1).Caption
        Me.cmbNewCategory.ValueMember = DT2.Columns(0).Caption
        Me.cmbOldCategory.DisplayMember = DT.Columns(1).Caption
        Me.cmbOldCategory.ValueMember = DT.Columns(0).Caption
    End Sub

    Private Sub CategoryDetail(ByVal cmb As ComboBox, ByVal lsw As ListView)
        Dim DataPr As DataProcess = New DataProcess
        Dim DT As DataTable = New DataTable

        DT = DataPr.CategoryList("exec dbo.sp_AllProductsNodate " & cmb.SelectedValue)

        lsw.Items.Clear()

        For i As Integer = 0 To DT.Rows.Count - 1
            lsw.Items.Add(DT.Rows(i)(0).ToString)
            lsw.Items(i).SubItems.Add(DT.Rows(i)(2).ToString)
            lsw.Items(i).SubItems.Add(DT.Rows(i)(3).ToString)
            lsw.Items(i).SubItems.Add(DT.Rows(i)(4).ToString)
            lsw.Items(i).SubItems.Add(DT.Rows(i)(5).ToString)
            lsw.Items(i).SubItems.Add(DT.Rows(i)(6).ToString)
            lsw.Items(i).SubItems.Add(DT.Rows(i)(7).ToString)
        Next
    End Sub

    Private Sub ChangeCategory(ByVal cmbTarget As ComboBox, ByVal SourceListView As ListView)
        If Not cmbTarget.SelectedIndex = -1 Then
            Dim DataPr As DataProcess = New DataProcess

            For i As Integer = 0 To SourceListView.Items.Count - 1
                If SourceListView.Items(i).Checked = True Then
                    Dim cmd As String = ""
                    cmd = "UPDATE Product SET prod_Category=" & cmbTarget.SelectedValue & " WHERE prod_ID=" & SourceListView.Items(i).Text
                    DataPr.CategoryProcess(cmd)
                End If
            Next

            CategoryDetail(Me.cmbOldCategory, Me.lswOldProduct)
            CategoryDetail(Me.cmbNewCategory, Me.lswNewProduct)
        Else
            MessageBox.Show("Hedef olarak gösterilen kategori alanýndan kategori seçili deðil!Lütfen bir kategori seçiniz..", "Kategori Seçiniz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub AllItemChecked(ByVal btn As Button, ByVal lsw As ListView)
        If IsChecked = False Then
            btn.Text = "Hiçbirini Seçme"
        Else
            btn.Text = "Tümünü Seç"
        End If

        For Each itm As ListViewItem In lsw.Items
            If IsChecked = False Then
                itm.Checked = True
            Else
                itm.Checked = False
            End If
        Next
    End Sub
#End Region

#Region "Events"
    Private Sub frmChangeCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CategoryRefresh()
        Me.cmbOldCategory.SelectedIndex = 0
        Me.cmbNewCategory.SelectedIndex = 0
        Me.lswOldProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.lswNewProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub cmbOldCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOldCategory.SelectedIndexChanged
        If Not Me.cmbOldCategory.SelectedIndex = -1 Then
            CategoryDetail(sender, Me.lswOldProduct)
        End If
    End Sub

    Private Sub cmbNewCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNewCategory.SelectedIndexChanged
        If Not Me.cmbNewCategory.SelectedIndex = -1 Then
            CategoryDetail(sender, Me.lswNewProduct)

        End If
    End Sub

    Private Sub btnSendRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendRight.Click
        ChangeCategory(Me.cmbNewCategory, Me.lswOldProduct)
    End Sub

    Private Sub btnSendLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendLeft.Click
        ChangeCategory(Me.cmbOldCategory, Me.lswNewProduct)
    End Sub

    Private Sub btnOldSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOldSelectAll.Click
        AllItemChecked(sender, Me.lswOldProduct)
        If IsChecked = True Then
            IsChecked = False
        Else
            IsChecked = True
        End If
    End Sub

    Private Sub btnNewSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSelectAll.Click
        AllItemChecked(sender, Me.lswNewProduct)
        If IsChecked = True Then
            IsChecked = False
        Else
            IsChecked = True
        End If
    End Sub
#End Region

End Class
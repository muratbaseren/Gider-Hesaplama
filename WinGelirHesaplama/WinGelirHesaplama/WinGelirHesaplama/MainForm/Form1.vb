Public Class frmMain

#Region "Metotlar"
    Private Sub CategoryRefresh()
        'Kategori combobox ýný refresh ediyoruz..Yeniden dolduruyoruz..
        Dim DataPr As DataProcess = New DataProcess
        Dim DT As DataTable = New DataTable
        DT = DataPr.CategoryList("Select cate_ID,cate_Name from Category")
        Me.cmbCategory.DataSource = DT
        Me.cmbCategory.DisplayMember = DT.Columns(1).Caption
        Me.cmbCategory.ValueMember = DT.Columns(0).Caption
    End Sub

    Private Sub ChangeCategory()
        If Not Me.cmbCategory.SelectedIndex = -1 Then
            Dim DataPr As DataProcess = New DataProcess()
            'Seçili bir tarih olmasý durumuna göre database e gönderilecek sorgunun belirlenmesi..
            If Me.dtpSelectDate.Checked = False Then
                Me.dgwResult.DataSource = DataPr.CategoryList("exec dbo.sp_AllProductsNodate " & Me.cmbCategory.SelectedValue)
            Else
                Me.dgwResult.DataSource = DataPr.CategoryList("exec dbo.sp_AllProductsWithDate '" & Me.dtpSelectDate.Value.ToShortDateString & "'," & Me.cmbCategory.SelectedValue)
            End If
        End If
    End Sub
#End Region

#Region "Olaylar"

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CategoryRefresh()
        ChangeCategory()
        Me.dgwResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub cmbCategory_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategory.MouseHover
        Dim Index As Integer = Me.cmbCategory.SelectedIndex
        Me.cmbCategory.DataSource = Nothing
        CategoryRefresh()
        Me.cmbCategory.SelectedIndex = Index
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        ChangeCategory()
    End Sub

    Private Sub dtpSelectDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSelectDate.ValueChanged
        ChangeCategory()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        DialogResult = MessageBox.Show("Çýkmak istediðinize emin misiniz?", "Çýkýþ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub mnuCategoryEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCategoryEdit.Click
        Dim frm As frmCategory = New frmCategory
        frm.Show()
    End Sub

    Private Sub mnuChangeProductCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangeProductCategory.Click
        Dim frm As frmChangeCategory = New frmChangeCategory
        frm.Show()
    End Sub

    Private Sub mnuProductEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProductEdit.Click
        Dim frm As frmProduct = New frmProduct
        frm.Show()
    End Sub

    Private Sub dgwResult_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgwResult.DataSourceChanged
        mnuFullTotal_Click(sender, e)
        Me.tssProductCount.Text = Me.dgwResult.RowCount - 1 & " Adet Kayýt Vardýr.."
    End Sub

    Private Sub mnuFullTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFullTotal.Click
        Me.grpTotal.Text = Me.mnuFullTotal.Text

        If Not Me.dgwResult.RowCount = 0 Then
            Dim Total As Single = 0
            For i As Integer = 0 To Me.dgwResult.RowCount - 1
                Total += Me.dgwResult.Item(3, i).Value
            Next
            Me.txtTotal.Text = Total
        End If
    End Sub

    Private Sub mnuSelectedRowsTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectedRowsTotal.Click
        Me.grpTotal.Text = Me.mnuSelectedRowsTotal.Text

        If Not Me.dgwResult.SelectedRows.Count = 0 Then
            Dim Total As Single = 0
            For i As Integer = 0 To Me.dgwResult.SelectedRows.Count - 1
                Total += Me.dgwResult.Item(3, Me.dgwResult.SelectedRows(i).Index).Value
            Next
            Me.txtTotal.Text = Total
        Else
            MessageBox.Show("Seçili satýr yok!", "Seçili Satýr Tutar Toplama", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub mnuSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSearch.Click
        Dim SearchText As String = ""
        SearchText = InputBox("Aranacak Kelimeyi Giriniz!", "Arama")

        If Not Trim(SearchText).Length = 0 Then
            Dim SearchArr As ArrayList = New ArrayList
            For i As Integer = 0 To Me.dgwResult.RowCount - 2
                For k As Integer = 0 To Me.dgwResult.ColumnCount - 1
                    Me.dgwResult.Item(k, i).Selected = False
                    If Not Me.dgwResult.Item(k, i).Value Is DBNull.Value Then
                        If Me.dgwResult.Item(k, i).Value.ToString = SearchText Then
                            Me.dgwResult.Item(k, i).Selected = True
                        End If
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub mnuPrintWebPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintWebPage.Click
        Me.SaveFileDialog1.Filter = "HTML Web Sayfasý(*.html)|*.html"
        Me.SaveFileDialog1.Title = "HTML Dosya Kaydet"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileCopy(Application.StartupPath & "\aaa.html", Me.SaveFileDialog1.FileName)

            Dim DT As DataTable = New DataTable
            DT = Me.dgwResult.DataSource
            Dim printTable As WriteHTML = New WriteHTML
            printTable.WriteHTMLFile(DT, Me.SaveFileDialog1.FileName.ToString)

            DialogResult = MessageBox.Show("Kaydedilen dosyayý açmak istermisiniz?", "Kayýtlý Dosyayý Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Shell("explorer.exe " & Me.SaveFileDialog1.FileName, AppWinStyle.MaximizedFocus)
            End If
        End If
    End Sub

    Private Sub mnuPrintTextFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintTextFile.Click
        Me.SaveFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt"
        Me.SaveFileDialog1.Title = "Metin Dosyasý Kaydet"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim DT As DataTable = New DataTable
            DT = Me.dgwResult.DataSource
            Dim printTable As WriteHTML = New WriteHTML
            printTable.WriteTEXTFile(DT, Me.SaveFileDialog1.FileName.ToString)

            DialogResult = MessageBox.Show("Kaydedilen dosyayý açmak istermisiniz?", "Kayýtlý Dosyayý Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If DialogResult = Windows.Forms.DialogResult.Yes Then
                Shell("notepad.exe " & Me.SaveFileDialog1.FileName, AppWinStyle.MaximizedFocus)
            End If
        End If
    End Sub
#End Region

End Class

Public Class frmProduct

#Region "Local Variables"
    Private Mode As String
    Private Prod_ID As Integer
#End Region

#Region "Methods"
    Private Sub ClearAreas()
        'iptal,delete,insert iþlemelrinden sonra ekrandaki nesnelerin silinmesi..
        Me.txtProductName.Text = ""
        Me.txtProductComment.Text = ""
        Me.txtProductPrice.Text = ""
        Me.dtpProductBuyDate.Value = Now.ToShortDateString
        Me.dtpProductPaymentDate.Value = Now.ToShortDateString
        Me.dtpProductPaymentDate.Checked = False
        Me.nudProductQuantity.Value = 0
    End Sub

    Private Sub EnableDisable()
        'Mode a göre butonlarýn enable ve disable olmalarý..
        If Mode = "Update" Then
            Me.btnDelete.Enabled = True
            Me.btnNew.Enabled = True
        Else
            Me.btnDelete.Enabled = False
            Me.btnNew.Enabled = False
        End If
    End Sub

    Private Sub CategoryRefresh()
        'Kategori combobox ýný refresh ediyoruz..Yeniden dolduruyoruz..
        Dim DataPr As DataProcess = New DataProcess
        Dim DT As DataTable = New DataTable
        DT = DataPr.CategoryList("Select cate_ID,cate_Name from Category")
        Me.cmbCategory.DataSource = DT
        'Datasource a verilen DataTable ýn combobox da gösterilecek kolonu (cate_Name)..
        Me.cmbCategory.DisplayMember = DT.Columns(1).Caption
        'Datasource a verilen DataTable ýn combobox da arka planda seçilen item ýn ID sini saklayacamýz kolonu (cate_ID)..
        Me.cmbCategory.ValueMember = DT.Columns(0).Caption

        Me.cmbCategory.SelectedIndex = -1
    End Sub

    Private Sub ChangeCategory()
        'Kategori degiþtirildiðinde database den sorgulanarak seçili kategori bilgieri datagrid e datatable olarak aktarýlýyor..
        If Not Me.cmbCategory.SelectedIndex = -1 AndAlso IsNumeric(Me.cmbCategory.SelectedValue) = True Then
            Dim DataPr As DataProcess = New DataProcess()
            Me.dgwResult.DataSource = DataPr.CategoryList("exec dbo.sp_AllProductsNodate " & Me.cmbCategory.SelectedValue)
        End If
    End Sub

    Private Function InsertUpdateControl() As String
        'Ýnsert,update ve delete iþlemleri için ürün adýný ve tutarýnýn boþ geçilmemesinin kontrol edilmesi..
        Dim result As String = ""
        If Trim(Me.txtProductName.Text) = "" Then
            result = "Ürün Adý boþ býrakýlamaz.."
        ElseIf IsNumeric(Me.txtProductPrice.Text) = False Then
            result = "Ürün Tutarýný sayý olarak girniz.."
        End If

        Return result
    End Function

    Private Sub SendCellDetails()
        'Eger datagrid de kayýt varsa ve CurrentRow nothing dönmüyorsa..
        If Not Me.dgwResult.Rows.Count = 0 AndAlso Not Me.dgwResult.CurrentRow Is Nothing Then
            Dim Cell_Values As DataGridViewRow = New DataGridViewRow
            Cell_Values = Me.dgwResult.CurrentRow

            'Seçili satýr bilgilerini textbox,datetimepicker,numericupdown a aktarýyor..
            Prod_ID = Cell_Values.Cells(0).Value
            Me.txtProductName.Text = Cell_Values.Cells(2).Value
            Me.txtProductPrice.Text = Cell_Values.Cells(3).Value
            Me.dtpProductBuyDate.Value = CType(Cell_Values.Cells(4).Value, Date).ToShortDateString
            'Adet,Ödeme Günü ve Açýklama satýrlarý database de Nullable olarak ayarlandýðýndan bunlarýn DBNull dönmesi hataya yol acacaðýndan kontrol ediliyor..
            If Not Cell_Values.Cells(5).Value Is DBNull.Value Then
                Me.nudProductQuantity.Value = CInt(Cell_Values.Cells(5).Value)
            End If
            If Not Cell_Values.Cells(6).Value Is DBNull.Value Then
                Me.dtpProductPaymentDate.Value = CType(Cell_Values.Cells(6).Value, Date).ToShortDateString
            End If
            If Not Cell_Values.Cells(7).Value Is DBNull.Value Then
                Me.txtProductComment.Text = Cell_Values.Cells(7).Value
            End If
        End If
    End Sub
#End Region

#Region "Events"

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CategoryRefresh()
        Mode = "Update"
        Me.dgwResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        ChangeCategory()
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
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ErrorControl As String = InsertUpdateControl()

        If Not ErrorControl = "" Then
            MessageBox.Show(ErrorControl, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If Me.cmbCategory.SelectedIndex <> 0 AndAlso Me.cmbCategory.SelectedIndex <> -1 Then
            Dim DataPr As DataProcess = New DataProcess
            Dim cmd As String = ""
            '
            'Nullable alanlar için..
            '===========================================
            Dim PaymentDate As String = ""
            If Me.dtpProductPaymentDate.Checked = True Then
                PaymentDate = "'" & Me.dtpProductPaymentDate.Value.ToShortDateString & "'"
            Else
                PaymentDate = "null"
            End If

            Dim Quantity As String = ""
            If Me.nudProductQuantity.Value = 0 Then
                Quantity = "null"
            Else
                Quantity = Me.nudProductQuantity.Value
            End If
            '===========================================

            If Mode = "Update" Then
                cmd = "UPDATE Product SET prod_Category=" & Me.cmbCategory.SelectedValue & ", prod_Name='" & Me.txtProductName.Text & "', prod_Price=" & Me.txtProductPrice.Text & ", prod_BuyDate='" & Me.dtpProductBuyDate.Value.ToShortDateString & "', prod_Quantity=" & Quantity & ", prod_PaymentDate=" & PaymentDate & ", prod_Desc='" & Me.txtProductComment.Text & "' WHERE prod_ID=" & Prod_ID
                If DataPr.CategoryProcess(cmd) = 1 Then
                    MessageBox.Show(Me.txtProductName.Text & " adlý kayýt deðiþtirildi..", "Ýþlem Baþarýldý!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(Me.txtProductName.Text & " adlý kayýt deðiþtirilemedi..", "Ýþlem Baþarýsýz!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            ElseIf Mode = "Add" Then
                cmd = "INSERT INTO Product(prod_Category, prod_Name, prod_Price, prod_BuyDate, prod_Quantity, prod_PaymentDate, prod_Desc) VALUES (" & Me.cmbCategory.SelectedValue & ",'" & Me.txtProductName.Text & "'," & Me.txtProductPrice.Text & ",'" & Me.dtpProductBuyDate.Value.ToShortDateString & "'," & Quantity & "," & PaymentDate & ",'" & Me.txtProductComment.Text & "')"
                If DataPr.CategoryProcess(cmd) = 1 Then
                    MessageBox.Show(Me.txtProductName.Text & " adlý kayýt eklenmiþtir..", "Ýþlem Baþarýldý!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show(Me.txtProductName.Text & " adlý kayýt eklenememiþtir..", "Ýþlem Baþarýsýz!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

                Mode = "Update"
                EnableDisable()
            End If

            MsgBox(cmd)
            ClearAreas()
            Me.dgwResult.DataSource = Nothing
            ChangeCategory()
            'Me.cmbCategory.Items(Me.cmbCategory.SelectedIndex).selected()
        Else
            MessageBox.Show("Bu kategori altýnda kayýt ekleyemezsiniz?Lütfen varolan kategorilerden birini seçiniz..", "Kategori Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim ErrorControl As String = InsertUpdateControl()

        If Not ErrorControl = "" Then
            MessageBox.Show(ErrorControl, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        DialogResult = MessageBox.Show(Me.txtProductName.Text & " adlý kayýt silinsin mi?", "Kayýt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Dim DataPr As DataProcess = New DataProcess
            Dim cmd As String = ""
            cmd = "DELETE FROM Product WHERE prod_ID=" & Prod_ID
            If DataPr.CategoryProcess(cmd) = 1 Then
                MessageBox.Show(Me.txtProductName.Text & " adlý kayýt silinmiþtir..", "Ýþlem Baþarýlý!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(Me.txtProductName.Text & " adlý kayýt silinememiþtir..", "Ýþlem Baþarýsýz!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        ClearAreas()
        Me.dgwResult.DataSource = Nothing
        ChangeCategory()
    End Sub

    'Datagrid de Herhangi bir hücre içeriðine týklanýnca yapýlacaklar..
    Private Sub dgwResult_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwResult.CellContentClick
        SendCellDetails()
    End Sub

    'Datagrid de herhangi bir row a týklanýnca..
    'O an seçili hücre deðiþince..
    Private Sub dgwResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgwResult.CurrentCellChanged
        SendCellDetails()
    End Sub

    Private Sub mnuTotalInvisible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTotalInvisible.Click
        Me.mnuTotalInvisible.Checked = True
        Me.mnuTotalVisible.Checked = False

        Me.grpTotal.Visible = False
    End Sub

    Private Sub mnuTotalVisible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTotalVisible.Click
        Me.mnuTotalInvisible.Checked = False
        Me.mnuTotalVisible.Checked = True

        Me.grpTotal.Visible = True
    End Sub

    Private Sub mnuFullTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFullTotal.Click
        If Not Me.dgwResult.RowCount = 0 Then
            Dim Total As Single = 0
            For i As Integer = 0 To Me.dgwResult.RowCount - 1
                Total += Me.dgwResult.Item(3, i).Value
            Next
            Me.txtTotal.Text = Total
        End If
    End Sub

    Private Sub mnuSelectRowsTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectRowsTotal.Click
        If Not Me.dgwResult.SelectedRows.Count = 0 Then
            Dim Total As Single = 0
            For i As Integer = 0 To Me.dgwResult.SelectedRows.Count - 1
                Total += Me.dgwResult.Item(3, Me.dgwResult.SelectedRows(i).Index).Value
            Next
            Me.txtTotal.Text = Total
        End If
    End Sub

    Private Sub mnuSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSearch.Click
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

    Private Sub cmnuTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTotal.Click
        mnuTotalInvisible_Click(sender, e)
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
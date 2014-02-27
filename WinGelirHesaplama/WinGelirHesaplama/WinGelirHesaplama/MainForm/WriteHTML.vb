Public Class WriteHTML

    Public Sub WriteHTMLFile(ByVal SourceTable As DataTable, ByVal FilePath As String)
        '
        'First Statment(HTML File Information)
        '
        Dim TopStatment As String = "<!DOCTYPE html PUBLIC " & Chr(34) & "-//W3C//DTD XHTML 1.0 Transitional//TR" & Chr(34) & " " & Chr(34) & "http://www.w3.org//TR/xhtml1/DTD/xhtml1-transitional.dtd" & Chr(34) & ">" & vbCrLf & _
"<html xmlns=" & Chr(34) & "http://www.w3.org/1999/xhtml" & Chr(34) & ">" & vbCrLf & _
"<head>" & vbCrLf & _
"    <title>Gider Dökümasyonu</title>" & vbCrLf & _
"</head>" & vbCrLf & _
"<body>" & vbCrLf & _
"    <table style=" & Chr(34) & "width: 840px" & Chr(34) & ">" & vbCrLf & vbCrLf & _
"<!--Tablodaki kolon basliklari..-->"

        '
        'SecondStatment(Insert Columns Caption)
        '
        Dim MiddleStatment As String = "        <tr>" & vbCrLf
        For i As Integer = 0 To SourceTable.Columns.Count - 1
            MiddleStatment &= "            <td style=" & Chr(34) & "font-size: 12pt; color: black; font-style: italic; font-family: 'Times New Roman'; border-top-width: 3px; border-left-width: 3px; border-left-color: #000033; border-bottom-width: 3px; border-bottom-color: #000033; border-top-color: #000033; height: 21px; background-color: darkseagreen; border-right-width: 3px; border-right-color: #000033; font-weight: bold;" & Chr(34) & " align=" & Chr(34) & "center" & Chr(34) & " valign=" & Chr(34) & "middle" & Chr(34) & ">" & SourceTable.Columns.Item(i).Caption.ToString & vbCrLf & "            </td>" & vbCrLf
        Next
        MiddleStatment &= "        </tr>" & vbCrLf & vbCrLf & _
        "<!--Kolon basliklarinin altýndaki cizgi..-->"
        '
        'ThirdStatment(Drawing Line)
        '
        Dim ThirdStatment As String = "       <tr>" & vbCrLf & _
"            <td style=" & Chr(34) & "height: 10px" & Chr(34) & " colspan=" & Chr(34) & "8" & Chr(34) & ">" & vbCrLf & _
"                <hr />" & vbCrLf & _
"            </td>" & vbCrLf & _
"        </tr>" & vbCrLf
        '
        'FourthStatment(Insert Rows)
        '
        Dim FourthStatment As String = ""
        'Kolonlar okunuyor..
        For i As Integer = 0 To SourceTable.Rows.Count - 1
            Dim CellColor As String = "lightgrey"
            FourthStatment &= "        <tr>" & vbCrLf
            'Verilerin oldugu satýrlarýn farklý renklerde döþenmesini saðlýyoruz..
            If i Mod 2 = 1 Then
                CellColor = "darkgray"
            End If
            'Satýrlar okunur ve HTML file a eklenir..
            For j As Integer = 0 To SourceTable.Columns.Count - 1
                FourthStatment &= "<!--" & i & ".satýr " & j & ".kolon-->" & vbCrLf
                FourthStatment &= "            <td align=" & Chr(34) & "center" & Chr(34) & " style=" & Chr(34) & "font-size: 11pt; border-bottom-width: 1px; border-bottom-color: black;" & vbCrLf & _
                    "                color: black; font-style: italic; font-family: 'Times New Roman'; height: 19px;" & vbCrLf & _
                    "                background-color: " & CellColor & "; font-weight: normal;" & Chr(34) & "valign=" & Chr(34) & "middle" & Chr(34) & ">" & SourceTable.Rows(i)(j).ToString & vbCrLf & _
                    "            </td>" & vbCrLf
            Next
            FourthStatment &= "        </tr>" & vbCrLf
        Next
        '
        'FifthStatement(Closing Statement)
        '
        Dim FifthSatetment As String = "<!--Table Body HTML kapanýþ cumleleri..-->" & vbCrLf
        FifthSatetment &= "    </table>" & vbCrLf & vbCrLf & "</body>" & vbCrLf & "</html>" & vbCrLf

        'Belirtilen konuma HTML dosya olusturma..
        Dim FileStream As System.IO.FileStream
        FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Append, IO.FileAccess.Write)

        Dim FileWriter As System.IO.StreamWriter
        FileWriter = New System.IO.StreamWriter(FileStream)

        FileWriter.Write(TopStatment & MiddleStatment & ThirdStatment & FourthStatment & FifthSatetment)

        FileWriter.Close()
        FileStream.Close()
    End Sub

    Public Sub WriteTEXTFile(ByVal SourceTable As DataTable, ByVal FilePath As String)
        Dim Statement As String = ""

        For i As Integer = 0 To SourceTable.Rows.Count - 1
            For j As Integer = 0 To SourceTable.Columns.Count - 1
                Statement &= SourceTable.Columns.Item(j).Caption.ToString & " : "
                Statement &= SourceTable.Rows(i)(j).ToString & vbCrLf
            Next
            Statement &= vbCrLf
        Next

        'Belirtilen konuma Text dosya olusturma..
        Dim FileStream As System.IO.FileStream
        FileStream = New System.IO.FileStream(FilePath, IO.FileMode.Create, IO.FileAccess.Write)

        Dim FileWriter As System.IO.StreamWriter
        FileWriter = New System.IO.StreamWriter(FileStream)

        FileWriter.Write(Statement)

        FileWriter.Close()
        FileStream.Close()
    End Sub

    Public Sub New()

    End Sub
End Class

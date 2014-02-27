Imports System.Data
Imports System.Data.SqlClient

Public Class DataProcess

#Region "Local variables"
    Private _Conn As SqlConnection
    Private _Cmd As SqlCommand
#End Region

#Region "Properties"
    Public Property Conn() As SqlConnection
        Get
            Return _Conn
        End Get
        Set(ByVal value As SqlConnection)
            _Conn = value
        End Set
    End Property

    Public Property Cmd() As SqlCommand
        Get
            Return _Cmd
        End Get
        Set(ByVal value As SqlCommand)
            _Cmd = value
        End Set
    End Property
#End Region

#Region "Events"
    'Select sorgularý için datatable döndüren genel function..
    Public Function CategoryList(ByVal Command As String) As DataTable
        Dim DT As DataTable = New DataTable
        Dim DataAdap As SqlDataAdapter = New SqlDataAdapter(Command, Conn)
        DataAdap.Fill(DT)
        Return DT
    End Function

    'insert,update,delete iþlemleri için genel function..
    Public Function CategoryProcess(ByVal Command As String) As Integer
        _Cmd.CommandText = Command
        If Not Conn.State = ConnectionState.Open Then
            Conn.Open()
        End If
        Return Cmd.ExecuteNonQuery()
        If Not Conn.State = ConnectionState.Closed Then
            Conn.Close()
        End If
    End Function

    Public Sub New()
        'connection ve command olusturma sub'ý..
        Dim Sql_Conn As SqlConnection = New SqlConnection("server=.;Database=DbExpence;Integrated Security=SSPI;")
        _Conn = Sql_Conn
        Dim Sql_Cmd As SqlCommand = New SqlCommand()
        _Cmd = Sql_Cmd
        _Cmd.Connection = Conn
    End Sub
#End Region

End Class

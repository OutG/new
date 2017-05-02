Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("server=MRX-PC\SQLEXPRESS; database=vb; integrated security=true")
    Public Dad As SqlDataAdapter
    Public Drd As SqlDataReader
    Public Cmd As SqlCommand
    Public users As New DataSet
    Public dt As New DataTable
End Module

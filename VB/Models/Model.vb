Imports System.Data
Imports System.Data.OleDb
Imports System.Web.Configuration

Namespace CS.Model
	Public Class MyModel
		Public Shared Function GetCategories() As DataTable
			Dim dataTableCategories As New DataTable()

			Using connection As OleDbConnection = GetConnection()
				Dim adapter As New OleDbDataAdapter(String.Empty, connection)
				adapter.SelectCommand.CommandText = "SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"
				adapter.Fill(dataTableCategories)
			End Using

			Return dataTableCategories
		End Function

		Private Shared Function GetConnection() As OleDbConnection
			Dim connection As New OleDbConnection()
			connection.ConnectionString = WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString

			Return connection
		End Function
	End Class

	Public Class MyViewModel
		Public Property Categories() As DataTable
		Public Property Products() As DataTable
	End Class
End Namespace
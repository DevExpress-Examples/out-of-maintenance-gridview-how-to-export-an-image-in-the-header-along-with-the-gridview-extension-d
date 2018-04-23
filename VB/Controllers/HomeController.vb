Imports System.Drawing
Imports System.IO
Imports System.Web.Mvc
Imports CS.Model
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks

Namespace CS.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View(New MyViewModel With {.Categories = MyModel.GetCategories()})
		End Function
		Public Function GridViewPartialCategories() As ActionResult
			Return PartialView(MyModel.GetCategories())
		End Function

		Public Function ExportTo() As ActionResult
			Dim ps As New PrintingSystem()

			Dim headerImageLink As New Link(ps)

			AddHandler headerImageLink.CreateDetailArea, AddressOf headerImageLink_CreateDetailArea

			Dim link1 As New PrintableComponentLink(ps)
			Dim categoriesGridSettings As New GridViewSettings()
			categoriesGridSettings.Name = "gvCategories"
			categoriesGridSettings.KeyFieldName = "CategoryID"
			categoriesGridSettings.Columns.Add("CategoryID")
			categoriesGridSettings.Columns.Add("CategoryName")
			categoriesGridSettings.Columns.Add("Description")
			link1.Component = GridViewExtension.CreatePrintableObject(categoriesGridSettings, MyModel.GetCategories())

			Dim compositeLink As New CompositeLink(ps)
			compositeLink.Links.AddRange(New Object() { headerImageLink, link1 })
			compositeLink.CreateDocument()

			Dim result As FileStreamResult = CreateExcelExportResult(compositeLink)
			ps.Dispose()

			Return result
		End Function

		Protected Sub headerImageLink_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			e.Graph.DrawImage(SystemIcons.Application.ToBitmap(), New RectangleF(0, 0, 100, 50))
		End Sub

		Protected Function CreateExcelExportResult(ByVal link As CompositeLink) As FileStreamResult
			Dim stream As New MemoryStream()
			link.PrintingSystem.ExportToXls(stream)
			stream.Position = 0
			Dim result As New FileStreamResult(stream, "application/xls")
			result.FileDownloadName = "MyData.xls"
			Return result
		End Function
	End Class
End Namespace
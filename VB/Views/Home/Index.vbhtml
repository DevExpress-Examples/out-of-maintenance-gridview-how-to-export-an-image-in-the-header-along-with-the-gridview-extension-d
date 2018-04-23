@Using (Html.BeginForm(New With {.Controller = "Home", .Action = "ExportTo"}))
    @Html.Partial("GridViewPartialCategories", Model.Categories)
    @<br />
    @Html.DevExpress().Button( _
        Sub(settings)
            settings.Name = "btnExport"
            settings.Text = "Export"
            settings.UseSubmitBehavior = True
        End Sub).GetHtml()
End Using
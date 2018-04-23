@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gvCategories"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialCategories"}

            settings.KeyFieldName = "CategoryID"

            settings.Columns.Add("CategoryID")
            settings.Columns.Add("CategoryName")
            settings.Columns.Add("Description")

            settings.SettingsBehavior.AllowFocusedRow = True
    
            settings.ClientSideEvents.FocusedRowChanged = "OnFocusedRowChanged"
    
    End Sub).Bind(Model).GetHtml()
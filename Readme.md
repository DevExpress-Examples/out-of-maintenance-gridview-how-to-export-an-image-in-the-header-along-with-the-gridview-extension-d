<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550050/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328898)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [Model.cs](./CS/Models/Model.cs) (VB: [Model.vb](./VB/Models/Model.vb))
* [GridViewPartialCategories.cshtml](./CS/Views/Home/GridViewPartialCategories.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to export an image in the header along with the GridView extension data
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t328898/)**
<!-- run online end -->


This example illustrates how to add extra content (an image in this scenario) to the exported document. We use link objects from the XtraPrinting Core Library (see <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument104">Printing Links</a>) for this purpose:<br><br>- <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraPrintingLinks.PrintableComponentLinkBase.class">PrintableComponentLinkBase</a> for the GridView extension<br>- <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.LinkBase.class">LinkBase</a> for a custom content in header<br>- <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraPrintingLinks.CompositeLinkBase.class">CompositeLinkBase</a> to combine the previous links<br><br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/E3891">E3891 - How to export multiple GridViews into a single print document</a>

<br/>



#pragma checksum "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\Home\Menu2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b83fff45218b0ac0005865dd7d371453c6ad3df6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menu2), @"mvc.1.0.view", @"/Views/Home/Menu2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\_ViewImports.cshtml"
using TheCapitalBurguer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\_ViewImports.cshtml"
using TheCapitalBurguer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83fff45218b0ac0005865dd7d371453c6ad3df6", @"/Views/Home/Menu2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d64bcb023da7996ea53e889670cbcfb975791bbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menu2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TheCapitalBurguer.Models.Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\Home\Menu2.cshtml"
   
    ViewBag.Title = "Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Hamburguesa</th>\r\n            <th>Precio</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 15 "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\Home\Menu2.cshtml"
         foreach (var Menu in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\Home\Menu2.cshtml"
               Write(Menu.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\Home\Menu2.cshtml"
               Write(Menu.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\Z Repsaldo\Aplicacion\TheCapitalBurguer\TheCapitalBurguer\Views\Home\Menu2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TheCapitalBurguer.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
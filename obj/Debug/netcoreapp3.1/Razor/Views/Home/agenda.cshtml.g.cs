#pragma checksum "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\Home\agenda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2a5efea5137580b37a60da4fc9f0fb608bdc97e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_agenda), @"mvc.1.0.view", @"/Views/Home/agenda.cshtml")]
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
#line 1 "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a5efea5137580b37a60da4fc9f0fb608bdc97e", @"/Views/Home/agenda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_agenda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<agendasDeEventos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\Home\agenda.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 7 "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\Home\agenda.cshtml"
   foreach (agendasDeEventos item in Model)

  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>data do evento : ");
#nullable restore
#line 11 "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\Home\agenda.cshtml"
                        Write(item.dataEvento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n        <li> nome do evento : ");
#nullable restore
#line 12 "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\Home\agenda.cshtml"
                         Write(item.evento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 14 "I:\senac EAD\tec informatica para internet\MODULO B\UC06PublicarEtestarAplicacoesWeb\ATV1uc06\projetohotsite\Views\Home\agenda.cshtml"
     
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                <div> <h1>Agenda</h1></div>\r\n        <h2>Esta é uma janela modal</h2>\r\n       \r\n    \r\n\r\n\r\n    \r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<agendasDeEventos>> Html { get; private set; }
    }
}
#pragma warning restore 1591

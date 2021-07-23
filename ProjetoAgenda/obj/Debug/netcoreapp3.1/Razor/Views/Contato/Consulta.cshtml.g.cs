#pragma checksum "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e3a5660b0fc1c63381b47a00b7eccb9e03b81c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Consulta), @"mvc.1.0.view", @"/Views/Contato/Consulta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e3a5660b0fc1c63381b47a00b7eccb9e03b81c", @"/Views/Contato/Consulta.cshtml")]
    public class Views_Contato_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoAgenda.Models.ContatoConsultaModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Consulta de contatos</h3>\r\n<p>\r\n    Listagem de contatos cadastrados no sistema.\r\n</p>\r\n<hr />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-secondary mb-2\">\r\n        <strong>");
#nullable restore
#line 16 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
           Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table id=\"tabela_dados\" class=\"table table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id do contato: </th>\r\n            <th>Nome do Contato: </th>\r\n            <th>Operações: </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
         foreach (var item in Model.Contatos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
               Write(item.IdContato);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 870, 2);
            WriteAttributeValue("", 836, "/Contato/Edicao?id=", 836, 19, true);
#nullable restore
#line 36 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
WriteAttributeValue("", 855, item.IdContato, 855, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                       class=\"btn btn-primary btn-sm\">Alterar</a>\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 964, "\"", 1007, 2);
            WriteAttributeValue("", 971, "/Contato/Exclusao?id=", 971, 21, true);
#nullable restore
#line 39 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
WriteAttributeValue("", 992, item.IdContato, 992, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 1008, "\"", 1097, 7);
            WriteAttributeValue("", 1042, "return", 1042, 6, true);
            WriteAttributeValue(" ", 1048, "confirm(\'Deseja", 1049, 16, true);
            WriteAttributeValue(" ", 1064, "excluir", 1065, 8, true);
            WriteAttributeValue(" ", 1072, "o", 1073, 2, true);
            WriteAttributeValue(" ", 1074, "contato", 1075, 8, true);
#nullable restore
#line 40 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
WriteAttributeValue(" ", 1082, item.Nome, 1083, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1093, "?\');", 1093, 4, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                       class=\"btn btn-danger btn-sm\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"5\">\r\n                Quantidade de contatos: ");
#nullable restore
#line 49 "C:\Users\Mário Duarte\source\repos\ProjetoAgenda - Cópia\ProjetoAgenda\Views\Contato\Consulta.cshtml"
                                   Write(Model.Contatos.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoAgenda.Models.ContatoConsultaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

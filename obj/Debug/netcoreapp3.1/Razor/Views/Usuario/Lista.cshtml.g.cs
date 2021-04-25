#pragma checksum "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002267212506a6a587475f14eaaa5b2b81f8ac50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\_ViewImports.cshtml"
using UC04_Atividade_2_Felipe_Fadil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\_ViewImports.cshtml"
using UC04_Atividade_2_Felipe_Fadil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002267212506a6a587475f14eaaa5b2b81f8ac50", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5ae8c71879bd8d1e56010287b9f3eda63f87f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Listagem de Usuários</h2>

<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Login</th>
            <th>Senha</th>
            <th>Data de Nascimento</th>
            <th>Operações</th>
        </tr>
    </thead>
");
#nullable restore
#line 19 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
               Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
               Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
               Write(u.DataNascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 696, "\"", 728, 2);
            WriteAttributeValue("", 703, "/Usuario/Remover?Id=", 703, 20, true);
#nullable restore
#line 28 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 723, u.Id, 723, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja excluir?\');\">Remover</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 810, "\"", 841, 2);
            WriteAttributeValue("", 817, "/Usuario/Editar?Id=", 817, 19, true);
#nullable restore
#line 29 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 836, u.Id, 836, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<p>\r\n    ");
#nullable restore
#line 35 "C:\Docs Note\Senac-EAD\Modulo 1\UC04 - Estruturar e implementar bando de dados\UC04-Atividade_2-Felipe_Fadil\Views\Usuario\Lista.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591

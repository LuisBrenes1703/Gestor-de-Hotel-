#pragma checksum "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52e4cf99ea339ecc29a27077e10c1c5556cebea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarea_CrearTareaView), @"mvc.1.0.view", @"/Views/Tarea/CrearTareaView.cshtml")]
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
#line 1 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\_ViewImports.cshtml"
using GestorReunionesProyectoAnalisis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\_ViewImports.cshtml"
using GestorReunionesProyectoAnalisis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52e4cf99ea339ecc29a27077e10c1c5556cebea", @"/Views/Tarea/CrearTareaView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f99e93f27658e4dea006173d63d024f2283a419b", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarea_CrearTareaView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/script.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/moduloAdministrador.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
  
    ViewData["Title"] = "CrearTarea";

    if (ViewBag.PermisoUsuario == "1")
    {
        Layout = "_Layout";
    }
    else if (ViewBag.PermisoUsuario == "2")
    {
        Layout = "LayoutUsuarioEstandar";
    }
    else if (ViewBag.PermisoUsuario == "3")
    {
        Layout = "LayoutUsuarioCatalogos";
    }

    if (ViewBag.PermisoUsuario == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            redireccion(\'/Usuario/MuestraLoginUsuario\');\r\n        </script>\r\n");
#nullable restore
#line 22 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b52e4cf99ea339ecc29a27077e10c1c5556cebea6792", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b52e4cf99ea339ecc29a27077e10c1c5556cebea7989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b52e4cf99ea339ecc29a27077e10c1c5556cebea9186", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b52e4cf99ea339ecc29a27077e10c1c5556cebea10383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b52e4cf99ea339ecc29a27077e10c1c5556cebea11581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<section id=""contenidoT"" style=""margin-top:120px;"">
    <section id=""principalT"">

        <center>
            <div class="" d-md-flex flex-md-equal w-100 my-md-3 pl-md-3"">
                <div class=""bg-light mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                    <div class=""signup-form container-fluid"" style=""width:45%"">

                        <h2>Crear Tarea</h2>
                        <p class=""hint-text"">Solo las jefaturas y el secretariado tiene el rango para crear Tareas.</p>
                        <center>
                            <div");
            BeginWriteAttribute("class", " class=\"", 1483, "\"", 1491, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:80%"">
                                <div class=""form-group"">
                                    <label for=""NombreT"" class=""sr-only"">Nombre de Tarea</label>
                                    <input type=""text"" id=""NombreT"" class=""form-control"" placeholder=""Nombre de Tarea""");
            BeginWriteAttribute("autofocus", " autofocus=\"", 1787, "\"", 1799, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""form-group"">
                                    <label for=""descripcionT"">Descripción</label>
                                    <textarea class=""form-control"" id=""descripcionT"" rows=""3""></textarea>
                                </div>
                                <div class=""form-group""><button id=""btnUsuariosListaT"" type=""button"" class=""btn btn-secondary  btn-block"" data-toggle=""modal"" data-target=""#usuariosListaT"">Añadir contacto</button></div>
                                <div class=""form-group""><button class=""btn btn-outline-secondary btn-block"" type=""button"" href=""javascript:;"" onclick=""finalizarCrearTarea($('#NombreT').val(), $('#descripcionT').val()); return false;"">Finalizar</button></div>

                                <span id=""tareaDatos""></span>

                            </div>
                        </center>

                    </div>
                </div>
            </div>
");
            WriteLiteral(@"


        </center>

    </section>
</section>

<!-- Modal lista de usuario -->
<div class=""modal fade"" id=""usuariosListaT"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color: #343a40 !important;"">
                <h3 style=""color:#ffffff"">Lista de Usuarios</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

                <table id=""tablaUsuariosCrearReunion"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>Incluir</th>
                            <th>Nombre</th>
                            <th>Oficina<");
            WriteLiteral("/th>\r\n                            <th>Puesto</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n\r\n");
#nullable restore
#line 98 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
                         if (ViewBag.ListaUsuarios != null)
                        {
                            foreach (UsuarioModel temp in ViewBag.ListaUsuarios)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr>
                                    <td>
                                        <div class=""custom-control custom-switch"">
                                            <input name=""checks"" type=""checkbox"" class=""custom-control-input""");
            BeginWriteAttribute("id", " id=\"", 4469, "\"", 4489, 1);
#nullable restore
#line 106 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
WriteAttributeValue("", 4474, temp.IdUsuario, 4474, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 4490, "\"", 4513, 1);
#nullable restore
#line 106 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
WriteAttributeValue("", 4498, temp.IdUsuario, 4498, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 4596, "\"", 4617, 1);
#nullable restore
#line 107 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
WriteAttributeValue("", 4602, temp.IdUsuario, 4602, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </label>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 111 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
                                   Write(temp.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 112 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
                                   Write(temp.Oficina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 113 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
                                   Write(temp.Puesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 115 "C:\Users\XPC\Source\Repos\JassonRomero\ProyectoGestorReuniones\GestorReunionesProyectoAnalisis\Views\Tarea\CrearTareaView.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>


            </div>

            <div class=""modal-footer"">
                <button type=""button"" href=""javascript:;"" onclick=""PruebaCerrar(); return false;"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
                <input type=""button"" class=""btn btn-warning"" href=""javascript:;"" data-toggle=""modal"" data-target=""#modalAnadirContacto"" onclick=""anadirContactosTarea(); return false;"" value=""Agregar Contactos"" />
            </div>
        </div>
    </div>
</div>




<!--Modal Luego de añadir contacto-->
<div class=""modal fade"" id=""modalAnadirContacto"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background-color: #343a40 !important;"">
                <h3 style=""color:#ffffff""></h3>
                <button type=""button"" class=""close");
            WriteLiteral(@""" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <h5>Los contactos fueron agregados con exito</h5>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">Aceptar</button>
            </div>
        </div>
    </div>
</div>












<!-- Modal lista de usuario -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591

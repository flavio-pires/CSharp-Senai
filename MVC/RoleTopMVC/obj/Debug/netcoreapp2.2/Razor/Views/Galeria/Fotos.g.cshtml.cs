#pragma checksum "C:\Users\39221000826\Documents\Exercicios .net\MVC\RoleTopMVC\Views\Galeria\Fotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f21aca869fdf1167e094296f9c258df028ff083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Galeria_Fotos), @"mvc.1.0.view", @"/Views/Galeria/Fotos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Galeria/Fotos.cshtml", typeof(AspNetCore.Views_Galeria_Fotos))]
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
#line 1 "C:\Users\39221000826\Documents\Exercicios .net\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\39221000826\Documents\Exercicios .net\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f21aca869fdf1167e094296f9c258df028ff083", @"/Views/Galeria/Fotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Galeria_Fotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8088, true);
            WriteLiteral(@"<main>
            <section id=""eventos"">
                <h2><strong><u>Eventos Corporativos</u></strong></h2>
                <ul id=""imgs"">
                    <li><a href=""#ev-corp1""><img src=""img/eventos_corporativos/1.jpg"" alt=""Evento empresa Vigor"" class=""min""></a></li>
                    <li><a href=""#ev-corp2""><img src=""img/eventos_corporativos/2.jpg"" alt=""Evento empresa Gurlo"" class=""min""></a></li>
                    <li><a href=""#ev-corp3""><img src=""img/eventos_corporativos/3.jpg"" alt=""Evento empresa Bradesco"" class=""min""></a></li>
                    <li><a href=""#ev-corp4""><img src=""img/eventos_corporativos/4.jpg"" alt=""Evento empresa Roca"" class=""min""></a></li>
                </ul>
                
                <div class=""lbox"" id=""ev-corp1"">
                    <div class=""box-img"">
                        <a href=""#ev-corp4"" class=""btn"" id=""prev"">&#171;</a>
                        <a href="""" class=""btn"" id=""close"">X</a>
                        <img src=""img/eventos_corporat");
            WriteLiteral(@"ivos/1.jpg"" alt=""Evento empresa Vigor"">
                        <a href=""#ev-corp2"" class=""btn"" id=""next"">&#187;</a>
                    </div>
                </div>

                <div class=""lbox"" id=""ev-corp2"">
                    <div class=""box-img"">
                        <a href=""#ev-corp1"" class=""btn"" id=""prev"">&#171;</a>
                        <a href="""" class=""btn"" id=""close"">X</a>
                        <img src=""img/eventos_corporativos/2.jpg"" alt=""Evento empresa Gurlo"">
                        <a href=""#ev-corp3"" class=""btn"" id=""next"">&#187;</a>
                    </div>
                </div>

                <div class=""lbox"" id=""ev-corp3"">
                    <div class=""box-img"">
                        <a href=""#ev-corp2"" class=""btn"" id=""prev"">&#171;</a>
                        <a href="""" class=""btn"" id=""close"">X</a>
                        <img src=""img/eventos_corporativos/3.jpg"" alt=""Evento empresa Bradesco"">
                        <a href=""#ev-corp4"" class=""btn");
            WriteLiteral(@""" id=""next"">&#187;</a>
                    </div>
                </div>

                <div class=""lbox"" id=""ev-corp4"">
                    <div class=""box-img"">
                        <a href=""#ev-corp3"" class=""btn"" id=""prev"">&#171;</a>
                        <a href="""" class=""btn"" id=""close"">X</a>
                        <img src=""img/eventos_corporativos/4.jpg"" alt=""Evento empresa Roca"">
                        <a href=""#ev-corp1"" class=""btn"" id=""next"">&#187;</a>
                    </div>
                </div>
            </section>

            <section id=""festas"">
                    <h2><strong><u>Festas e Shows</u></strong></h2>
                    <ul id=""imgs"">
                        <li><a href=""#festa1""><img src=""img/Festas_shows/1.jpeg"" alt=""Festa"" class=""min""></a></li>
                        <li><a href=""#festa2""><img src=""img/Festas_shows/2.jpg"" alt=""Balada"" class=""min""></a></li>
                        <li><a href=""#festa3""><img src=""img/Festas_shows/3.jpg"" alt=""Sho");
            WriteLiteral(@"w do Grupo Revelação"" class=""min""></a></li>
                        <li><a href=""#festa4""><img src=""img/Festas_shows/4.jpg"" alt=""Show"" class=""min""></a></li>
                    </ul>
                    
                    <div class=""lbox"" id=""festa1"">
                        <div class=""box-img"">
                            <a href=""#festa4"" class=""btn"" id=""prev"">&#171;</a>
                            <a href="""" class=""btn"" id=""close"">X</a>
                            <img src=""img/Festas_shows/1.jpeg"" alt=""Festa"">
                            <a href=""#festa2"" class=""btn"" id=""next"">&#187;</a>
                        </div>
                    </div>
    
                    <div class=""lbox"" id=""festa2"">
                        <div class=""box-img"">
                            <a href=""#festa1"" class=""btn"" id=""prev"">&#171;</a>
                            <a href="""" class=""btn"" id=""close"">X</a>
                            <img src=""img/Festas_shows/2.jpg"" alt=""Balada"">
                    ");
            WriteLiteral(@"        <a href=""#festa3"" class=""btn"" id=""next"">&#187;</a>
                        </div>
                    </div>
    
                    <div class=""lbox"" id=""festa3"">
                        <div class=""box-img"">
                            <a href=""#festa2"" class=""btn"" id=""prev"">&#171;</a>
                            <a href="""" class=""btn"" id=""close"">X</a>
                            <img src=""img/Festas_shows/3.jpg"" alt=""Show do Grupo Revelação"">
                            <a href=""#festa4"" class=""btn"" id=""next"">&#187;</a>
                        </div>
                    </div>
    
                    <div class=""lbox"" id=""festa4"">
                        <div class=""box-img"">
                            <a href=""#festa3"" class=""btn"" id=""prev"">&#171;</a>
                            <a href="""" class=""btn"" id=""close"">X</a>
                            <img src=""img/Festas_shows/4.jpg"" alt=""Show"">
                            <a href=""#festa1"" class=""btn"" id=""next"">&#187;</a>
       ");
            WriteLiteral(@"                 </div>
                    </div>
                </section>

                <section id=""formaturas"">
                        <h2><strong><u>Formaturas e Casamentos</u></strong></h2>
                        <ul id=""imgs"">
                            <li><a href=""#format1""><img src=""img/form_casa/1.jpg"" alt=""Festa de Formatura"" class=""min""></a></li>
                            <li><a href=""#format2""><img src=""img/form_casa/2.jpg"" alt=""Festa de Formatura"" class=""min""></a></li>
                            <li><a href=""#format3""><img src=""img/form_casa/3.jpg"" alt=""Festa de Casamento"" class=""min""></a></li>
                            <li><a href=""#format4""><img src=""img/form_casa/4.jpg"" alt=""Festa de Casamento"" class=""min""></a></li>
                        </ul>
                        
                        <div class=""lbox"" id=""format1"">
                            <div class=""box-img"">
                                <a href=""#format4"" class=""btn"" id=""prev"">&#171;</a>
      ");
            WriteLiteral(@"                          <a href="""" class=""btn"" id=""close"">X</a>
                                <img src=""img/form_casa/1.jpg"" alt=""Festa de Formatura"">
                                <a href=""#format2"" class=""btn"" id=""next"">&#187;</a>
                            </div>
                        </div>
        
                        <div class=""lbox"" id=""format2"">
                            <div class=""box-img"">
                                <a href=""#format1"" class=""btn"" id=""prev"">&#171;</a>
                                <a href="""" class=""btn"" id=""close"">X</a>
                                <img src=""img/form_casa/2.jpg"" alt=""Festa de Formatura"">
                                <a href=""#format3"" class=""btn"" id=""next"">&#187;</a>
                            </div>
                        </div>
        
                        <div class=""lbox"" id=""format3"">
                            <div class=""box-img"">
                                <a href=""#format2"" class=""btn"" id=""prev"">&#17");
            WriteLiteral(@"1;</a>
                                <a href="""" class=""btn"" id=""close"">X</a>
                                <img src=""img/form_casa/3.jpg"" alt=""Festa de Casamento"">
                                <a href=""#format4"" class=""btn"" id=""next"">&#187;</a>
                            </div>
                        </div>
        
                        <div class=""lbox"" id=""format4"">
                            <div class=""box-img"">
                                <a href=""#format3"" class=""btn"" id=""prev"">&#171;</a>
                                <a href="""" class=""btn"" id=""close"">X</a>
                                <img src=""img/form_casa/4.jpg"" alt=""Festa de Casamento"">
                                <a href=""#format1"" class=""btn"" id=""next"">&#187;</a>
                            </div>
                        </div>
                    </section>
                            
        </main>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d25a61a9ed3662d47366811ce13624eae474531d"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecto_final.Pages.Gestion_Reserva
{
    #line hidden
    using System;
    using System.Threading.Tasks;
#nullable restore
#line 2 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Proyecto_final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\2021\Proyecto-final\Proyecto-final\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agregar-reserva")]
    public partial class Agregar_Reserva : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #wa {
        text-align: center;
        border: solid;
        border-color: navy;
        width: 50%;
    }

    #com {
        margin-left: 77px;
        width: 80%;
    }

    #combo {
        width: 80%;
    }
</style>

");
            __builder.AddMarkupContent(1, "<h1 style=\"text-align: center;\" class=\"mt-3 col-md-12 pt-2 mb-4\">Modulo de reservas</h1>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "wa");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<h2 id=\"as\" class=\"mt-2 col-md-12 pt-2 mb-4\">Agregar reserva</h2>\r\n    ");
            __builder.OpenElement(7, "form");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id", "com");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                     cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __Blazor.Proyecto_final.Pages.Gestion_Reserva.Agregar_Reserva.TypeInference.CreateInputSelect_0(__builder2, 22, 23, "form-control", 24, 
#nullable restore
#line 37 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                  clientes

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => clientes = __value, clientes)), 26, () => clientes, 27, (__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n                            ");
                    __builder3.AddMarkupContent(29, "<option value disabled selected hidden>Seleccione al cliente</option>\r\n");
#nullable restore
#line 39 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                             foreach (var vacu in cliente)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(30, "                                ");
                    __builder3.OpenElement(31, "option");
                    __builder3.AddAttribute(32, "style", "color: black");
                    __builder3.AddAttribute(33, "value", 
#nullable restore
#line 41 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                     vacu.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(34, 
#nullable restore
#line 41 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                   vacu.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n");
#nullable restore
#line 42 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(36, "                        ");
                }
                );
                __builder2.AddMarkupContent(37, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n                ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "placeholder", "Fecha de inicio de reserva");
            __builder.AddAttribute(43, "style", "width: 80%; margin-left: 77px;");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                         fechainicio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fechainicio = __value, fechainicio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "id", "combo");
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(55);
            __builder.AddAttribute(56, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 51 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                     vehiculos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __Blazor.Proyecto_final.Pages.Gestion_Reserva.Agregar_Reserva.TypeInference.CreateInputSelect_1(__builder2, 59, 60, "form-control", 61, 
#nullable restore
#line 52 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                  vehiculo

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculo = __value, vehiculo)), 63, () => vehiculo, 64, (__builder3) => {
                    __builder3.AddMarkupContent(65, "\r\n                            ");
                    __builder3.AddMarkupContent(66, "<option value disabled selected hidden>Seleccione el vehiculo</option>\r\n");
#nullable restore
#line 54 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                             foreach (var vacu in vehiculos)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(67, "                                ");
                    __builder3.OpenElement(68, "option");
                    __builder3.AddAttribute(69, "style", "color: black");
                    __builder3.AddAttribute(70, "value", 
#nullable restore
#line 56 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                     vacu.Marca

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(71, 
#nullable restore
#line 56 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                  vacu.Marca

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n");
#nullable restore
#line 57 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(73, "                        ");
                }
                );
                __builder2.AddMarkupContent(74, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "text");
            __builder.AddAttribute(79, "placeholder", "Fecha final de reserva");
            __builder.AddAttribute(80, "style", "width: 80%; margin-left: 0%");
            __builder.AddAttribute(81, "class", "form-control");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                     fechafin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fechafin = __value, fechafin));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n    ");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "data-bs-toggle", "modal");
            __builder.AddAttribute(90, "data-bs-target", "#exampleModal");
            __builder.AddAttribute(91, "type", "submit");
            __builder.AddAttribute(92, "class", "btn btn-primary");
            __builder.AddAttribute(93, "style", "width: 15%; margin-top: 20px; margin-bottom: 20px;");
            __builder.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                                                                                                             Agregar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, "Agregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n    \r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "modal fade");
            __builder.AddAttribute(100, "id", "exampleModal");
            __builder.AddAttribute(101, "tabindex", "-1");
            __builder.AddAttribute(102, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(103, "aria-hidden", "true");
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "modal-dialog");
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "modal-content");
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.AddMarkupContent(111, "<div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\" id=\"exampleModalLabel\">Factura</h5>\r\n                </div>\r\n                ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "modal-body");
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.OpenElement(115, "form");
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "row");
            __builder.AddMarkupContent(119, "\r\n                            ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "col");
            __builder.AddMarkupContent(122, "\r\n                                ");
            __builder.OpenElement(123, "label");
            __builder.AddAttribute(124, "style", "font-size: 20px;");
            __builder.AddMarkupContent(125, "<strong>Cliente: </strong> ");
            __builder.AddContent(126, 
#nullable restore
#line 83 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                            clientes

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(127, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(129, "label");
            __builder.AddAttribute(130, "style", "font-size: 20px;");
            __builder.AddMarkupContent(131, "<strong>Marca: </strong> ");
            __builder.AddContent(132, 
#nullable restore
#line 85 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                          vehiculo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(133, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(135, "label");
            __builder.AddAttribute(136, "style", "font-size: 20px;");
            __builder.AddMarkupContent(137, "<strong>Modelo: </strong> ");
            __builder.AddContent(138, 
#nullable restore
#line 87 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                           modelo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(139, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(141, "label");
            __builder.AddAttribute(142, "style", "font-size: 20px;");
            __builder.AddMarkupContent(143, "<strong>Año: </strong> ");
            __builder.AddContent(144, 
#nullable restore
#line 89 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                        año

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(145, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(147, "label");
            __builder.AddAttribute(148, "style", "font-size: 20px;");
            __builder.AddMarkupContent(149, "<strong>Color: </strong> ");
            __builder.AddContent(150, 
#nullable restore
#line 91 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                          color

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(151, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(153, "label");
            __builder.AddAttribute(154, "style", "font-size: 20px;");
            __builder.AddMarkupContent(155, "<strong>Tipo: </strong> ");
            __builder.AddContent(156, 
#nullable restore
#line 93 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                         tipo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(157, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(159, "label");
            __builder.AddAttribute(160, "style", "font-size: 20px;");
            __builder.AddMarkupContent(161, "<strong>Capacidad: </strong> ");
            __builder.AddContent(162, 
#nullable restore
#line 95 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                              capacidad

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(163, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(165, "label");
            __builder.AddAttribute(166, "style", "font-size: 20px;");
            __builder.AddMarkupContent(167, "<strong>Pasajeros: </strong> ");
            __builder.AddContent(168, 
#nullable restore
#line 97 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                              pasajeros

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(169, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                            ");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "col");
            __builder.AddMarkupContent(174, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(175, "label");
            __builder.AddAttribute(176, "style", "font-size: 20px;");
            __builder.AddMarkupContent(177, "<strong>Matricula: </strong> ");
            __builder.AddContent(178, 
#nullable restore
#line 101 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                              matricula

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(179, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(181, "label");
            __builder.AddAttribute(182, "style", "font-size: 20px;");
            __builder.AddMarkupContent(183, "<strong>Numero de seguro: </strong> ");
            __builder.AddContent(184, 
#nullable restore
#line 103 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                                     numero_seguro

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(185, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(187, "label");
            __builder.AddAttribute(188, "style", "font-size: 20px;");
            __builder.AddMarkupContent(189, "<strong>Latitud: </strong> ");
            __builder.AddContent(190, 
#nullable restore
#line 105 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                            latitud

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(191, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(193, "label");
            __builder.AddAttribute(194, "style", "font-size: 20px;");
            __builder.AddMarkupContent(195, "<strong>Longitud: </strong> ");
            __builder.AddContent(196, 
#nullable restore
#line 107 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                             longitud

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(197, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(199, "label");
            __builder.AddAttribute(200, "style", "font-size: 20px;");
            __builder.AddMarkupContent(201, "<strong>Fecha inicio:  </strong> ");
            __builder.AddContent(202, 
#nullable restore
#line 109 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                                  fechainicio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(203, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(205, "label");
            __builder.AddAttribute(206, "style", "font-size: 20px;");
            __builder.AddMarkupContent(207, "<strong>Fecha fin:  </strong> ");
            __builder.AddContent(208, 
#nullable restore
#line 111 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                               fechafin

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(209, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n                                <br>\r\n                                ");
            __builder.OpenElement(211, "label");
            __builder.AddAttribute(212, "style", "font-size: 20px;");
            __builder.AddMarkupContent(213, "<strong>Precio por dia: </strong> ");
            __builder.AddContent(214, 
#nullable restore
#line 113 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                                   precio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(215, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n");
#nullable restore
#line 117 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                         if (mensaje == 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(219, "                            ");
            __builder.AddMarkupContent(220, "<div class=\"alert alert-success mt-2 mb-2 ml-5 mr-5\" role=\"alert\">Reserva Agregada Exitosamente</div>\r\n");
#nullable restore
#line 120 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                         if (mensaje == 2)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(221, "        ");
            __builder.AddMarkupContent(222, "<div class=\"alert alert-danger mt-2 mb-2 ml-5 mr-5\" role=\"alert\">En estos momentos este vehiculo no se encuentra disponible</div>\r\n");
#nullable restore
#line 124 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(223, "                        ");
            __builder.OpenElement(224, "div");
            __builder.AddAttribute(225, "class", "modal-footer");
            __builder.AddMarkupContent(226, "\r\n                            ");
            __builder.OpenElement(227, "button");
            __builder.AddAttribute(228, "type", "button");
            __builder.AddAttribute(229, "class", "btn btn-danger");
            __builder.AddAttribute(230, "data-bs-dismiss", "modal");
            __builder.AddAttribute(231, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
                                                                                                           Cerrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(232, "Cerrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(233, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(238, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 134 "C:\2021\Proyecto-final\Proyecto-final\Pages\Gestion-Reserva\Agregar-Reserva.razor"
       

    string clientes = "", vehiculo = "", fechainicio = "", fechafin = "", esta = "";
    string modelo = "", año = "", color = "", tipo = "", capacidad = "", pasajeros = "", matricula = "", numero_seguro = "", latitud = "", longitud = "", precio = "";
    int mensaje;
    bool validar;
    string men;

    public List<Cliente> GetCliente() => new db_a72daa_proyecContext().Cliente.ToList();
    public List<Vehiculos> GetVehiculos() => new db_a72daa_proyecContext().Vehiculos.ToList();
    public List<Cliente> cliente;
    public List<Vehiculos> vehiculos = new List<Vehiculos>();

    protected override void OnInitialized()
    {
        cliente = GetCliente();
        vehiculos = GetVehiculos();
    }

    public void Agregar()
    {
        using (db_a72daa_proyecContext db = new db_a72daa_proyecContext())
        {

            validar = db.Vehiculos.Any(ee => ee.Marca == vehiculo);

            if (validar)
            {
                Validacion(vehiculo);

            }
            
        }
    }

    public void Validacion(string vehicu)
    {
        using (db_a72daa_proyecContext db = new db_a72daa_proyecContext())
        {
            foreach (var vario in vehiculos)
            {
                if (vario.Marca == vehicu)
                {
                    men = vario.Estado;
                    modelo = vario.Modelo;
                    año = vario.Anio;
                    color = vario.Color;
                    precio = vario.PrecioDia;
                    tipo = vario.Tipo;
                    capacidad = vario.Capacidad;
                    pasajeros = vario.Pasajeros;
                    matricula = vario.Matricula;
                    numero_seguro = vario.NumSeguro;
                    latitud = vario.Latitud;
                    longitud = vario.Longitud;
                }
            }

            Reservas re = new Reservas();

            if (men == "Disponible")
            {
                re.Cliente = clientes;
                re.Vehiculo = vehiculo;
                re.FechaDeInicio = fechainicio;
                re.FechaDeFin = fechafin;

                db.Add(re);
                db.SaveChanges();
                mensaje = 1;


            }
            else
            {
                mensaje = 2;
            }

        }

    }


    public void Cerrar()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Proyecto_final.Pages.Gestion_Reserva.Agregar_Reserva
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

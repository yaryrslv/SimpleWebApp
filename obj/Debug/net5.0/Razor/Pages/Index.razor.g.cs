#pragma checksum "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378fba66fe2149201e72a685224e48a4f4816254"
// <auto-generated/>
#pragma warning disable 1591
namespace SimpleWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using SimpleWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anonymous\Desktop\SimpleWebApp\_Imports.razor"
using SimpleWebApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "form");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(5, "<label for=\"productName\">Название товара</label>\r\n                ");
                __builder2.OpenElement(6, "input");
                __builder2.AddAttribute(7, "type", "name");
                __builder2.AddAttribute(8, "class", "form-control");
                __builder2.AddAttribute(9, "id", "productName1");
                __builder2.AddAttribute(10, "placeholder", "Товар");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                                                                                                     Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(16, "<label for=\"productCost\">Цена товара</label>\r\n                ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "cost");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "id", "productCost1");
                __builder2.AddAttribute(21, "placeholder", "0");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                                                                                                 Cost

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Cost = __value, Cost));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "type", "submit");
                __builder2.AddAttribute(27, "class", "btn btn-primary");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                                                                    ()=> Add(Name, Cost)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(29, "Добавить товар");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n        <br>\r\n\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group col-md-8");
                __builder2.OpenElement(33, "table");
                __builder2.AddAttribute(34, "class", "table table-sm");
                __builder2.AddMarkupContent(35, "<thead><tr><th scope=\"col\">#</th>\r\n                        <th scope=\"col\">Название</th>\r\n                        <th scope=\"col\">Цена</th></tr></thead>\r\n                ");
                __builder2.OpenElement(36, "tbody");
#nullable restore
#line 48 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                      
                        int Id = 0;
                        foreach (var item in Products)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(37, "tr");
                __builder2.OpenElement(38, "th");
                __builder2.AddAttribute(39, "scope", "row");
                __builder2.AddContent(40, 
#nullable restore
#line 53 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                                                 Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                                ");
                __builder2.OpenElement(42, "td");
                __builder2.AddContent(43, 
#nullable restore
#line 54 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                                     item.Key

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                ");
                __builder2.OpenElement(45, "td");
                __builder2.AddContent(46, 
#nullable restore
#line 55 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                                     item.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 57 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                            Id += 1;
                        }
                    

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "tr");
                __builder2.AddAttribute(48, "class", "table-active");
                __builder2.AddMarkupContent(49, "<th scope=\"row\">#</th>\r\n                        ");
                __builder2.AddMarkupContent(50, "<td>Общая цена:</td>\r\n                        ");
                __builder2.OpenElement(51, "td");
                __builder2.AddContent(52, 
#nullable restore
#line 63 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
                             Products.Values.Sum()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(53, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(54, "<h1>Привет, покупатель!</h1>\r\n        ");
                __builder2.AddMarkupContent(55, "<p>Пожалуйста, войди, или зарегистрируйся.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Anonymous\Desktop\SimpleWebApp\Pages\Index.razor"
              


            public static Dictionary<string, int> Products = new Dictionary<string, int>();

            public string Name { get; set; }
            public int Cost { get; set; }

            public void Add(string Name, int Cost)
            {
                Products.Add(Name, Cost);
            }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Aviso.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f5454aebbee19eee9a8698fb95d3f636887b9a"
// <auto-generated/>
#pragma warning disable 1591
namespace Mercado_dupolvo.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Mercado_dupolvo.Client;

#line default
#line hidden
#line 7 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Mercado_dupolvo.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Mercado_dupolvo.Shared.Models;

#line default
#line hidden
#line 9 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 10 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using Mercado_dupolvo.Client.Auth;

#line default
#line hidden
#line 12 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 13 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#line 14 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
    public partial class Aviso : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 1 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Aviso.razor"
 if (Exibir)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(3, "role", "alertdialog");
            __builder.AddMarkupContent(4, "\r\n        ");
#line 4 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Aviso.razor"
__builder.AddContent(5, ChildContent);

#line default
#line hidden
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#line 6 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Aviso.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 8 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Aviso.razor"
       
    [Parameter]
    public bool Exibir { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591

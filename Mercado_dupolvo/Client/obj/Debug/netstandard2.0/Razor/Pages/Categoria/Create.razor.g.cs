#pragma checksum "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Categoria\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71b31212a636cc5985c0059916a95164b3c44401"
// <auto-generated/>
#pragma warning disable 1591
namespace Mercado_dupolvo.Client.Pages.Categoria
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Nova Categoria</h2>\r\n\r\n");
            __builder.OpenComponent<Mercado_dupolvo.Client.Pages.Categoria.CategoriaForm>(1);
            __builder.AddAttribute(2, "Categoria", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Mercado_dupolvo.Shared.Models.Categoria>(
#line 7 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Categoria\Create.razor"
                           categoria

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 7 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Categoria\Create.razor"
                                                      CriarCategoria

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "ButtonTextSubmit", "Salvar");
            __builder.AddAttribute(5, "ButtonTextCancelar", "Cancelar");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 12 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Categoria\Create.razor"
       
    
    Categoria categoria = new Categoria();

    async Task CriarCategoria()
    {
        await http.PostJsonAsync("api/categoria", categoria);
        navigation.NavigateTo("categoria");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591

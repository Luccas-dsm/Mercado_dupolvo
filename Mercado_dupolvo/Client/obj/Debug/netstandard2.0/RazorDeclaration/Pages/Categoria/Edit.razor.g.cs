// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria/edit/{categoriaid:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 12 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Categoria\Edit.razor"
       

    [Parameter]
    public int categoriaid { get; set; }

    Categoria categoria = new Categoria();

    protected async override Task OnParametersSetAsync()
    {
        categoria = 
        await http.GetJsonAsync<Categoria>($"api/categoria/{categoriaid}");
    }

    async Task EditarCategoria()
    {
        await http.PutJsonAsync("api/categoria", categoria);
        navigation.NavigateTo("categoria");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439aa31da7b8816870b7b8b2cad3adc479683965"
// <auto-generated/>
#pragma warning disable 1591
namespace Mercado_dupolvo.Client.Pages.Catalogo
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/catalogo/{CategoriaId:int}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "principal");
            __builder.AddMarkupContent(2, "\r\n");
#line 20 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
 if (produtos == null)
{

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>Carregando...</em></p>\r\n");
#line 23 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
}
else if (produtos.Count == 0)
{

#line default
#line hidden
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<p><em>N??o existem produtos cadastrados...</em></p>\r\n");
#line 27 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
}
else
{
   
     
     

#line default
#line hidden
#line 32 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
      foreach (var produto in produtos)
        {

#line default
#line hidden
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-3 col-lg-3 col-md-3");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card");
            __builder.AddAttribute(13, "style", "border: none");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", "data:image/jpge;base64," + (
#line 36 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
                                                      produto.ImagemUrl

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "class", "img-rounded");
            __builder.AddAttribute(18, "alt", 
#line 37 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
                               produto.Nome

#line default
#line hidden
            );
            __builder.AddAttribute(19, "width", "180");
            __builder.AddAttribute(20, "height", "180");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "h4");
            __builder.AddAttribute(26, "class", "pull-right");
#line 39 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
__builder.AddContent(27, produto.Preco);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "h4");
            __builder.AddAttribute(30, "class", "card-title");
#line 40 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
__builder.AddContent(31, produto.Nome);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "card-text");
#line 41 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
__builder.AddContent(35, produto.Descricao);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "produto/detalhe/" + (
#line 42 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
                                                  produto.ProdutoId

#line default
#line hidden
            ));
            __builder.AddContent(39, "Detalhes");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#line 46 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
        }

#line default
#line hidden
#line 46 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
         
}

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 49 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Catalogo\Index.razor"
       
    


    List<Produto> produtos { get; set; }
    List<Categoria> categorias { get; set; }
    private int codigoCategoria;

    [Parameter]
    public int CategoriaId { get; set; }

    

    protected override async Task OnParametersSetAsync()
    {     
            categorias = await http.GetJsonAsync<List<Categoria>>("api/categoria/todas");
            if (CategoriaId == 0)
            {
                codigoCategoria = categorias[0].CategoriaId;
            }
            else
            {
                codigoCategoria = CategoriaId;
            }

            await CarregaProdutos();
    }


    async Task CarregaProdutos()
    {
        produtos =
          await http.GetJsonAsync<List<Produto>>($"/api/produto/categorias/{codigoCategoria}");

        StateHasChanged();
    }

    async void CategoriaSelectionChanged(ChangeEventArgs e)
    {
        if (int.TryParse(e.Value.ToString(), out int id))
        {
            codigoCategoria = id;
            await CarregaProdutos();
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591

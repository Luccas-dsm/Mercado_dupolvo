#pragma checksum "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62acb1097e9b19555778c2e75cbda25b24479cac"
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
    public partial class Paginacao : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Paginacao");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\r\n");
#line 3 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor"
         foreach (var link in links)
        {

#line default
#line hidden
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 5 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor"
                            () => PaginaSelecionadaLink(link)

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "style", "cursor: pointer;");
            __builder.AddAttribute(10, "class", "page-item" + " " + (
#line 7 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor"
                                   link.Enabled ? null : "disabled"

#line default
#line hidden
            ) + " " + (
#line 7 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor"
                                                                       link.Active ? "active" : null

#line default
#line hidden
            ));
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "page-link");
            __builder.AddAttribute(14, "href", "#");
#line 8 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor"
__builder.AddContent(15, link.Text);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#line 10 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor"
        }

#line default
#line hidden
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 14 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Shared\Paginacao.razor"
       

    [Parameter] public int paginaAtual { get; set; } = 1;
    [Parameter] public int QuantidadeTotalPaginas { get; set; }
    [Parameter] public int Raio { get; set; } = 3;
    [Parameter] public EventCallback<int> PaginaSelecionada  { get; set; }

    List<LinkModel> links;

    class LinkModel
    {
        public LinkModel(int page) : this(page, true)
        { }

        public LinkModel(int page, bool enabled) : this(page, enabled, page.ToString())
        { }

        public LinkModel(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }

        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;
    }

    private async Task PaginaSelecionadaLink(LinkModel link)
    {
        //se clicar na pagina atual n??o faz nada
        if (link.Page == paginaAtual)
        {
            return;
        }

        //se a pagina n??o estava habilitada n??o faz nada
        if (!link.Enabled)
        {
            return;
        }

        //definimos a pagina atual para o link que foi clicado
        paginaAtual = link.Page;
        //Passa o n??mero da pagina a selecionar 
        //faz com que seja enviada um request a API solicitando a informa????o da nova pagina
        await PaginaSelecionada.InvokeAsync(link.Page);
    }
    
    protected override void OnParametersSet()
    {
        CarregaPaginas();
    }


    private void CarregaPaginas()
    {
        links = new List<LinkModel>();

        //tratar o link da pagina anterior
        var isLinkPaginaAnteriorHabilitado = paginaAtual != 1;
        var paginaAnterior = paginaAtual - 1;

        links.Add(new LinkModel(paginaAnterior, isLinkPaginaAnteriorHabilitado, "Anterior"));

        //trata os links das paginas especificas
        for(int i=1; i<= QuantidadeTotalPaginas; i++)
        {
            if (i >= paginaAtual - Raio && i <= paginaAtual + Raio)
            {
                links.Add(new LinkModel(i)
                {
                    Active = paginaAtual == i
                });
            }
        }

        //trata o link para a proxima pagina
         var isLinkProximaPaginaHabilitado = paginaAtual != QuantidadeTotalPaginas;
        var proximaPagina = paginaAtual + 1;

        links.Add(new LinkModel(proximaPagina, isLinkProximaPaginaHabilitado, "Pr??ximo"));
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591

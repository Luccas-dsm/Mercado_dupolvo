#pragma checksum "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e4df051d84d078574adebdbbbd965d2b7a1eb56"
// <auto-generated/>
#pragma warning disable 1591
namespace Mercado_dupolvo.Client.Pages.Autentica
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container col-6");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Mercado_dupolvo.Client.Shared.Aviso>(3);
            __builder.AddAttribute(4, "Exibir", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 7 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
                   loginFalhou

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "h5");
#line 8 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
__builder2.AddContent(8, Mensagem);

#line default
#line hidden
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<h5 class=\"card-title\">Login</h5>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 13 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
                                 userinfo

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 13 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
                                                          FazerLogin

#line default
#line hidden
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n                    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.AddMarkupContent(25, "<label>Email</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 19 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
                                                userinfo.Email

#line default
#line hidden
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userinfo.Email = __value, userinfo.Email))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userinfo.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __Blazor.Mercado_dupolvo.Client.Pages.Autentica.Login.TypeInference.CreateValidationMessage_0(__builder2, 32, 33, 
#line 20 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
                                                  ()=> userinfo.Email

#line default
#line hidden
                );
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.AddMarkupContent(39, "<label>Password</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "type", "password");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 25 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
                                                userinfo.Password

#line default
#line hidden
                ));
                __builder2.AddAttribute(44, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userinfo.Password = __value, userinfo.Password))));
                __builder2.AddAttribute(45, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userinfo.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __Blazor.Mercado_dupolvo.Client.Pages.Autentica.Login.TypeInference.CreateValidationMessage_1(__builder2, 47, 48, 
#line 26 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
                                                  ()=> userinfo.Password

#line default
#line hidden
                );
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.AddMarkupContent(51, "<button type=\"submit\" class=\"btn btn-outline-primary btn-sm\">Login</button>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "C:\Users\lucca\Desktop\Mercado_dupolvo\Mercado_dupolvo\Client\Pages\Autentica\Login.razor"
        
        private UserInfo userinfo = new UserInfo();

        bool loginFalhou = false;

        [Parameter]
        public string Mensagem { get; set; }

        async Task FazerLogin()
        {
            try
            {
                //var result = await http.PostJsonAsync<UserToken>("api/account/login", userinfo);

                var loginAsJson = JsonSerializer.Serialize(userinfo);

                var httpResponse = await http.PostAsync("api/account/Login",
                         new StringContent(loginAsJson, Encoding.UTF8, "application/json"));

                if (httpResponse.IsSuccessStatusCode)
                {
                    var responseAsString = await httpResponse.Content.ReadAsStringAsync();

                    var loginResult = JsonSerializer.Deserialize<UserToken>(responseAsString,
                         new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    await authStateProvider.Login(loginResult.Token);
                    navigation.NavigateTo("/");
                }
                else
                {
                    loginFalhou = true;
                    Mensagem = $"Não foi possível realizar o Login do usuário.(Erro: {httpResponse.StatusCode})";
                }
            }
            catch (Exception)
            {
                loginFalhou = true;
                Mensagem = "Não foi possível realizar o Login do Usuário...";
            }
        }
    

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TokenAuthenticationProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Mercado_dupolvo.Client.Pages.Autentica.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

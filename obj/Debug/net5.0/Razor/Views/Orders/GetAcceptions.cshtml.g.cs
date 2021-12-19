#pragma checksum "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e590e0b589f08f2961ee0f9b088e35c9e1260f67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_GetAcceptions), @"mvc.1.0.view", @"/Views/Orders/GetAcceptions.cshtml")]
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
#line 1 "C:\learning\hackaton\Views\_ViewImports.cshtml"
using hackaton;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\learning\hackaton\Views\_ViewImports.cshtml"
using hackaton.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e590e0b589f08f2961ee0f9b088e35c9e1260f67", @"/Views/Orders/GetAcceptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa3d7b29c774f988e508fb7e6e0ffbe85a0df62", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_GetAcceptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<hackaton.Models.challenger>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:40px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetOrderInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
  
    ViewBag.Title = "Приглашения";
    string get_hash(string name)
    {
        var tmpsrc = ASCIIEncoding.ASCII.GetBytes(name);
        var tmphash = new MD5CryptoServiceProvider().ComputeHash(tmpsrc);
        Int32 int_hash = Math.Abs(BitConverter.ToInt32(tmphash) % 23) + 1;
        string name_hash = "(" + int_hash.ToString() + ").jpg";
        return name_hash;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <h3 class=\"pl-5\">Мои приглашения</h3>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 21 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"row m-2 d-flex align-items-center align-content-center\" style=\"border:1px solid black; border-radius:4px\">\r\n                <div class=\"col-2\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e590e0b589f08f2961ee0f9b088e35c9e1260f676632", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 891, "~/images/lazy/", 891, 14, true);
#nullable restore
#line 27 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
AddHtmlAttributeValue("", 905, get_hash(item.order.name), 905, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-8\">\r\n                    <div class=\"d-flex flex-column\">\r\n                        <p style=\"margin-bottom:0px\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e590e0b589f08f2961ee0f9b088e35c9e1260f678647", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 33 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                           Write(item.order.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                                                                                   WriteLiteral(item.order.id_order);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 36 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                         if (item.id_status == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-flex flex-column\">\r\n                                <p style=\"margin-bottom:0px\">Дней выполнения: ");
#nullable restore
#line 39 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                                                                         Write(item.order.due_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 41 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                         if (item.id_status == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row d-flex align-content-center"">
                                <div class=""col-4"">
                                    <input class=""form-control"" placeholder=""Телефон"" type=""text"" name=""telephone"" />
                                </div>
                                <div class=""col-4"">
                                    <button");
            BeginWriteAttribute("value", " value=\"", 2174, "\"", 2196, 1);
#nullable restore
#line 49 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
WriteAttributeValue("", 2182, item.id_order, 2182, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" onclick=\"get_verify(this)\">\r\n                                        Получить код\r\n                                    </button>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 54 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                         if (item.id_status == 4)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"d-flex flex-column\">\r\n                                <p style=\"margin-bottom:0px\">Дата начала: ");
#nullable restore
#line 58 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                                                                     Write(item.order.day_started);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p style=\"margin-bottom:0px\">Дней выполнения: ");
#nullable restore
#line 59 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                                                                         Write(item.order.due_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 61 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"col-2\">\r\n");
#nullable restore
#line 65 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                     if (item.id_status == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("id", " id=\"", 3052, "\"", 3071, 1);
#nullable restore
#line 67 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
WriteAttributeValue("", 3057, item.id_order, 3057, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-flex flex-column"">
                            <button onclick=""accept(this)"" class=""btn btn-primary"">
                                Согласиться
                            </button>
                            <button onclick=""subscribe(this)"" class=""btn btn-primary mt-1"">
                                Отписаться
                            </button>
                        </div>
");
#nullable restore
#line 75 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                    }
                    else if (item.id_status == 4)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                         if (item.order.id_status == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("id", " id=\"", 3692, "\"", 3711, 1);
#nullable restore
#line 80 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
WriteAttributeValue("", 3697, item.id_order, 3697, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-flex flex-column"">
                                <button onclick=""accept(this)"" class=""btn btn-primary"">
                                    Отказаться
                                </button>
                                <button onclick=""subscribe(this)"" class=""btn btn-primary mt-1"">
                                    Отписаться
                                </button>
                            </div>
");
#nullable restore
#line 88 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                         
                    }
                    else if (item.id_status == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("id", " id=\"", 4298, "\"", 4317, 1);
#nullable restore
#line 92 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
WriteAttributeValue("", 4303, item.id_order, 4303, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-flex flex-column\">\r\n                            <button onclick=\"subscribe(this)\" class=\"btn btn-primary w-100\">\r\n                                Отписаться\r\n                            </button>\r\n                        </div>\r\n");
#nullable restore
#line 97 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 102 "C:\learning\hackaton\Views\Orders\GetAcceptions.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function accept(elem)
        {
            let bluat = """";
            if (elem.parentElement.parentElement.previousElementSibling
                .firstElementChild.lastElementChild.firstElementChild.firstElementChild != undefined)
                bluat = elem.parentElement.parentElement.previousElementSibling
                    .firstElementChild.lastElementChild.firstElementChild.firstElementChild.value;
            let request = new XMLHttpRequest();
            request.open(""POST"", ""/Orders/AcceptToOrder"");
            request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            let body = ""id="" + elem.parentElement.id + ""&code="" + bluat;
            request.onreadystatechange = () => {
                if (request.readyState == 4 && request.status == 200) {
                    let response = JSON.parse(request.responseText);
                    if (response.accepted == ""true"") {
                        elem.innerHTML = ""Отказаться"";
");
                WriteLiteral(@"                    }
                    else if (response.accepted == ""false"") {
                        elem.innerHTML = ""Согласиться"";
                    }
                }
            }
            request.send(body);
        }
        function get_verify(elem)
        {
            let tel = elem.parentElement.previousElementSibling.firstElementChild.value;
            let request = new XMLHttpRequest();
            request.open(""POST"", ""/Orders/GetVerifyTel"");
            request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            let body = ""tel="" + tel;
            request.onreadystatechange = () => {
                if (request.readyState == 4 && request.status == 200) {
                    let response = JSON.parse(request.responseText);
                    if (response.status == ""200Ok"") {
                        elem.parentElement.previousElementSibling.firstElementChild.value = """";
                        elem.parentElement.previousElementSibl");
                WriteLiteral(@"ing.firstElementChild.placeholder = ""Введите присланный код"";
                        elem.parentElement.removeChild(elem);
                    }
                }
            }
            request.send(body);
        }
        function subscribe(elem) {
            let request = new XMLHttpRequest();
            request.open(""POST"", ""/Orders/SubscribeToOrder"");
            request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            let body = ""id="" + elem.parentElement.id;
            request.onreadystatechange = () => {
                if (request.readyState == 4 && request.status == 200) {
                    let response = JSON.parse(request.responseText);
                    if (response.subscribed == ""true"") {
                        elem.innerHTML = ""Отписаться"";
                    }
                    else if (response.subscribed == ""false"") {
                        elem.innerHTML = ""Подписаться"";
                    }
                }
         ");
                WriteLiteral("   }\r\n            request.send(body);\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<hackaton.Models.challenger>> Html { get; private set; }
    }
}
#pragma warning restore 1591

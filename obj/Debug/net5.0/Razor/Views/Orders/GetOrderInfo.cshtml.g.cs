#pragma checksum "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ec3bb9c3a59e1f579abe126088afcbc426e80c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_GetOrderInfo), @"mvc.1.0.view", @"/Views/Orders/GetOrderInfo.cshtml")]
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
#line 1 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ec3bb9c3a59e1f579abe126088afcbc426e80c", @"/Views/Orders/GetOrderInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa3d7b29c774f988e508fb7e6e0ffbe85a0df62", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_GetOrderInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<hackaton.Models.order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:4px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-typeid", "friendid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetChallangers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3 btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CloseOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
  
    ViewBag.Title = "Информация о заказе";
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
            WriteLiteral("<div class=\"row\">\r\n    <div style=\"border:1px solid black; border-radius: 2px\" class=\"col-4 pt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71ec3bb9c3a59e1f579abe126088afcbc426e80c7755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 633, "~/images/lazy/", 633, 14, true);
#nullable restore
#line 17 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
AddHtmlAttributeValue("", 647, get_hash(Model.name), 647, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <h3>");
#nullable restore
#line 18 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 19 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
         if (Model.user.user_id == Guid.Parse(User.Identity.Name))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Создатель: ты моя прелесть</p>\r\n");
#nullable restore
#line 22 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
        }
        else 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Создатель: ");
#nullable restore
#line 25 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                     Write(Model.user.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
         if (ViewBag.action == 2 || ViewBag.action == 3 || ViewBag.action == 4) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71ec3bb9c3a59e1f579abe126088afcbc426e80c10764", async() => {
                WriteLiteral("\r\n                Написать пользователю\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                               WriteLiteral(Model.user_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-typeid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["typeid"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""col-4 ml-3"">
        <div class=""row"">
            <div style=""border:1px solid black; border-radius:2px"" class=""col-12"">
                <div class=""p-3 d-flex flex-column align-items-start"">
                    <p style=""margin-bottom:0px"">Категория: ");
#nullable restore
#line 38 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                       Write(Model.category.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p style=\"margin-bottom:0px\">Стоимость: ");
#nullable restore
#line 39 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                       Write(Model.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p style=\"margin-bottom:0px\">Статус: ");
#nullable restore
#line 40 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                    Write(Model.orderStatus.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p style=\"margin-bottom:0px\">Количество откликнувшихся: ");
#nullable restore
#line 41 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                                       Write(Model.challengers.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 42 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                     if (Model.day_started == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"margin-bottom:0px\">Начало выполнения: Пока не начато</p>\r\n");
#nullable restore
#line 45 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"margin-bottom:0px\">Начало выполнения: ");
#nullable restore
#line 48 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                                   Write(Model.day_started);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 49 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""row pt-3"">
            <div style=""border:1px solid black; border-radius:2px"" class=""col-12"">
                <div class=""p-3 d-flex flex-column justify-content-around"">
                    <p>Описание: ");
#nullable restore
#line 56 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                            Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-3\">\r\n");
#nullable restore
#line 62 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
         switch (ViewBag.action)
        {
            case 1:
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-success\">\r\n                        Удалить заказ\r\n                    </button>\r\n");
#nullable restore
#line 69 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    break;
                }
            case 2:
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-success\">\r\n                        Отписаться от заказа\r\n                    </button>\r\n");
#nullable restore
#line 76 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    break;
                }
            case 3:
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-success\">\r\n                        Отказаться выполнять заказ\r\n                    </button>\r\n");
#nullable restore
#line 83 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    break;
                }
            case 4:
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("id", " id=\"", 3367, "\"", 3387, 1);
#nullable restore
#line 87 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
WriteAttributeValue("", 3372, Model.id_order, 3372, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"subscribe(this)\" class=\"btn btn-success\">\r\n                        Подписаться\r\n                    </button>\r\n");
#nullable restore
#line 90 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    break;
                }
            case 5:
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button class=\"btn btn-success\">\r\n                        Удалить заказ\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71ec3bb9c3a59e1f579abe126088afcbc426e80c19560", async() => {
                WriteLiteral("\r\n                        Посмотреть кандидатов\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                                             WriteLiteral(Model.id_order);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 100 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    break;
                }
            case 6:
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button onclick=\"payForOrder(this)\"");
            BeginWriteAttribute("value", " value=\"", 4069, "\"", 4092, 1);
#nullable restore
#line 104 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
WriteAttributeValue("", 4077, Model.id_order, 4077, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">\r\n                        Зплатить за заказ\r\n                    </button>\r\n");
#nullable restore
#line 107 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    break;
                }
            case 7:
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71ec3bb9c3a59e1f579abe126088afcbc426e80c23122", async() => {
                WriteLiteral("\r\n                        Завершить заказ\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                                                                         WriteLiteral(Model.id_order);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 114 "C:\learning\hackaton\Views\Orders\GetOrderInfo.cshtml"
                    break;
                }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function payForOrder(elem)
        {
            let request = new XMLHttpRequest();
            request.open(""POST"", ""/Orders/PayForOrder"");
            request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            let body = ""id="" + elem.value;
            request.onreadystatechange = () => {
                if (request.readyState == 4 && request.status == 200) {
                    let response = JSON.parse(request.responseText);
                    if (response.payed == ""true"") {
                        elem.innerHTML = ""Оплачено"";
                    }
                }
            }
            request.send(body);
        }
        function subscribe(elem)
        {
                let request = new XMLHttpRequest();
                request.open(""POST"", ""/Orders/SubscribeToOrder"");
                request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
                let body = ""id="" + elem.id;
           ");
                WriteLiteral(@"     request.onreadystatechange = () =>
                {
                    if (request.readyState == 4 && request.status == 200) {
                        let response = JSON.parse(request.responseText);
                        if (response.subscribed == ""true"") {
                            elem.innerHTML = ""Отписаться"";
                        }
                        else if (response.subscribed == ""false"")
                        {
                            elem.innerHTML = ""Подписаться"";
                        }
                    }
                }
            request.send(body);
            }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hackaton.Models.order> Html { get; private set; }
    }
}
#pragma warning restore 1591

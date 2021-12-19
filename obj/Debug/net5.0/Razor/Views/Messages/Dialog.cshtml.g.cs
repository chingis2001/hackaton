#pragma checksum "C:\learning\hackaton\Views\Messages\Dialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "270a9da6f6e6e0c7082033a67e793c5a375d3344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Dialog), @"mvc.1.0.view", @"/Views/Messages/Dialog.cshtml")]
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
#line 1 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270a9da6f6e6e0c7082033a67e793c5a375d3344", @"/Views/Messages/Dialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa3d7b29c774f988e508fb7e6e0ffbe85a0df62", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Dialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<hackaton.Models.MessagessWithUsersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetUserInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
  
    Guid IdUser = Guid.Parse(Context.User.Identity.Name);
    ViewData["Title"] = Model.пользователи.FirstOrDefault(t => t.user_id != IdUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div id=""messageslist"" class=""col-12"" style=""margin-bottom:0; background-color: #ffffff; border-radius: 4px; margin-bottom: 0"">
        <div class=""row"" style=""margin-top: 0.4rem; border-bottom: 2px solid #e7e8ec; margin-bottom: 1rem; height:46px"">
            <div class=""col-12"">
                <h5 style=""padding-bottom:0.4rem"">");
#nullable restore
#line 11 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                                             Write(Model.пользователи.FirstOrDefault(t => t.user_id != IdUser).firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                                                                                                                    Write(Model.пользователи.FirstOrDefault(t => t.user_id != IdUser).secondname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 797, "\"", 873, 1);
#nullable restore
#line 13 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
WriteAttributeValue("", 805, Model.пользователи.FirstOrDefault(t => t.user_id != IdUser).user_id, 805, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"IdConvertant\" />\r\n        </div>\r\n        <div id=\"dialog\" class=\"row dialog\" style=\"overflow-y: scroll; scrollbar-width: none;\">\r\n            <div id=\"dialogwindow\" class=\"col-12\">\r\n");
#nullable restore
#line 17 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                 if (Model.сообщения.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p id=\"nomessages\">Вы пока не написали ни одного сообщения</p>\r\n");
#nullable restore
#line 20 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                     foreach (var item in Model.сообщения)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row d-block"" style=""border-bottom: 1px solid #e7e8ec"">
                            <div class=""col-12"">
                                <div class=""row"">
                                    <div class=""col-8"">
                                        <p style=""font-size: 12px; margin-bottom:0"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270a9da6f6e6e0c7082033a67e793c5a375d33446920", async() => {
#nullable restore
#line 30 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                                                                                                                                                                                  Write(Model.пользователи.FirstOrDefault(t => t.user_id == item.user_id).secondname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 30 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                                                                                                                                                                                                                                                                Write(Model.пользователи.FirstOrDefault(t => t.user_id == item.user_id).firstname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 30 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                                                                                                                                                                                                                                                                                                                                             Write(item.date_sent.ToShortTimeString());

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                                                                                                 WriteLiteral(Model.пользователи.FirstOrDefault(t=>t.user_id == item.user_id).user_id);

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
            WriteLiteral(@"
                                        </p>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12"">
                                        <p style=""font-size:12px"">");
#nullable restore
#line 36 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                                                             Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 41 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""row"" style=""height: 100px"">
            <div class=""col-10"">
                <textarea id=""messagetext"" style=""margin-top: 1rem;font-size:12px"" placeholder=""Напишите своё сообщение"" rows=""2"" class=""form-control""></textarea>
            </div><div class=""col-1"" style=""margin:0; padding:0"">
");
#nullable restore
#line 49 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                 if (Model.сообщения.FirstOrDefault() != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button style=\"font-size: 12px; margin-top: 1.5rem\"");
            BeginWriteAttribute("id", " id=\"", 3094, "\"", 3140, 1);
#nullable restore
#line 51 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
WriteAttributeValue("", 3099, Model.сообщения.FirstOrDefault().id_conv, 3099, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"sendMessage(this)\" type=\"submit\" class=\"btn btn-primary\">\r\n                        Отправить\r\n                    </button>\r\n");
#nullable restore
#line 54 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button style=\"font-size: 12px; margin-top: 1.5rem\"");
            BeginWriteAttribute("id", " id=\"", 3407, "\"", 3412, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"sendMessage(this)\" type=\"submit\" class=\"btn btn-primary\">\r\n                        Отправить\r\n                    </button>\r\n");
#nullable restore
#line 60 "C:\learning\hackaton\Views\Messages\Dialog.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        const hubConnection = new signalR.HubConnectionBuilder().withUrl(""/chat"").build();
        let conv_id = """";
        let idElem = """";
        hubConnection.on(""MessageSend"", function (response) {
            conv_id = response.conv_id;
            let div = document.getElementById(""dialogwindow"");
            if (document.getElementById('nomessages')) {
                document.getElementById('nomessages').parentNode.removeChild(document.getElementById('nomessages'));
            }
            let row = document.createElement(""div"");
            row.setAttribute('class', 'row d-block');
            row.setAttribute('style', 'border-bottom: 1px solid #e7e8ec');
            let col = document.createElement('div');
            col.setAttribute('class', 'col-12');
            let row2 = document.createElement('div');
            row2.setAttribute('class', 'row');
            let col2 = document.createElement('div');
            col2.setAttribute('class', 'col-8');
       ");
                WriteLiteral(@"     let p = document.createElement('p');
            p.setAttribute('style', 'font-size: 12px; margin-bottom:0');
            let ap = document.createElement('a');
            ap.setAttribute('href', '/Users/GetUserInfo' + response.user_send);
            ap.innerHTML = response.firstname + ' ' + response.secondname + ' ' + response.time;
            p.appendChild(ap);
            col2.appendChild(p);
            row2.appendChild(col2);
            col.appendChild(row2);
            let row3 = document.createElement('div');
            row3.setAttribute('class', 'row');
            let col3 = document.createElement('div');
            col3.setAttribute('class', 'col-12');
            let p2 = document.createElement('p');
            p2.setAttribute('style', 'font-size:12px');
            p2.innerHTML = response.text;
            col3.appendChild(p2);
            row3.appendChild(col3);
            col.appendChild(row3);
            row.appendChild(col);
            div.appendChild(row);
");
                WriteLiteral(@"            let dialog = document.getElementById(""dialog"");
            dialog.scrollTop = dialog.scrollHeight;
        });
        function sendMessage(element) {
            if (conv_id == """")
                conv_id = element.id;
            idElem = element.id;
            let text = document.getElementById('messagetext').value;
            let secondconvid = document.getElementById('IdConvertant').value;
            document.getElementById('messagetext').value = """";
            hubConnection.invoke(""SendMessage"", conv_id, text, secondconvid);
        }
        document.addEventListener(""DOMContentLoaded"", function (event) {
            /*let messageslist = document.getElementById(""messageslist"");
            //let newheight = document.documentElement.clientHeight - headheight - 50;
            messageslist.style.height = newheight + ""px"";
            let dialog = document.getElementById(""dialog"");
            let dialogheigth = newheight - 54 - 100;
            dialog.style.height = dia");
                WriteLiteral(@"logheigth + ""px"";
            dialog.scrollTop = dialog.scrollHeight;
            window.onresize = function () {
                newheight = document.documentElement.clientHeight - headheight - 50;
                messageslist.style.height = newheight + ""px"";
                dialogheigth = newheight - 54 - 100;
                dialog.style.height = dialogheigth + ""px"";
            }*/
        });
        document.addEventListener('keyup', function (event) {
            if (event.keyCode == 13) {
                let btn = event.target.parentNode.nextSibling.childNodes[1];
                btn.click();
            }
        });
        hubConnection.start();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hackaton.Models.MessagessWithUsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
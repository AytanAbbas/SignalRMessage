#pragma checksum "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71eb65346277c1e3d08a159bd47dd52a28fa128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messenger_Chat), @"mvc.1.0.view", @"/Views/Messenger/Chat.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\_ViewImports.cshtml"
using SignalRMessenger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\_ViewImports.cshtml"
using SignalRMessenger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\_ViewImports.cshtml"
using SignalRMessenger.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71eb65346277c1e3d08a159bd47dd52a28fa128", @"/Views/Messenger/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb01018ff129919a60d117e289f0cb58005e26b", @"/Views/_ViewImports.cshtml")]
    public class Views_Messenger_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml"
  
    ViewData["Title"] = "Chat";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-lg-12\">\n            <h1 class=\"mb-5\">Send message to ");
#nullable restore
#line 9 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml"
                                        Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        </div>\n        <hr />\n        <div class=\"col-lg-12\">\n            <div class=\"messageContainer mb-3\">\n");
#nullable restore
#line 14 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml"
                 foreach (var item in Model.Messages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p");
            BeginWriteAttribute("class", " class=\"", 408, "\"", 468, 1);
#nullable restore
#line 16 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 416, item.SenderId==Model.SenderId?"sender":"reciever", 416, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml"
                                                                               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 17 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>

        <div class=""col-lg-12"">
            <div class=""input-group mb-3"">
                <input type=""text"" class=""form-control"" id=""messengerInput"" placeholder=""Type message..."">
                <input hidden id=""recieverId""");
            BeginWriteAttribute("value", " value=\"", 922, "\"", 944, 1);
#nullable restore
#line 27 "C:\Users\HP\Desktop\Messenger\SignalRMessenger\SignalRMessenger\Views\Messenger\Chat.cshtml"
WriteAttributeValue("", 930, Model.User.Id, 930, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <button class=\"btn btn-outline-secondary\" type=\"button\" id=\"messengerButton\">Send</button>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591

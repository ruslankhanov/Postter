#pragma checksum "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098c4700f165ac2519f3d7c5e69283282e494350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Post), @"mvc.1.0.view", @"/Views/Shared/_Post.cshtml")]
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
#line 1 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/_ViewImports.cshtml"
using Postter.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/_ViewImports.cshtml"
using Postter.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098c4700f165ac2519f3d7c5e69283282e494350", @"/Views/Shared/_Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1799c87cb7b204290fa820558d766beccdab65c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Postter.Domain.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"postter-box postter-box-post\">\n    <div class=\"row m-0\">\n        <div class=\"col-2 pl-3 pt-3\" style=\"width: max-content; flex: 0;\">\n            <img class=\"avatar-img-sm\"");
            BeginWriteAttribute("src", "\n                 src=\"", 217, "\"", 264, 1);
#nullable restore
#line 7 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
WriteAttributeValue("", 240, Model.Author.Image_path, 240, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"No avatar\">\n        </div>\n        <div class=\"col-10 pl-0 pr-5 py-4\">\n            <span class=\"semi-bold-text\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "098c4700f165ac2519f3d7c5e69283282e4943504387", async() => {
#nullable restore
#line 10 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
                                                                                                                     Write(Model.Author.UserName);

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
#line 10 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
                                                                                            WriteLiteral(Model.Author.Id);

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
            WriteLiteral("</span><span class=\"secondary-text pl-2\">");
#nullable restore
#line 10 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
                                                                                                                                                                                        Write(Model.PostedTime.ToString("MM/dd/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            <p style=\"color: white\">");
#nullable restore
#line 11 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
                               Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 12 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
             if (Model.AttachmentPath != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"content-image\"");
            BeginWriteAttribute("src", "\n                     src=\"", 740, "\"", 788, 1);
#nullable restore
#line 15 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
WriteAttributeValue("", 767, Model.AttachmentPath, 767, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Cannot load image\">\n");
#nullable restore
#line 16 "/Users/ruslankhanov/Documents/IT/Postter/Postter.Presentation/Views/Shared/_Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row m-0 pt-4 d-flex justify-content-center"">
                <div class=""col-4 p-0"">
                    <button class=""postter-icon-button"" style=""color: var(--darkGray); font-size: 23px"">
                        <i class=""far fa-heart""></i>
                    </button>
                    <span class=""secondary-text"">11.2k</span>
                </div>
                <div class=""col-4 p-0"">
                    <button class=""postter-icon-button"" style=""color: var(--darkGray); font-size: 23px"">
                        <i class=""fas fa-retweet""></i>
                    </button>
                    <span class=""secondary-text"">11.2k</span>
                </div>
                <div class=""col-4 p-0"">
                    <button class=""postter-icon-button"" style=""color: var(--darkGray); font-size: 23px"">
                        <i class=""far fa-comment""></i>
                    </button>
                    <span class=""secondary-text"">11.2k</span>
                </div>
            ");
            WriteLiteral("</div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Postter.Domain.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591

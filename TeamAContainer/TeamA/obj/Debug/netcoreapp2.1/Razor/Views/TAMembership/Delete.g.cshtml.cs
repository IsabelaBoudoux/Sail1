#pragma checksum "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be1ad1d5a9c5ac0ec2d686372d1b12bef2ef4096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TAMembership_Delete), @"mvc.1.0.view", @"/Views/TAMembership/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TAMembership/Delete.cshtml", typeof(AspNetCore.Views_TAMembership_Delete))]
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
#line 1 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\_ViewImports.cshtml"
using TeamA;

#line default
#line hidden
#line 2 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\_ViewImports.cshtml"
using TeamA.Models;

#line default
#line hidden
#line 2 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1ad1d5a9c5ac0ec2d686372d1b12bef2ef4096", @"/Views/TAMembership/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68112c425da3e309616d641f8b9f409296408765", @"/Views/_ViewImports.cshtml")]
    public class Views_TAMembership_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamA.Models.Membership>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
  
    ViewData["Title"] = $"Delete {Model.Year} {@Context.Session.GetString("memberName")} Membership";

#line default
#line hidden
            BeginContext(178, 13, true);
            WriteLiteral("\r\n<h2>Delete ");
            EndContext();
            BeginContext(192, 39, false);
#line 8 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
      Write(Context.Session.GetString("memberName"));

#line default
#line hidden
            EndContext();
            BeginContext(231, 16, true);
            WriteLiteral(" Membership for ");
            EndContext();
            BeginContext(248, 10, false);
#line 8 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
                                                              Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(258, 197, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Are you sure you want to <span class=\"orange\">delete</span> this?</h3>\r\n<div>\r\n    <h4>Membership to delete</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(456, 40, false);
#line 16 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(496, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(540, 36, false);
#line 19 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(620, 39, false);
#line 22 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(659, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(703, 35, false);
#line 25 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fee));

#line default
#line hidden
            EndContext();
            BeginContext(738, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(782, 44, false);
#line 28 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(826, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(870, 40, false);
#line 31 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Comments));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(954, 40, false);
#line 34 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Paid));

#line default
#line hidden
            EndContext();
            BeginContext(994, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1038, 36, false);
#line 37 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Paid));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 51, true);
            WriteLiteral("\r\n        </dd>        \r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1126, 64, false);
#line 40 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MembershipTypeNameNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1234, 79, false);
#line 43 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MembershipTypeNameNavigation.MembershipTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1347, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1240a745178a4fffae8123aeb1680b66", async() => {
                BeginContext(1373, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1383, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0e1e948ade943de86e0845f8aadacbc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 48 "C:\Users\Isabela\Desktop\Isabela\TeamAContainer\TeamA\Views\TAMembership\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MembershipId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1429, 86, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn-lg btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1515, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d9cf01b2be474f95cae669bc49b283", async() => {
                    BeginContext(1537, 23, true);
                    WriteLiteral("Back to Membership List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1564, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1577, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamA.Models.Membership> Html { get; private set; }
    }
}
#pragma warning restore 1591

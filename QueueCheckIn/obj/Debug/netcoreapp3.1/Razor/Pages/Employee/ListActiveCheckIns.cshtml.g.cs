#pragma checksum "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cad674b957bbf63de4f608b65183cf1087e0d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QueueCheckIn.Pages.Employee.Pages_Employee_ListActiveCheckIns), @"mvc.1.0.razor-page", @"/Pages/Employee/ListActiveCheckIns.cshtml")]
namespace QueueCheckIn.Pages.Employee
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
#line 1 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\_ViewImports.cshtml"
using QueueCheckIn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\_ViewImports.cshtml"
using QueueCheckIns.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cad674b957bbf63de4f608b65183cf1087e0d10", @"/Pages/Employee/ListActiveCheckIns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d87a259911a4e9b6470292ada62e9cb05902b21", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employee_ListActiveCheckIns : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/CheckIns/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/CheckIns/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
Write(await Component.InvokeAsync("WaitCount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Currently Active Check Ins</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Check-In ID
            </th>
            <th>
                Name
            </th>
            <th>
                Email Address
            </th>
            <th>
                Arrival Date
            </th>
            <th>
                Arrival Time
            </th>
            <th>
                Booking Type
            </th>
            <th>
                Status
            </th>
");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n\r\n");
#nullable restore
#line 41 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
         foreach (var checkin in Model.CheckIns)
        {
            if (checkin.Status != Status.WithBarber)

            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <h5>");
#nullable restore
#line 48 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                       Write(checkin.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </td>\r\n                    <td>\r\n                        <h5>");
#nullable restore
#line 51 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                       Write(checkin.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <h5>");
#nullable restore
#line 55 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                       Write(checkin.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <h5>");
#nullable restore
#line 59 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                       Write(checkin.CheckInDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <h5>");
#nullable restore
#line 63 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                       Write(checkin.CheckInTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </td>\r\n                    <td>\r\n                        <h5>");
#nullable restore
#line 66 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                       Write(checkin.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <h5>");
#nullable restore
#line 70 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                       Write(checkin.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </td>\r\n");
            WriteLiteral("\r\n                    <td>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cad674b957bbf63de4f608b65183cf1087e0d109014", async() => {
                WriteLiteral("Change Status");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                                                       WriteLiteral(checkin.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cad674b957bbf63de4f608b65183cf1087e0d1011361", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
                                                         WriteLiteral(checkin.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Employee\ListActiveCheckIns.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QueueCheckIn.Pages.Employee.ListActiveCheckInsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QueueCheckIn.Pages.Employee.ListActiveCheckInsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QueueCheckIn.Pages.Employee.ListActiveCheckInsModel>)PageContext?.ViewData;
        public QueueCheckIn.Pages.Employee.ListActiveCheckInsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

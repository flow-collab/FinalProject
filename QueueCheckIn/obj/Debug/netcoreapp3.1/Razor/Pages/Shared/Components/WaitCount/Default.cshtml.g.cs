#pragma checksum "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0822986c9d0e4902d4c5db6959e8188cb821e40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QueueCheckIn.Pages.Shared.Components.WaitCount.Pages_Shared_Components_WaitCount_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/WaitCount/Default.cshtml")]
namespace QueueCheckIn.Pages.Shared.Components.WaitCount
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0822986c9d0e4902d4c5db6959e8188cb821e40", @"/Pages/Shared/Components/WaitCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d87a259911a4e9b6470292ada62e9cb05902b21", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_WaitCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QueueCount>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0822986c9d0e4902d4c5db6959e8188cb821e403442", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
         foreach (var queueWaiting in Model)
        {
            //if(queueWaiting.Status == Status.Waiting)
            if (@queueWaiting.Count == 1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"lead bg-light\">\r\n                        There is currently ");
#nullable restore
#line 12 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
                                      Write(queueWaiting.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("  person ");
#nullable restore
#line 12 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
                                                                  Write(queueWaiting.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" in the queue.\r\n                </p>\r\n");
#nullable restore
#line 14 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
            }
            else if (queueWaiting.Count > 1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"lead bg-light\">\r\n\r\n                        There are currently ");
#nullable restore
#line 19 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
                                       Write(queueWaiting.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("  people ");
#nullable restore
#line 19 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
                                                                   Write(queueWaiting.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" in the queue.\r\n                </p>\r\n");
#nullable restore
#line 21 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"lead bg-light\">\r\n                        You are the next person in the queue. Your estimated wait time should be less than 15 minutes.\r\n                </p>\r\n");
#nullable restore
#line 27 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Mum's Laptop\Documents\Higher Diploma Cloud and Web Tech\CapStone\10522200_CapStone\QueueCheckIn\Pages\Shared\Components\WaitCount\Default.cshtml"
         

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QueueCount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
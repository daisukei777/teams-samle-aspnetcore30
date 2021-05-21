#pragma checksum "C:\Users\daisukei\source\repos\microsoft-teams-sample-tabs\channelGroupTab\Pages\tab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff59097a532d6c0180e61f8ef982a7cc951141fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_tab), @"mvc.1.0.razor-page", @"/Pages/tab.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/tab.cshtml", typeof(AspNetCore.Pages_tab), @"/tab")]
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
#line 3 "C:\Users\daisukei\source\repos\microsoft-teams-sample-tabs\channelGroupTab\Pages\tab.cshtml"
using ChannelGroupTab;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/tab")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff59097a532d6c0180e61f8ef982a7cc951141fd", @"/Pages/tab.cshtml")]
    public class Pages_tab : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\daisukei\source\repos\microsoft-teams-sample-tabs\channelGroupTab\Pages\tab.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(74, 1069, true);
            WriteLiteral(@"
<script>
    //initialize microsoftTeams in _Layout page
    microsoftTeams.initialize();

    let saveGray = () => {
        microsoftTeams.settings.registerOnSaveHandler((saveEvent) => {
            microsoftTeams.settings.setSettings({
                websiteUrl: ""https://163f61514b15.ngrok.io"",
                contentUrl: ""https://163f61514b15.ngrok.io/gray"",
                entityId: ""grayIconTab"",
                suggestedDisplayName: ""MyNewTab"",
                removeUrl: """"
            });
            saveEvent.notifySuccess();
        });
    }
    let saveRed = () => {
        microsoftTeams.settings.registerOnSaveHandler((saveEvent) => {
            microsoftTeams.settings.setSettings({
                websiteUrl: ""https://163f61514b15.ngrok.io"",
                contentUrl: ""https://163f61514b15.ngrok.io/red"",
                entityId: ""redIconTab"",
                suggestedDisplayName: ""MyNewTab"",
                removeUrl: """"
            });
            saveEvent.notify");
            WriteLiteral("Success();\r\n        });\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1147, 152, true);
            WriteLiteral("    <section style=\"width: 100%; display: table\">\r\n        <div style=\"display:table-row\">\r\n            <div style=\"width: auto; display:table-cell;\">\r\n");
            EndContext();
#line 43 "C:\Users\daisukei\source\repos\microsoft-teams-sample-tabs\channelGroupTab\Pages\tab.cshtml"
                   Tab gray = new Tab();
                    string g = ($"{@gray.GetColor()} gray!'");

#line default
#line hidden
            BeginContext(1405, 57, true);
            WriteLiteral("                    <div id=\"gray\" style=\"display:none;\">");
            EndContext();
            BeginContext(1463, 1, false);
#line 45 "C:\Users\daisukei\source\repos\microsoft-teams-sample-tabs\channelGroupTab\Pages\tab.cshtml"
                                                    Write(g);

#line default
#line hidden
            EndContext();
            BeginContext(1464, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(1491, 69, true);
            WriteLiteral("            </div>\r\n\r\n            <div style=\"display: table-cell\">\r\n");
            EndContext();
#line 50 "C:\Users\daisukei\source\repos\microsoft-teams-sample-tabs\channelGroupTab\Pages\tab.cshtml"
                   Tab red = new Tab();
                    string r = ($"{@red.GetColor()} red!'");

#line default
#line hidden
            BeginContext(1663, 56, true);
            WriteLiteral("                    <div id=\"red\" style=\"display:none;\">");
            EndContext();
            BeginContext(1720, 1, false);
#line 52 "C:\Users\daisukei\source\repos\microsoft-teams-sample-tabs\channelGroupTab\Pages\tab.cshtml"
                                                   Write(r);

#line default
#line hidden
            EndContext();
            BeginContext(1721, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(1748, 56, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n");
            EndContext();
            BeginContext(1807, 1100, true);
            WriteLiteral(@"
<script>
    let gr = document.getElementById(""gray"").style;
    let rd = document.getElementById(""red"").style;
    let dis = document.getElementsByClassName(""disappear"").style;

    const colorClickGray = () => {
        gr.display = ""block"";
        rd.display = ""none"";
        microsoftTeams.settings.setValidityState(true);
        $("".disappear"").remove();
        saveGray()
    }

    const colorClickRed = () => {
        rd.display = ""block"";
        gr.display = ""none"";
        microsoftTeams.settings.setValidityState(true);
        $("".disappear"").remove();
        saveRed();
    }
</script>

<p>
    <h2 class=""disappear"" style=""color:#6364a5"">Configure your tab:</h2>
    <br />
    <br />
</p>

<button class=""disappear"" onclick=""(document.getElementById('icon').src = '/images/iconGray.png'); colorClickGray()"">Select Gray</button>

<img id=""icon"" src=""/images/teamsIcon.png"" alt=""icon"" style=""width:100px"" />

<button class=""disappear"" onclick=""(document.getElementById(");
            WriteLiteral("\'icon\').src = \'/images/iconRed.png\'); colorClickRed()\">Select Red</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_tab> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_tab> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_tab>)PageContext?.ViewData;
        public Pages_tab Model => ViewData.Model;
    }
}
#pragma warning restore 1591

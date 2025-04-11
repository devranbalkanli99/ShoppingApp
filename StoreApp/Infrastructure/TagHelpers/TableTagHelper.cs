using Microsoft.AspNetCore.Razor.TagHelpers;

namespace StoreApp.Infrastructure.TagHelpers
{
    [HtmlTargetElement("table")]
    // bu tag helper class'ının hedefinde table html etiketi var demek bu kod.
    public class TableTagHelper : TagHelper
    // TagHelper class olması için .net'ten TagHelper'ın kalıtılması lazım.
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "table table-hover table-bordered");
            // tabloların hepsine bootstrap'teki tablo olsun dedik.
        }
    }

}
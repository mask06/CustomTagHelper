using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelperUI.MyCustomTagHelper
{
[HtmlTargetElement("selam")]
    public class SelamTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Attributes.SetAttribute("style", "color:green;");
            output.Content.SetContent("Merhaba ! Hoşgeldiniz");
        }
    }
}

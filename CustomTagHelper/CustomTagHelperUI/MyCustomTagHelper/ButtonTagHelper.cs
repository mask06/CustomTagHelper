using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelperUI.MyCustomTagHelper
{
    [HtmlTargetElement("ButtonOzel")]
    public class ButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "Button";
            output.Attributes.SetAttribute("style","color: aqua;");
            output.Content.SetContent("Selam bu buton");
        }
    }
}

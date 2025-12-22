using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppMVCprejoinerB2.Models
{
    [HtmlTargetElement("my-button")]
    public class MyButtons : TagHelper
    {
        public string Text { get; set; }
        public string Color { get; set; } = "primary"; // primary, success, danger
        public string Type { get; set; } = "button";   // button, submit, reset
        public string Icon { get; set; }                // optional icon

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;

            output.Attributes.SetAttribute("type", Type);
            output.Attributes.SetAttribute("class", $"btn btn-{Color}");

            if (!string.IsNullOrEmpty(Icon))
            {
                output.Content.SetHtmlContent(
                    $"<i class='{Icon}'></i> {Text}"
                );
            }
            else
            {
                output.Content.SetContent(Text);
            }
        }
    }
}
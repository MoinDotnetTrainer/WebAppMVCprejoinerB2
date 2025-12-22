using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebAppMVCprejoinerB2.Models
{
    [HtmlTargetElement("MyHeading")]
    public class Heading :TagHelper
    {
        public string Name { get; set; } 
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // headeing tag
            output.TagName = "h3";

            output.Content.SetContent($"Welcome :{Name}");
        }

        //public override void Process(TagHelperContext context, TagHelperOutput output)
        //{
        //    output.TagName = "span";
        //    output.Attributes.SetAttribute("style", "background-color:yellow");
        //}
    }
}

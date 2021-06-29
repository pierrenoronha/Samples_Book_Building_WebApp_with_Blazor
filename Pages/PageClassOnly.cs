namespace test_Blazor_ebook1.Pages
{
    using System;
    using test_Blazor_ebook1.Shared;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Rendering;
    using Microsoft.AspNetCore.Components.RenderTree;

    [Route("/pageclassonly")]
    [Layout(typeof(MainLayout))]
    public class PageClassOnly : ComponentBase
    {
        public String Text { get; set; } = "Page dinamically created with Class Only. PageClassOnly.cs";

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            //base.BuildRenderTree(builder);

            builder.OpenElement(1, "h2");
            builder.AddContent(2, "Page with class only");
            builder.CloseElement();

            builder.OpenElement(3, "h5");
            builder.AddContent(4, Text);
            builder.CloseElement();


        }
    }
}

using Microsoft.AspNetCore.Components;
using System;

namespace test_Blazor_ebook1.Pages
{
    public partial class PageWithCodeBehindPartialClass : ComponentBase
    {
        public String Text { get; set; } = "Page With Code Behind Partial Class. Html content is on PageWithCodeBehindPartialClass.razor and code behinde is on PageWithCodeBehindPartialClass.cs";
    }
}

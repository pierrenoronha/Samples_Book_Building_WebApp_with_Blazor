using Microsoft.AspNetCore.Components;
using System;

namespace test_Blazor_ebook1.Pages.CodeBehind
{
    public class PageWithCodeBehindUsingDifferentClass : ComponentBase
    {
        public String Text { get; set; } = "Page With Code Behind Using Different Class. Html is on PageWithCodeBehindDifferentClass.razor and code behind is on PageWithCodeBehindUsingDifferentClass.cs";
    }
}

using Microsoft.AspNetCore.Components;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace test_Blazor_ebook1.Pages.Components
{
    public partial class ComponentCascadeParameter : ComponentBase
    {
        [CascadingParameter]
        public string Title { get; set; } = "Cascading Parameter. ComponentLifeCicle.cs";
        
        private string _className = nameof(ComponentCascadeParameter);

        protected override void OnInitialized()
        {
            Console.WriteLine($"{_className}.{nameof(OnInitialized)}()");
        }

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine($"{_className}.{nameof(OnInitializedAsync)}()");
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine($"{_className}.{nameof(OnParametersSet)}()");
        }

        protected override async Task OnParametersSetAsync()
        {
            Console.WriteLine($"{_className}.{nameof(OnParametersSetAsync)}()");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine($"{_className}.{nameof(OnAfterRender)}(firstRender = {firstRender})");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Console.WriteLine($"{_className}.{nameof(OnAfterRenderAsync)}(firstRender = {firstRender})");
        }

        public override async Task SetParametersAsync(ParameterView parameters)
        {
            Console.WriteLine($"{_className}.{nameof(SetParametersAsync)}(parameters = {parameters.ToString()})");

            //Write your code to modify Parameters        
            await base.SetParametersAsync(parameters);
        }

        public void Dispose()
        {
            Console.WriteLine($"{_className}.{nameof(Dispose)}())");
        }

    }
}

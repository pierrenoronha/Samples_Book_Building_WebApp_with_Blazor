using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace test_Blazor_ebook1.Pages.Components
{
    public partial class ComponentSettingAttributes : ComponentBase
    {
        [Parameter]
        public Dictionary<string, object> MyAttributes0 { get; set; } = new Dictionary<string, object>()
        {
            {"MaxLength", "10"},
            {"PlaceHolder", "Digite o seu nome aqui"},
            {"required", "required"},
            {"size", "40"}
        };

        [Parameter]
        public IReadOnlyDictionary<string, object> MyAttributes1 { get; set; } = new Dictionary<string, object>()
        {
            {"MaxLength", "10"},
            {"PlaceHolder", "Digite o seu nome aqui"},
            {"required", "required"},
            {"size", "40"}
        };
        
        [Parameter]
        public IEnumerable<KeyValuePair<string, object>> MyAttributes2 { get; set; } = new List<KeyValuePair<string, object>>()
        {
            new KeyValuePair<string, object>("MaxLength", "10"),
            new KeyValuePair<string, object>("PlaceHolder", "Digite o seu nome aqui"),
            new KeyValuePair<string, object>("required", "required"),
            new KeyValuePair<string, object>("size", "40"),
        };
    }
}

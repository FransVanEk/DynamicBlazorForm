using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class FormLabel : ComponentBase
    {
        [Parameter]
        public Item Item { get; set; }
    }
}

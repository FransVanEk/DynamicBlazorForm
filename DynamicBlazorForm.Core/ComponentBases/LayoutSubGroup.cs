using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class LayoutSubGroup : ComponentBase
    {
        [Parameter] 
        public SubGroup SubGroup { get; set; }

        [Parameter]
        public DataConnection DataConnection { get; set; } = new DataConnection();

        [Inject]
        public DynamicElementsRepository ElementRepository { get; set; }

        public Type CellType { get; private set; } = typeof(LayoutElement);

        protected override async Task OnInitializedAsync()
        {
            CellType = ElementRepository.CellTypeData.Type;
        }

        public Dictionary<string, object> GetParameters(Item item)
        {
            var result = new Dictionary<string, object>
            {
                { "Item", item },
                { "DataConnection", DataConnection }
            };
            return result;
        }
    }
}

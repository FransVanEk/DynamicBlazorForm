using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class LayoutGroup : ComponentBase
    {
        [Parameter]
        public Group Group { get; set; }

        [Parameter]
        public DataConnection DataConnection { get; set; } = new DataConnection();

        public Type RowType { get; private set; } = typeof(LayoutSubGroup);

        [Inject]
        public DynamicElementsRepository ElementRepository { get; set; }

        protected override async Task OnInitializedAsync()
        {
            RowType = ElementRepository.RowTypeData.Type;
        }

        public Dictionary<string, object> GetParameters(SubGroup subGroup)
        {
            var result = new Dictionary<string, object>();
            result.Add("SubGroup", subGroup);
            result.Add("DataConnection", DataConnection);
            return result;
        }
    }
}

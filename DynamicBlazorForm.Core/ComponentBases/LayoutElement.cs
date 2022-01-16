using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class LayoutElement : ComponentBase
    {
        [Parameter]
        public Item Item { get; set; }

        [Parameter]
        public DataConnection DataConnection { get; set; } = new DataConnection();

        [Inject]
        public DynamicElementsRepository ElementRepository { get; set; }

        public Dictionary<string, object> GetParameters()
        {
            var result = new Dictionary<string, object>();
            result.Add("Item", Item);
            result.Add("DataConnection", DataConnection);
            return result.GetFilteredParameters(ElementRepository[Item.TypeName].Parameters);
        }

        public Dictionary<string, object> GetParameters(Group group)
        {
            var result = new Dictionary<string, object>();
            result.Add("DataConnection", DataConnection);
            result.Add("Group", group);
            return result;
        }
    }
}

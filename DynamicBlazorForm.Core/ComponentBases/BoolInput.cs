using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class BoolInput: ComponentBase
    {
        [Parameter]
        public DataConnection DataConnection { get; set; } = new DataConnection();

        [Parameter]
        public Item Item { get; set; }

        public bool Value
        {
            get
            {
                if (!DataConnection.ContainsKey(Item.Path)) { return false; }
                return (bool)DataConnection[Item.Path];
            }
            set
            {
                DataConnection.Upsert(Item.Path, value);
            }
        }

    }
}

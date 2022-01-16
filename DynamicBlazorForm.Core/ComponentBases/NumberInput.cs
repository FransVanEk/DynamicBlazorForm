using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class NumberInput : ComponentBase
    {
        [Parameter]
        public DataConnection DataConnection { get; set; } = new DataConnection();

        [Parameter]
        public Item Item { get; set; }

        public long Value
        {
            get
            {

                if (!DataConnection.ContainsKey(Item.Path)) { return 0; }
                var result= DataConnection[Item.Path];
                return (long)result;
            }
            set
            {
                DataConnection.Upsert(Item.Path, value);
            }
        }
    }
}

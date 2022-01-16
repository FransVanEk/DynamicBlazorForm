using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class DateInput: ComponentBase
    {
        [Parameter]
        public DataConnection DataConnection { get; set; } = new DataConnection();

        [Parameter]
        public Item Item { get; set; }

        public DateTime Value
        {
            get
            {

                if (!DataConnection.ContainsKey(Item.Path)) { return new DateTime(); }
                return (DateTime)DataConnection[Item.Path];
            }
            set
            {
                DataConnection.Upsert(Item.Path, value);
            }
        }

    }
}

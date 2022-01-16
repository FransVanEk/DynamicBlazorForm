using DynamicBlazorForm.Core.Layout;
using Microsoft.AspNetCore.Components;

namespace DynamicBlazorForm.Core.ComponentBases
{
    public class TextInput :ComponentBase
    {
        [Parameter]
        public DataConnection DataConnection { get; set; } = new DataConnection();

        [Parameter]
        public Item Item { get; set; }

        public string Value
        {
            get
            {
                if (!DataConnection.ContainsKey(Item.Path)) { return string.Empty; }
                return DataConnection[Item.Path]?.ToString();
            }
            set { DataConnection.Upsert(Item.Path, value); }
        }
    }
}

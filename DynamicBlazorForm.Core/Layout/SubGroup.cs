using Newtonsoft.Json;

namespace DynamicBlazorForm.Core.Layout
{
    public class SubGroup
    {
        public SubGroup()
        {

        }
        public SubGroup(int index)
        {
            Index = index;
        }

        public static SubGroup AtIndex(int index)
        {
           return new SubGroup(index);
        }

        [JsonProperty("index")]
        public int Index { get; set; }
        [JsonProperty("items")]
        public List<Item> Items { get; set; } = new List<Item>();
    }
}

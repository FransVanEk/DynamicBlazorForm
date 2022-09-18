using Newtonsoft.Json;

namespace DynamicBlazorForm.Core.Layout
{
    public class Item
    {
        public Item()
        {

        }
        public Item(int index, string path, string labelText, string typeName, int span, string? layoutHint)
        {
            Index = index;
            Path = path;
            LabelText = labelText;
            TypeName = typeName;
            Span = span;
            LayoutHint = layoutHint;
        }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("span")]
        public int Span { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; } = string.Empty;

        [JsonProperty("typeName")]
        public string TypeName { get; set; } = string.Empty;

        [JsonProperty("layoutHint")]
        public string? LayoutHint { get; set; } = string.Empty;

        [JsonProperty("text")]
        public string LabelText { get; set; } = string.Empty;

        [JsonProperty("groups")]
        public List<Group> Groups { get; set; } = new List<Group> { };

        [JsonProperty("customData")]
        public Dictionary<string,object> CustomData { get; set; } = new Dictionary<string, object>();

    }
}

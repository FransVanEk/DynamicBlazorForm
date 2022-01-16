using Newtonsoft.Json;

namespace DynamicBlazorForm.Core.Layout
{

    public class DynamicLayout
    {
        public DynamicLayout(string title)
        {
            Title = title;
        }

        [JsonProperty("groups")]
        public List<Group> Groups { get; set; } = new List<Group>();

        [JsonProperty("title")]
        public string Title { get; }
    }
}

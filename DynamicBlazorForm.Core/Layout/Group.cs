using Newtonsoft.Json;

namespace DynamicBlazorForm.Core.Layout
{
    public class Group
    {
        public Group()
        {
            Name = "not set";
        }

        public Group(string name)
        {
            Name = name;
        }

        public static Group WithName(string name)
        {
            return new Group(name);
        }
        public static Group WithName(string name,string? layoutHint)
        {
            return new Group(name) { LayoutHint = layoutHint };
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("layoutHint")]
        public string? LayoutHint { get; set; } = "";

        [JsonProperty("subGroups")]
        public List<SubGroup> SubGroups { get; set; } = new List<SubGroup>();
    }
}

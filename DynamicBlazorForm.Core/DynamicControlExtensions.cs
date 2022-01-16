namespace DynamicBlazorForm.Core
{
    public static class DynamicControlExtensions
    {
        public static Dictionary<string, object> GetFilteredParameters(this Dictionary<string, object> source, List<string> parameters)
        {
            var result = new Dictionary<string, object>();
            source.ToList().ForEach(p =>
            {
                if (parameters.Contains(p.Key))
                {
                    result.Add(p.Key, p.Value);
                }
            });
            return result;
        }
    }
}

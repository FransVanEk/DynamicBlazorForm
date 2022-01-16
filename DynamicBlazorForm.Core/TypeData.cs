namespace DynamicBlazorForm.Core
{
    public class TypeData
    {
        public TypeData(Type type, IEnumerable<string> parameters)
        {
            Type = type;
            Parameters = parameters.ToList();
        }
        public Type Type { get;  }

        public List<string> Parameters { get;  }

    }
}

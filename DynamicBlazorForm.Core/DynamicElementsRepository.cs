namespace DynamicBlazorForm.Core
{
    public class DynamicElementsRepository
    {
        public const string GroupTypeName = "group";
        public const string RowTypeName = "row";
        public const string CellTypeName = "cell";
        public const string DefaultTypeName = "_default_";


        private readonly Dictionary<string, TypeData> items = new Dictionary<string, TypeData>();

        public DynamicElementsRepository Add(string key, Type type)
        {
            items.Add(key, GetTypeData(type));
            return this;
        }

        private TypeData GetTypeData(Type type)
        {
            return new TypeData(type, GetParameterNames(type));
        }

        private static IEnumerable<string> GetParameterNames(Type type)
        {
            return type.GetProperties().Where(prop => prop.IsDefined(typeof(Microsoft.AspNetCore.Components.ParameterAttribute), false)).Select(p => p.Name);
        }

        public static DynamicElementsRepository GetDefaultSettings(Type defaultType, Type groupType, Type rowType , Type cellType )
        {
            var result = new DynamicElementsRepository();

            result.Add(DefaultTypeName, defaultType);
            result.Add(GroupTypeName, groupType);
            result.Add(RowTypeName, rowType);
            result.Add(CellTypeName, cellType);

            return result;
        }

        public TypeData this[string index]
        {
            get
            {
                if (items.ContainsKey(index))
                    return items[index];

                return items[DefaultTypeName];
            }
        }

        public TypeData GroupTypeData => items[GroupTypeName];
        public TypeData RowTypeData => items[RowTypeName];
        public TypeData CellTypeData => items[CellTypeName];
        public TypeData DefaultTypeData => items[DefaultTypeName];
    }
}

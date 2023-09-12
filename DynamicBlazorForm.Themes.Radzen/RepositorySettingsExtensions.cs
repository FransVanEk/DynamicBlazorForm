using DynamicBlazorForm.Core;

namespace DynamicBlazorForm.Themes.RadzenForm
{
    public static class RepositorySettingsExtensions
    {
        public static DynamicElementsRepository GetRadzenDefaultSettings(this DynamicElementsRepository source)
        {
            source.Add(DynamicElementsRepository.DefaultTypeName, typeof(FormLabel));
            source.Add(DynamicElementsRepository.GroupTypeName, typeof(LayoutGroup));
            source.Add(DynamicElementsRepository.RowTypeName, typeof(LayoutRow));
            source.Add(DynamicElementsRepository.CellTypeName, typeof(LayoutCell));

            return source;
        }
        public static DynamicElementsRepository GetRadzenDefaultFormElements(this DynamicElementsRepository source)
        {

            source.Add("TextInput", typeof(TextInput));
            source.Add("NumberInput", typeof(NumberInput));
            source.Add("BoolInput", typeof(BoolInput));
            source.Add("DateInput", typeof(DateInput));
            return source;
        }

    }
}

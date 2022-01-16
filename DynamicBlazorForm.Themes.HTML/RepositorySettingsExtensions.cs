using DynamicBlazorForm.Core;

namespace DynamicBlazorForm.Themes.HTML
{
    public static class RepositorySettingsExtensions
    {
        public static DynamicElementsRepository GetHTMLDefaultSettings(this DynamicElementsRepository source)
        {
            source.Add(DynamicElementsRepository.DefaultTypeName, typeof(FormLabel));
            source.Add(DynamicElementsRepository.GroupTypeName, typeof(LayoutGroup));
            source.Add(DynamicElementsRepository.RowTypeName, typeof(LayoutRow));
            source.Add(DynamicElementsRepository.CellTypeName, typeof(LayoutCell));

            return source;
        }
    }
}

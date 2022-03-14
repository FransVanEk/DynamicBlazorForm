using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBlazorForm.Core.Layout.FluentApi
{
    public static class Extensions
    {
        public static DynamicLayout WithGroup(this DynamicLayout dynamicLayout, Group group)
        {
            dynamicLayout.Groups.Add(group);
            return dynamicLayout;
        }
     
        public static Group WithSubGroup(this Group group, SubGroup subGroup)
        {
            group.SubGroups.Add(subGroup);
            return group;
        }

        public static SubGroup WithItem(this SubGroup subGroup, Item item)
        {
            subGroup.Items.Add(item);
            return subGroup;
        }

        public static SubGroup WithItem(this SubGroup subGroup, int index, string path, string labelText, string typeName, int span)
        {
            return subGroup.WithItem(new Item(index, path, labelText, typeName, span, string.Empty));
        }

        public static SubGroup WithItem(this SubGroup subGroup, int index, string path, string labelText, string typeName, int span, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index,path,labelText,typeName,span,layoutHint));
            return subGroup;
        }

        public static SubGroup WithDateInput(this SubGroup subGroup, int index, string path, string labelText, int span, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "DateInput", span, layoutHint));
            return subGroup;
        }

        public static SubGroup WithDateInput(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            return subGroup.WithDateInput(index, path, labelText, span, string.Empty);
        }

        public static SubGroup WithNumberInput(this SubGroup subGroup, int index, string path, string labelText, int span, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "NumberInput", span,layoutHint));
            return subGroup;
        }

        public static SubGroup WithNumberInput(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            return subGroup.WithNumberInput(index, path, labelText,  span, string.Empty);
           
        }

        public static SubGroup WithTextInput(this SubGroup subGroup, int index, string path, string labelText, int span, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "TextInput", span,layoutHint));
            return subGroup;
        }

        public static SubGroup WithTextInput(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            return subGroup.WithTextInput(index, path, labelText, span, string.Empty);
        }

        public static SubGroup WithLabel(this SubGroup subGroup, int index, string path, string labelText, int span, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "TextLabel", span,layoutHint));
            return subGroup;
        }

        public static SubGroup WithLabel(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            subGroup.WithLabel(index, path, labelText, span, string.Empty);
            return subGroup;
        }

        
    }
}

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

        public static SubGroup WithItem(this SubGroup subGroup, int index, string path, string labelText, string typeName)
        {
            return subGroup.WithItem(new Item(index, path, labelText, typeName, string.Empty));
        }

        public static SubGroup WithItem(this SubGroup subGroup, int index, string path, string labelText, string typeName, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, typeName, layoutHint));
            return subGroup;
        }

        public static SubGroup WithDateInput(this SubGroup subGroup, int index, string path, string labelText, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "DateInput", layoutHint));
            return subGroup;
        }

        public static SubGroup WithDateInput(this SubGroup subGroup, int index, string path, string labelText)
        {
            return subGroup.WithDateInput(index, path, labelText, string.Empty);
        }

        public static SubGroup WithNumberInput(this SubGroup subGroup, int index, string path, string labelText, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "NumberInput", layoutHint));
            return subGroup;
        }

        public static SubGroup WithNumberInput(this SubGroup subGroup, int index, string path, string labelText)
        {
            return subGroup.WithNumberInput(index, path, labelText, string.Empty);
        }

        public static SubGroup WithBooleanInput(this SubGroup subGroup, int index, string path, string labelText, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "BoolInput", layoutHint));
            return subGroup;
        }

        public static SubGroup WithBooleanInput(this SubGroup subGroup, int index, string path, string labelText)
        {
            return subGroup.WithBooleanInput(index, path, labelText, string.Empty);
        }


        public static SubGroup WithTextInput(this SubGroup subGroup, int index, string path, string labelText, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "TextInput", layoutHint));
            return subGroup;
        }

        public static SubGroup WithTextInput(this SubGroup subGroup, int index, string path, string labelText)
        {
            return subGroup.WithTextInput(index, path, labelText, string.Empty);
        }

        public static SubGroup WithLabel(this SubGroup subGroup, int index, string path, string labelText, string? layoutHint)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "TextLabel", layoutHint));
            return subGroup;
        }

        public static SubGroup WithLabel(this SubGroup subGroup, int index, string path, string labelText)
        {
            subGroup.WithLabel(index, path, labelText, string.Empty);
            return subGroup;
        }

        public static SubGroup With(this SubGroup subGroup, int index, string path, string labelText)
        {
            subGroup.WithLabel(index, path, labelText, string.Empty);
            return subGroup;
        }


    }
}

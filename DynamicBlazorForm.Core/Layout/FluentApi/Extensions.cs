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
            subGroup.Items.Add(new Item(index,path,labelText,typeName,span));
            return subGroup;
        }

        public static SubGroup WithDateInput(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "DateInput", span));
            return subGroup;
        }

        public static SubGroup WithNumberInput(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "NumberInput", span));
            return subGroup;
        }

        public static SubGroup WithTextInput(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "TextInput", span));
            return subGroup;
        }
        public static SubGroup WithLabel(this SubGroup subGroup, int index, string path, string labelText, int span)
        {
            subGroup.Items.Add(new Item(index, path, labelText, "TextLabel", span));
            return subGroup;
        }

        
    }
}

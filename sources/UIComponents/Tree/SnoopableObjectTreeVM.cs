﻿using System.Collections.ObjectModel;
using System.Linq;
using RevitDBExplorer.Domain.DataModel;
using RevitDBExplorer.Domain.Presentation;

// (c) Revit Database Explorer https://github.com/NeVeSpl/RevitDBExplorer/blob/main/license.md

namespace RevitDBExplorer.UIComponents.Tree
{
    internal class SnoopableObjectTreeVM : TreeViewItemVM
    {
        public SnoopableObject Object { get; }     
        public string Prefix
        {
            get
            {
                if (Object.Index != -1)
                {
                    return $"[{Object.Index}]";
                }
                if (!string.IsNullOrEmpty(Object.NamePrefix))
                {
                    return Object.NamePrefix;
                }
                return  "";
            }
        }            
        


        public SnoopableObjectTreeVM(SnoopableObject @object)
        {
            Object = @object;
            if (@object.Items?.Any() == true)
            {
                Items = new ObservableCollection<TreeViewItemVM>(@object.Items.Select(x => new SnoopableObjectTreeVM(x)));
            }
        }
    }
}
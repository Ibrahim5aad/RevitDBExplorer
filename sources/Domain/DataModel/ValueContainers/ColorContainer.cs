﻿// (c) Revit Database Explorer https://github.com/NeVeSpl/RevitDBExplorer/blob/main/license.md

namespace RevitDBExplorer.Domain.DataModel.ValueContainers
{
    internal sealed class ColorContainer : Base.ValueContainer<Autodesk.Revit.DB.Color>
    {
        protected override bool CanBeSnoooped(Autodesk.Revit.DB.Color color) => false;
        protected override string ToLabel(Autodesk.Revit.DB.Color color)
        {
            return color.IsValid
            ? $"R: {color.Red}; G: {color.Green}; B: {color.Blue}"
            : "<invalid color value>";
        }
    }
}
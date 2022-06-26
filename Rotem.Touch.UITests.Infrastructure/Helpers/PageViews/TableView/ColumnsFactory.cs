using System;
using System.Collections.Generic;
using System.Data;
using Rotem.Touch.UITests.Infrastructure.Helpers.Enums;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView
{
    public class ColumnsFactory
    {
        private static readonly Dictionary<FieldType, Type> ColumnsTypes = new Dictionary<FieldType, Type>()
        {
            {FieldType.FT_Text, typeof(TextColumn)},
            {FieldType.FT_ToggleBtn, typeof(OnOffButtonColumn)},
            {FieldType.FT_Time, typeof(TimeColumn)},
            {FieldType.FT_OnOffToggleBtn, typeof(OnOffButtonColumn)},
            {FieldType.FT_Date, typeof(DateColumn)},
            {FieldType.FT_Checkbox, typeof(CheckBoxColumn)},
            {FieldType.FT_CheckBox, typeof(CheckBoxColumn)},
            {FieldType.FT_TextWithTopImageByRowIndex, typeof(TextWithImageColumn)},
            {FieldType.FT_TreeState, typeof(ButtonsGroupColumn)},
            {FieldType.FT_CheckboxSlider, typeof(OnOffButtonColumn)},
            {FieldType.FT_ComboBox, typeof(ComboBoxColumn)},
            {FieldType.FT_NumericUpDown, typeof(TextColumn)},
            {FieldType.FT_StateCycle, typeof(TextColumn)},
            {FieldType.FT_DynamicList, typeof(ComboBoxColumn)}
        };

        public static ITableColumn InitilaizeColumn(DataRow metadata)
        {
            var fieldType = metadata["FieldType"].ToString();
            var type = (FieldType)Enum.Parse(typeof(FieldType), fieldType);
            return Activator.CreateInstance(ColumnsTypes[type], metadata) as ITableColumn;
        }
    }
}

using System;
using System.Data;
using Rotem.Touch.UITests.Infrastructure.Helpers.Extensions;
using Rotem.Touch.UITests.Infrastructure.Helpers.InputMethods;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView;
using System.Linq;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.PageViews.TableView
{
    internal class TextColumn : ITableColumn
    {

        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;

        public TextColumn() {}
        public TextColumn(DataRow mdtRow)
        {            
            // sefi - while in mobile mode the mdtRow for DisplayName supposed to be mdtRow["MobileHeaderText"]
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            // sefi - use the Language execl to fix headers names
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);

            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();

            

            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();
            GroupeByLanguage = new MultiLanguageHelper(Group);

            Group = GroupeByLanguage.FindHeaderValueByLanguage();
            // end of sefi change

            FieldName = mdtRow["FieldName"].ToString();
            var type = mdtRow["KeyPadType"].ToString(); 
            ValueType = new ColumnsValueTypesFactory().GetColumnValueType(mdtRow["DataType"].ToString());
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new KeyPadFactory().GetKeyPadType(type); // in some cases keypad type = 0 which refer as column = readonly (for expamle: System column in Extra Systems)
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string FieldName { get; set; }
        public string Group { get; set; }
        public Type ValueType { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }

    internal class OnOffButtonColumn : ITableColumn
    {
        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;
        public OnOffButtonColumn(){}
        public OnOffButtonColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            // sefi - use the Language execl to fix headers names
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);

            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();

            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();

            GroupeByLanguage = new MultiLanguageHelper(Group);

            Group = GroupeByLanguage.FindHeaderValueByLanguage();
            // end of sefi change
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new TouchToggleButton();
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string FieldName { get; set; }
        public string Group { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }

    internal class TimeColumn : ITableColumn
    {
        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;
        public TimeColumn(){}
        public TimeColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            // sefi - use the Language execl to fix headers names
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);
            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();
            if (FieldName == "FeedScaleProgramAdvBreeder_StartTime")
            {
                Group = "0";
            }
            else
            {
                Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();
                GroupeByLanguage = new MultiLanguageHelper(Group);

                Group = GroupeByLanguage.FindHeaderValueByLanguage();
            }
            //end sefi change
            ValueType = new ColumnsValueTypesFactory().GetColumnValueType(mdtRow["DataType"].ToString());
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new TimeKeyPad();
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string FieldName { get; set; }
        public string Group { get; set; }
        public Type ValueType { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }

    internal class DateColumn : ITableColumn
    {
        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;
        public DateColumn() {}
        public DateColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            // sefi - use the Language execl to fix headers names
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);

            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();
            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();
            GroupeByLanguage = new MultiLanguageHelper(Group);

            Group = GroupeByLanguage.FindHeaderValueByLanguage();
            //end sefi change
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new DateKeyPad();
        }
        public string FieldName { get; set; }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string Group { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }

    internal class CheckBoxColumn : ITableColumn
    {
        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;
        public CheckBoxColumn() {}
        public CheckBoxColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            // sefi - use the Language execl to fix headers names
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);
            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();
            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();
            GroupeByLanguage = new MultiLanguageHelper(Group);
            Group = GroupeByLanguage.FindHeaderValueByLanguage();
            //end sefi change
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new TouchCheckBox();        
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string Group { get; set; }
        public string FieldName { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }    
    
    internal class ComboBoxColumn : ITableColumn
    {
        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;

        public ComboBoxColumn() {}
        public ComboBoxColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            // sefi - use the Language execl to fix headers names
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);

            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();

            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();

            GroupeByLanguage = new MultiLanguageHelper(Group);

            Group = GroupeByLanguage.FindHeaderValueByLanguage();
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new TouchComboBox();        
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string Group { get; set; }
        public string FieldName { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }

    internal class TextWithImageColumn : ITableColumn
    {
        public TextWithImageColumn() { }
        public TextWithImageColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();
            IsReadOnly = true;
            InputMethod = null;
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string Group { get; set; }
        public string FieldName { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }

    internal class NumericUpDownColumn : ITableColumn
    {
        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;
        public NumericUpDownColumn() { }
        public NumericUpDownColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            // sefi - use the Language execl to fix headers names
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);

            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();

            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();
            GroupeByLanguage = new MultiLanguageHelper(Group);

            Group = GroupeByLanguage.FindHeaderValueByLanguage();
            //end of sefi change
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new NumericUpDownKeyPad();
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string Group { get; set; }
        public string FieldName { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }

    internal class ButtonsGroupColumn : ITableColumn
    {
        private MultiLanguageHelper DisplayNameByLanguage;
        private MultiLanguageHelper GroupeByLanguage;
        public ButtonsGroupColumn() { }
        public ButtonsGroupColumn(DataRow mdtRow)
        {
            FieldName = mdtRow["FieldName"].ToString();
            DisplayName = mdtRow["HeaderText"].ToString().RemoveWhiteSpaces();
            // sefi - use the Language execl to fix headers names
            DisplayNameByLanguage = new MultiLanguageHelper(DisplayName);

            DisplayName = DisplayNameByLanguage.FindHeaderValueByLanguage();
            Group = mdtRow["GroupName"].ToString().RemoveWhiteSpaces();
            GroupeByLanguage = new MultiLanguageHelper(Group);

            Group = GroupeByLanguage.FindHeaderValueByLanguage();
            //end of sefi change
            IsReadOnly = Boolean.Parse(mdtRow["IsReadOnly"].ToString());
            InputMethod = IsReadOnly ? null : new ButtonsGroup();
        }
        public int Id
        {
            get
            {
                var id = Group == null ? string.Empty.GetHashCode() : Group.GetHashCode();
                id += DisplayName == null ? string.Empty.GetHashCode() : DisplayName.GetHashCode();

                return id;
            }
        }
        public string DisplayName { get; set; }
        public string Group { get; set; }
        public string FieldName { get; set; }
        public bool IsReadOnly { get; set; }
        public ISystemInputMethod InputMethod { get; set; }
    }
}

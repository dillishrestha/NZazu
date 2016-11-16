﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using NZazu.Contracts;

namespace NZazu.Fields
{
    public class NZazuOptionsField : NZazuField<string>
    {
        public NZazuOptionsField(string key, FieldDefinition definition) : base(key, definition) { }

        public override DependencyProperty ContentProperty => ComboBox.TextProperty;

        public override string Type => "option";

        public string[] Options { get; protected internal set; }

        protected override Control GetValue()
        {
            var control = new ComboBox { ToolTip = Description};
            if (Options != null)
            {
                foreach (var option in Options)
                    control.Items.Add(option);
                control.SelectedItem = Options.FirstOrDefault();
            }
            return control;
        }

        protected override void SetStringValue(string value) { Value = value; }
        protected override string GetStringValue() { return Value; }}
}
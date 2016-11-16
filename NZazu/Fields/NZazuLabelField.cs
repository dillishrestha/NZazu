using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using NZazu.Contracts;

namespace NZazu.Fields
{
    internal class NZazuLabelField : NZazuField
    {
        public NZazuLabelField(string key, FieldDefinition definition) : base(key, definition) { }

        public override string Type => "label";

        public override bool IsEditable => false;

        public override string StringValue
        {
            get { return null; }
            set { }
        }

        public override DependencyProperty ContentProperty => null;

        protected override Control GetValue() { return !string.IsNullOrWhiteSpace(Description) ? new Label { Content = Description } : null; }
    }
}
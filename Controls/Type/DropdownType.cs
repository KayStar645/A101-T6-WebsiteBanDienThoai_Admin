using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls.Type
{
    public class DropdownType
    {
        private string code, label, value;

        public string Code { get => code; set => code = value; }
        public string Label { get => label; set => label = value; }
        public string Value { get => value; set => this.value = value; }

        public DropdownType(string code, string label, string value)
        {
            this.code = code;
            this.label = label;
            this.value = value;
        }
    }
}

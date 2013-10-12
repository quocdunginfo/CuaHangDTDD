using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Class
{
    class ComboBoxItem
    {
        public string name = "";
        public int value = 0;
        public override string ToString()
        {
            return this.name;
        }
        public ComboBoxItem(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }
}

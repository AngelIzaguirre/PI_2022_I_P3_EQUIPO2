using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Objetos
{
    internal class ComboBoxItem
    {

        public object Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
        public ComboBoxItem(object pValue, string pText)
        {
            Value=pValue;
            Text = pText;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllForAZS
{
    public class Price:TextBox
    {
        public int CountDot { get; set; }
        int dot;

        bool checkIsDot()
        {
            for (int i = 0; i < this.Text.Length; i++)
            {
                if (this.Text[i] == ',')
                {
                    return true;
                }
            }
            return false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && Text.Length == 0)
                e.Handled = true;
            if (checkIsDot() == true && Text.Length <= dot)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b'))
                    e.Handled = true;

            }
            else if (checkIsDot() == false)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == ','))
                    e.Handled = true;
                dot = Text.Length + CountDot;
            }
            else if (e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;

            base.OnKeyPress(e);
            
        }
    }
   
}

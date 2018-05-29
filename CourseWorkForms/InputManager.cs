using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkForms
{
    public static class InputManager
    {
        public static void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
                    e.Handled = true;
            }
        }
    }
}

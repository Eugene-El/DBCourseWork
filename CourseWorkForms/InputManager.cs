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

        public static void OnlyPersonalCode(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-'))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
                    e.Handled = true;
            }
        }

        public static void OnlyPhone(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != '+'))
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
                    e.Handled = true;
            }
        }


        public static void SetMaxLengthForTextField(MaterialSkin.Controls.MaterialSingleLineTextField textField, int maxLength)
        {
            textField.KeyPress += (sender, e) => {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete) && textField.TextLength >= maxLength)
                    e.Handled = true;
            };
        }
    }
}

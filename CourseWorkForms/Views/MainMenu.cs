using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkForms.Views
{
    public partial class MainMenu : MaterialForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnMedicaments_Click(object sender, EventArgs e)
        {
            ChangeView(new Medicaments());
        }

        private void ChangeView(MaterialForm form)
        {
            Hide();
            form.FormClosed += (s, args) =>
            {
                Show();
            };
            form.Show();
        }
    }
}

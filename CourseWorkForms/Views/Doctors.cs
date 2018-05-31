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
    public partial class Doctors : MaterialSkin.Controls.MaterialForm
    {
        public Doctors()
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Doctor". При необходимости она может быть перемещена или удалена.
            doctorTableAdapter.Fill(appData.Doctor);

            TxtFldPersonalCode.KeyPress += InputManager.OnlyPersonalCode;
            TxtFldPhone.KeyPress += InputManager.OnlyPhone;
            InputManager.SetMaxLengthForTextField(TxtFldPersonalCode, 12);
            InputManager.SetMaxLengthForTextField(TxtFldName, 256);
            InputManager.SetMaxLengthForTextField(TxtFldSurname, 256);
            InputManager.SetMaxLengthForTextField(TxtFldPhone, 16);
            InputManager.SetMaxLengthForTextField(TxtFldAdress, 256);

            Edit(false);
        }

        private void Edit(bool value)
        {
            LblAdress.Enabled = value;
            LblName.Enabled = value;
            LblPersonalCode.Enabled = value;
            LblPhone.Enabled = value;
            LblSurname.Enabled = value;
            TxtFldAdress.Enabled = value;
            TxtFldName.Enabled = value;
            TxtFldPersonalCode.Enabled = value;
            TxtFldPhone.Enabled = value;
            TxtFldSurname.Enabled = value;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.Doctor.AddDoctorRow("", "", "", "", "");
                doctorBindingSource.MoveLast();
                TxtFldPersonalCode.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Doctor.RejectChanges();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            TxtFldPersonalCode.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            doctorBindingSource.ResetBindings(false);
            appData.Doctor.RejectChanges();
            doctorBindingSource.ResetCurrentItem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                doctorBindingSource.EndEdit();
                doctorTableAdapter.Update(appData.Doctor);
                dtGrdDoctor.Refresh();
                TxtFldPersonalCode.Focus();
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Doctor.RejectChanges();
            }
        }

        private void dtGrdDoctor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want tot delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    doctorBindingSource.RemoveCurrent();
                }
            }
        }
    }
}

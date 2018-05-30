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
    public partial class Patients : MaterialSkin.Controls.MaterialForm
    {
        public Patients()
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.appData.Patient);

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
                appData.Patient.AddPatientRow("", "", "", "", "");
                patientBindingSource.MoveLast();
                TxtFldPersonalCode.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Patient.RejectChanges();
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
            patientBindingSource.ResetBindings(false);
            appData.Patient.RejectChanges();
            patientBindingSource.ResetCurrentItem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                patientBindingSource.EndEdit();
                patientTableAdapter.Update(appData.Patient);
                dtGrdPatient.Refresh();
                TxtFldPersonalCode.Focus();
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Patient.RejectChanges();
            }
        }

        private void dtGrdPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want tot delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    patientBindingSource.RemoveCurrent();
                }
            }
        }

        private void dtGrdPatient_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            if (dtGrdPatient.CurrentCell.ColumnIndex == 0)
                tb.KeyPress += InputManager.OnlyPersonalCode;
            else
                tb.KeyPress -= InputManager.OnlyPersonalCode;
            if (dtGrdPatient.CurrentCell.ColumnIndex == 3)
                tb.KeyPress += InputManager.OnlyPhone;
            else
                tb.KeyPress -= InputManager.OnlyPhone;
        }

        private void BtnShowAllergies_Click(object sender, EventArgs e)
        {
            AppData.PatientRow patientRow = appData.Patient.FindByPersonalCode(TxtFldPersonalCode.Text);
            if (TxtFldPersonalCode.TextLength == 12 && patientRow != null)
            {
                MaterialSkin.Controls.MaterialForm form = new Allergies(patientRow.PersonalCode);

                Hide();
                form.FormClosed += (s, args) =>
                {
                    Show();
                };
                form.Show();
            }
        }
    }
}

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
    public partial class DiseaseHistory : MaterialSkin.Controls.MaterialForm
    {
        private string PersonalCode;
        private AppData.PatientRow Patient;

        public DiseaseHistory(string personalCode)
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);

            PersonalCode = personalCode;
        }

        private void DiseaseHistory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.DiseaseHistory". При необходимости она может быть перемещена или удалена.
            diseaseHistoryTableAdapter.FillByPersonalCode(appData.DiseaseHistory, PersonalCode);

            Patient = patientTableAdapter.GetPersonByPersonalCode(PersonalCode).First();
            LblNameSurname.Text = Patient.Name + " " + Patient.Surname;

            Edit(false);
        }

        private void Edit(bool value)
        {
            LblBeginDate.Enabled = value;
            LblEndDate.Enabled = value;
            DtTmBeginDate.Enabled = value;
            DtTmEndDate.Enabled = value;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.DiseaseHistory.AddDiseaseHistoryRow(DateTime.Now, DateTime.Now, Patient);
                diseaseHistoryBindingSource.MoveLast();
                DtTmBeginDate.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.DiseaseHistory.RejectChanges();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            DtTmBeginDate.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            diseaseHistoryBindingSource.ResetBindings(false);
            appData.DiseaseHistory.RejectChanges();
            diseaseHistoryBindingSource.ResetCurrentItem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                diseaseHistoryBindingSource.EndEdit();
                diseaseHistoryTableAdapter.Update(appData.DiseaseHistory);
                dtGrdDiseaseHistory.Refresh();
                DtTmBeginDate.Focus();
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.DiseaseHistory.RejectChanges();
            }
        }

        private void dtGrdDiseaseHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want tot delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    diseaseHistoryBindingSource.RemoveCurrent();
                }
            }
        }

        private void BtnShowStayings_Click(object sender, EventArgs e)
        {
            if (dtGrdDiseaseHistory.SelectedRows != null)
            {
                MaterialSkin.Controls.MaterialForm form = new Stayings(PersonalCode, (AppData.DiseaseHistoryRow)((DataRowView)diseaseHistoryBindingSource.Current).Row);

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

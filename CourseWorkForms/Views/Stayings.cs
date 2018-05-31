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
    public partial class Stayings : MaterialSkin.Controls.MaterialForm
    {
        private string PersonalCode;
        private AppData.PatientRow Patient;
        private AppData.DiseaseHistoryRow DiseaseHistory;

        public Stayings(string personalCode, AppData.DiseaseHistoryRow diseaseHistory)
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);

            PersonalCode = personalCode;
            DiseaseHistory = diseaseHistory;
        }

        private void Stayings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Ward". При необходимости она может быть перемещена или удалена.
            wardTableAdapter.Fill(appData.Ward);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Staying". При необходимости она может быть перемещена или удалена.
            stayingTableAdapter.FillByDiseaseHistoryID(appData.Staying, DiseaseHistory.ID);

            Patient = patientTableAdapter.GetPersonByPersonalCode(PersonalCode).First();
            LblNameSurname.Text = Patient.Name + " " + Patient.Surname;

            Edit(false);
        }

        private void Edit(bool value)
        {
            LblBeginDate.Enabled = value;
            LblEndDate.Enabled = value;
            LblWard.Enabled = value;
            DtTmBeginDate.Enabled = value;
            DtTmEndDate.Enabled = value;
            CmBxDoctor.Enabled = value;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.Staying.AddStayingRow(DateTime.Now, DateTime.Now, DiseaseHistory, appData.Ward.First());
                stayingBindingSource.MoveLast();
                DtTmBeginDate.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Staying.RejectChanges();
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
            stayingBindingSource.ResetBindings(false);
            appData.Staying.RejectChanges();
            stayingBindingSource.ResetCurrentItem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                stayingBindingSource.EndEdit();
                stayingTableAdapter.Update(appData.Staying);
                dtGrdStaying.Refresh();
                DtTmBeginDate.Focus();
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Staying.RejectChanges();
            }
        }
    }
}

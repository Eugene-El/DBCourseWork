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
    public partial class Treatment : MaterialSkin.Controls.MaterialForm
    {
        private string PersonalCode;
        private AppData.PatientRow Patient;
        private AppData.DiseaseHistoryRow DiseaseHistory;

        public Treatment(string personalCode, AppData.DiseaseHistoryRow diseaseHistory)
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);

            DiseaseHistory = diseaseHistory;
            PersonalCode = personalCode;
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Doctor". При необходимости она может быть перемещена или удалена.
            doctorTableAdapter.Fill(appData.Doctor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Treatment". При необходимости она может быть перемещена или удалена.
            treatmentTableAdapter.Fill(appData.Treatment);

            treatmentTableAdapter.FillByDiseaseHistoryID_(appData.Treatment, DiseaseHistory.ID);

            Patient = patientTableAdapter.GetPersonByPersonalCode(PersonalCode).First();
            LblNameSurname.Text = Patient.Name + " " + Patient.Surname;

            DtTmBeginDate.MinDate = DtTmEndDate.MinDate = DiseaseHistory.BeginningDate;
            DtTmEndDate.MaxDate = DtTmBeginDate.MaxDate = DiseaseHistory.EndDate;

            Edit(false);
        }

        private void CmBxDoctor_Format(object sender, ListControlConvertEventArgs e)
        {
            string name = ((AppData.DoctorRow)((DataRowView)e.ListItem).Row).Name;
            string surname = ((AppData.DoctorRow)((DataRowView)e.ListItem).Row).Surname;
            e.Value = name + " " + surname;
        }

        private void Edit(bool value)
        {
            LblBeginDate.Enabled = value;
            LblEndDate.Enabled = value;
            LblDoctor.Enabled = value;
            CmBxDoctor.Enabled = value;
            DtTmBeginDate.Enabled = value;
            DtTmEndDate.Enabled = value;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.Treatment.AddTreatmentRow(DateTime.Now, DateTime.Now, appData.Doctor.First(), DiseaseHistory);
                treatmentBindingSource.MoveLast();
                DtTmBeginDate.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Treatment.RejectChanges();
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
            treatmentBindingSource.ResetBindings(false);
            appData.Treatment.RejectChanges();
            treatmentBindingSource.ResetCurrentItem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                treatmentBindingSource.EndEdit();
                treatmentTableAdapter.Update(appData.Treatment);
                dtGrdTreatment.Refresh();
                DtTmBeginDate.Focus();
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Treatment.RejectChanges();
            }
        }

        private void dtGrdTreatment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want tot delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    treatmentBindingSource.RemoveCurrent();
                }
            }
        }

        private void BtnMedicamentAssignment_Click(object sender, EventArgs e)
        {
            if (dtGrdTreatment.SelectedRows.Count != 0)
            {
                MaterialSkin.Controls.MaterialForm form = new MedicamentAssignment(Patient, (AppData.TreatmentRow)((DataRowView)treatmentBindingSource.Current).Row);

                Hide();
                form.FormClosed += (s, args) =>
                {
                    Show();
                };
                form.Show();
            }
        }

        private void BtnProcedureAssignment_Click(object sender, EventArgs e)
        {
            if (dtGrdTreatment.SelectedRows.Count != 0)
            {
                MaterialSkin.Controls.MaterialForm form = new ProcedureAssigment(Patient, (AppData.TreatmentRow)((DataRowView)treatmentBindingSource.Current).Row);

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

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
    public partial class MedicamentAssignment : MaterialSkin.Controls.MaterialForm
    {
        private AppData.PatientRow Patient;
        private AppData.TreatmentRow Treatment;
        private List<AppData.MedicamentAssignmentRow> MedicamentAssignmentList;
        

        public MedicamentAssignment(AppData.PatientRow patient, AppData.TreatmentRow treatment)
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);

            Patient = patient;
            Treatment = treatment;
        }

        private void MedicamentAssignment_Load(object sender, EventArgs e)
        {
            GetData();

            LstBxMedicaments1.DisplayMember = "Title";
            LstBxMedicaments1.ValueMember = "ID";
            LstBxMedicaments2.DisplayMember = "Title";
            LstBxMedicaments2.ValueMember = "ID";
        }

        private void GetData()
        {
            LstBxMedicaments1.Items.Clear();
            LstBxMedicaments2.Items.Clear();

            medicamentAssignmentTableAdapter.FillByTreatmentID(appData.MedicamentAssignment, Treatment.ID);
            medicamentTableAdapter.Fill(appData.Medicament);

            LblNameSurname.Text = Patient.Name + " " + Patient.Surname;

            MedicamentAssignmentList = appData.MedicamentAssignment.ToList();

            foreach (AppData.MedicamentRow medicament in appData.Medicament)
            {
                if (MedicamentAssignmentList.Exists(a => a.MedicamentID == medicament.ID))
                    LstBxMedicaments1.Items.Add(medicament);
                else
                    LstBxMedicaments2.Items.Add(medicament);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            object selected = LstBxMedicaments2.SelectedItem;
            if (selected != null)
            {
                LstBxMedicaments1.Items.Add(selected);
                LstBxMedicaments2.Items.Remove(selected);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            object selected = LstBxMedicaments1.SelectedItem;
            if (selected != null)
            {
                LstBxMedicaments2.Items.Add(selected);
                LstBxMedicaments1.Items.Remove(selected);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (AppData.MedicamentRow medicament in LstBxMedicaments1.Items)
                {
                    if (!MedicamentAssignmentList.Exists(a => a.MedicamentID == medicament.ID && a.TreatmentID == Treatment.ID))
                        appData.MedicamentAssignment.AddMedicamentAssignmentRow(medicament, Treatment);
                }

                foreach (AppData.MedicamentRow medicament in LstBxMedicaments2.Items)
                {
                    if (MedicamentAssignmentList.Exists(a => a.MedicamentID == medicament.ID && a.TreatmentID == Treatment.ID))
                    {
                        AppData.MedicamentAssignmentRow MAR = MedicamentAssignmentList.Find(al => al.MedicamentID == medicament.ID);

                        medicamentAssignmentTableAdapter.Delete(MAR.ID, MAR.MedicamentID, MAR.TreatmentID);
                    }
                }

                medicamentAssignmentTableAdapter.Update(appData.MedicamentAssignment);
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.MedicamentAssignment.RejectChanges();
            }
            GetData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}

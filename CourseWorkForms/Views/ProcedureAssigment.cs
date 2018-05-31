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
    public partial class ProcedureAssigment : MaterialSkin.Controls.MaterialForm
    {
        private AppData.PatientRow Patient;
        private AppData.TreatmentRow Treatment;
        private List<AppData.ProcedureAssignmentRow> ProcedureAssignmentList;

        public ProcedureAssigment(AppData.PatientRow patient, AppData.TreatmentRow treatment)
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);

            Patient = patient;
            Treatment = treatment;
        }

        private void ProcedureAssigment_Load(object sender, EventArgs e)
        {
            GetData();

            LstBxProcdure1.DisplayMember = "Title";
            LstBxProcdure1.ValueMember = "ID";
            LstBxProcdure2.DisplayMember = "Title";
            LstBxProcdure2.ValueMember = "ID";
        }

        private void GetData()
        {
            LstBxProcdure1.Items.Clear();
            LstBxProcdure2.Items.Clear();

            procedureAssignmentTableAdapter.FillByTreatmentID(appData.ProcedureAssignment, Treatment.ID);
            procedureTableAdapter.Fill(appData.Procedure);

            LblNameSurname.Text = Patient.Name + " " + Patient.Surname;

            ProcedureAssignmentList = appData.ProcedureAssignment.ToList();

            foreach (AppData.ProcedureRow procedure in appData.Procedure)
            {
                if (ProcedureAssignmentList.Exists(a => a.ProcedureID == procedure.ID))
                    LstBxProcdure1.Items.Add(procedure);
                else
                    LstBxProcdure2.Items.Add(procedure);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            object selected = LstBxProcdure2.SelectedItem;
            if (selected != null)
            {
                LstBxProcdure1.Items.Add(selected);
                LstBxProcdure2.Items.Remove(selected);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            object selected = LstBxProcdure1.SelectedItem;
            if (selected != null)
            {
                LstBxProcdure2.Items.Add(selected);
                LstBxProcdure1.Items.Remove(selected);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (AppData.ProcedureRow procedure in LstBxProcdure1.Items)
                {
                    if (!ProcedureAssignmentList.Exists(a => a.ProcedureID == procedure.ID && a.TreatmentID == Treatment.ID))
                        appData.ProcedureAssignment.AddProcedureAssignmentRow(procedure, Treatment);
                }

                foreach (AppData.ProcedureRow procedure in LstBxProcdure2.Items)
                {
                    if (ProcedureAssignmentList.Exists(a => a.ProcedureID == procedure.ID && a.TreatmentID == Treatment.ID))
                    {
                        AppData.ProcedureAssignmentRow PAR = ProcedureAssignmentList.Find(al => al.ProcedureID == procedure.ID);

                        procedureAssignmentTableAdapter.Delete(PAR.ID, PAR.ProcedureID, PAR.TreatmentID);
                    }
                }

                procedureAssignmentTableAdapter.Update(appData.ProcedureAssignment);
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.ProcedureAssignment.RejectChanges();
            }
            GetData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}

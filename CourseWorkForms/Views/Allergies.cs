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
    public partial class Allergies : MaterialSkin.Controls.MaterialForm
    {
        private string PersonalCode;
        private AppData.PatientRow Patient;
        private List<AppData.AllergyRow> allergiesList;

        public Allergies(string personalCode)
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);

            PersonalCode = personalCode;
        }

        private void Allergies_Load(object sender, EventArgs e)
        {
            GetData();

            LstBxAllergies.DisplayMember = "Title";
            LstBxAllergies.ValueMember = "ID";
            LstBxMedicaments.DisplayMember = "Title";
            LstBxMedicaments.ValueMember = "ID";
        }

        private void GetData()
        {
            LstBxAllergies.Items.Clear();
            LstBxMedicaments.Items.Clear();

            // Get data
            patientTableAdapter.Fill(appData.Patient);
            allergyTableAdapter.Fill(appData.Allergy);
            medicamentTableAdapter.Fill(appData.Medicament);

            // Get name and surname
            Patient = appData.Patient.FindByPersonalCode(PersonalCode);
            LblNameSurname.Text = Patient.Name + " " + Patient.Surname;

            // Get allegies
            allergiesList = appData.Allergy.Where(a => a.PatientPersonalCode == PersonalCode).ToList();

            foreach (AppData.MedicamentRow medicament in appData.Medicament)
            {
                if (allergiesList.Exists(a => a.MedicamentID == medicament.ID))
                    LstBxAllergies.Items.Add(medicament);
                else
                    LstBxMedicaments.Items.Add(medicament);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            object selected = LstBxMedicaments.SelectedItem;
            if (selected != null)
            {
                LstBxAllergies.Items.Add(selected);
                LstBxMedicaments.Items.Remove(selected);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            object selected = LstBxAllergies.SelectedItem;
            if (selected != null)
            {
                LstBxMedicaments.Items.Add(selected);
                LstBxAllergies.Items.Remove(selected);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (AppData.MedicamentRow medicament in LstBxAllergies.Items)
                {
                    if (!allergiesList.Exists(a => a.MedicamentID == medicament.ID && a.PatientPersonalCode == PersonalCode))
                        appData.Allergy.AddAllergyRow(Patient, medicament);
                }

                foreach (AppData.MedicamentRow medicament in LstBxMedicaments.Items)
                {
                    if (allergiesList.Exists(a => a.MedicamentID == medicament.ID && a.PatientPersonalCode == PersonalCode))
                    {
                        AppData.AllergyRow AR = allergiesList.Find(al => al.MedicamentID == medicament.ID);
                        
                        allergyTableAdapter.Delete(AR.ID, AR.PatientPersonalCode, AR.MedicamentID);
                    }
                }
                
                allergyTableAdapter.Update(appData.Allergy);
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Allergy.RejectChanges();
            }
            GetData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}

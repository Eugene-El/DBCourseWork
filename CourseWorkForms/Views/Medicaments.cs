﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace CourseWorkForms.Views
{
    public partial class Medicaments : MaterialSkin.Controls.MaterialForm
    {
        public Medicaments()
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Medicament". При необходимости она может быть перемещена или удалена.
            this.medicamentTableAdapter.Fill(this.appData.Medicament);

            Edit(false);
        }

        private void Edit(bool value)
        {
            LblTitle.Enabled = value;
            TxtFldTitle.Enabled = value;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.Medicament.AddMedicamentRow(""); // appData.Medicament.NewMedicamentRow()
                medicamentBindingSource.MoveLast();
                TxtFldTitle.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Medicament.RejectChanges();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            TxtFldTitle.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            medicamentBindingSource.ResetBindings(false);
            appData.Medicament.RejectChanges();
            medicamentBindingSource.ResetCurrentItem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                medicamentBindingSource.EndEdit();
                //appData.Medicament.AcceptChanges(); //
                medicamentTableAdapter.Update(appData.Medicament);
                dtGrdMedicament.Refresh();
                TxtFldTitle.Focus();
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Medicament.RejectChanges();
            }
        }

        private void dtGrdMedicament_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want tot delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    medicamentBindingSource.RemoveCurrent();
                }
            }
        }
    }
}

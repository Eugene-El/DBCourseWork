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
    public partial class Wards : MaterialSkin.Controls.MaterialForm
    {
        public Wards()
        {
            InitializeComponent();

            DesignManager.ConfigurateForm(this);
        }

        private void Wards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.Ward". При необходимости она может быть перемещена или удалена.
            this.wardTableAdapter.Fill(this.appData.Ward);

            TxtFldFloor.KeyPress += InputManager.OnlyNumbers;

            Edit(false);
        }

        private void Edit(bool value)
        {
            LblFloor.Enabled = value;
            LblHousing.Enabled = value;
            LblNumber.Enabled = value;
            TxtFldFloor.Enabled = value;
            TxtFldHousing.Enabled = value;
            TxtFldNumber.Enabled = value;
        }

        private void dtGrdWard_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            if (dtGrdWard.CurrentCell.ColumnIndex == 1)
                tb.KeyPress += InputManager.OnlyNumbers;
            else
                tb.KeyPress -= InputManager.OnlyNumbers;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.Ward.AddWardRow("", 0, ""); // appData.Procedure.NewProcedureRow()
                wardBindingSource.MoveLast();
                TxtFldNumber.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Ward.RejectChanges();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            TxtFldNumber.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            wardBindingSource.ResetBindings(false);
            appData.Ward.RejectChanges();
            wardBindingSource.ResetCurrentItem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                wardBindingSource.EndEdit();
                wardTableAdapter.Update(appData.Ward);
                dtGrdWard.Refresh();
                TxtFldNumber.Focus();
                MessageBox.Show("Your database has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Ward.RejectChanges();
            }
        }

        private void dtGrdWard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want tot delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    wardBindingSource.RemoveCurrent();
                }
            }
        }
    }
}

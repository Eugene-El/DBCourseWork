namespace CourseWorkForms.Views
{
    partial class MedicamentAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LstBxMedicaments2 = new System.Windows.Forms.ListBox();
            this.LstBxMedicaments1 = new System.Windows.Forms.ListBox();
            this.LblNameSurname = new MaterialSkin.Controls.MaterialLabel();
            this.appData = new CourseWorkForms.AppData();
            this.medicamentAssignmentTableAdapter = new CourseWorkForms.AppDataTableAdapters.MedicamentAssignmentTableAdapter();
            this.medicamentTableAdapter = new CourseWorkForms.AppDataTableAdapters.MedicamentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(317, 360);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(165, 41);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(317, 313);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = true;
            this.BtnSave.Size = new System.Drawing.Size(165, 41);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Depth = 0;
            this.BtnRemove.Location = new System.Drawing.Point(317, 197);
            this.BtnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Primary = true;
            this.BtnRemove.Size = new System.Drawing.Size(165, 41);
            this.BtnRemove.TabIndex = 11;
            this.BtnRemove.Text = "Remove  ->";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Depth = 0;
            this.BtnAdd.Location = new System.Drawing.Point(317, 150);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(165, 41);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "<- Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LstBxMedicaments2
            // 
            this.LstBxMedicaments2.FormattingEnabled = true;
            this.LstBxMedicaments2.Location = new System.Drawing.Point(488, 150);
            this.LstBxMedicaments2.Name = "LstBxMedicaments2";
            this.LstBxMedicaments2.Size = new System.Drawing.Size(251, 251);
            this.LstBxMedicaments2.TabIndex = 9;
            // 
            // LstBxMedicaments1
            // 
            this.LstBxMedicaments1.FormattingEnabled = true;
            this.LstBxMedicaments1.Location = new System.Drawing.Point(60, 150);
            this.LstBxMedicaments1.Name = "LstBxMedicaments1";
            this.LstBxMedicaments1.Size = new System.Drawing.Size(251, 251);
            this.LstBxMedicaments1.TabIndex = 8;
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Depth = 0;
            this.LblNameSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNameSurname.Location = new System.Drawing.Point(56, 105);
            this.LblNameSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(120, 19);
            this.LblNameSurname.TabIndex = 7;
            this.LblNameSurname.Text = "[Name Surname]";
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentAssignmentTableAdapter
            // 
            this.medicamentAssignmentTableAdapter.ClearBeforeFill = true;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // MedicamentAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstBxMedicaments2);
            this.Controls.Add(this.LstBxMedicaments1);
            this.Controls.Add(this.LblNameSurname);
            this.MaximizeBox = false;
            this.Name = "MedicamentAssignment";
            this.Sizable = false;
            this.Text = "Medicament assignment";
            this.Load += new System.EventHandler(this.MedicamentAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private System.Windows.Forms.ListBox LstBxMedicaments2;
        private System.Windows.Forms.ListBox LstBxMedicaments1;
        private MaterialSkin.Controls.MaterialLabel LblNameSurname;
        private AppData appData;
        private AppDataTableAdapters.MedicamentAssignmentTableAdapter medicamentAssignmentTableAdapter;
        private AppDataTableAdapters.MedicamentTableAdapter medicamentTableAdapter;
    }
}
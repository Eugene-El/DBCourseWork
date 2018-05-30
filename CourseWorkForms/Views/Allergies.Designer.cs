namespace CourseWorkForms.Views
{
    partial class Allergies
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
            this.LblNameSurname = new MaterialSkin.Controls.MaterialLabel();
            this.LstBxAllergies = new System.Windows.Forms.ListBox();
            this.LstBxMedicaments = new System.Windows.Forms.ListBox();
            this.appData = new CourseWorkForms.AppData();
            this.patientTableAdapter = new CourseWorkForms.AppDataTableAdapters.PatientTableAdapter();
            this.allergyTableAdapter = new CourseWorkForms.AppDataTableAdapters.AllergyTableAdapter();
            this.medicamentTableAdapter = new CourseWorkForms.AppDataTableAdapters.MedicamentTableAdapter();
            this.BtnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Depth = 0;
            this.LblNameSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNameSurname.Location = new System.Drawing.Point(55, 105);
            this.LblNameSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(120, 19);
            this.LblNameSurname.TabIndex = 0;
            this.LblNameSurname.Text = "[Name Surname]";
            // 
            // LstBxAllergies
            // 
            this.LstBxAllergies.FormattingEnabled = true;
            this.LstBxAllergies.Location = new System.Drawing.Point(59, 150);
            this.LstBxAllergies.Name = "LstBxAllergies";
            this.LstBxAllergies.Size = new System.Drawing.Size(251, 251);
            this.LstBxAllergies.TabIndex = 1;
            // 
            // LstBxMedicaments
            // 
            this.LstBxMedicaments.FormattingEnabled = true;
            this.LstBxMedicaments.Location = new System.Drawing.Point(487, 150);
            this.LstBxMedicaments.Name = "LstBxMedicaments";
            this.LstBxMedicaments.Size = new System.Drawing.Size(251, 251);
            this.LstBxMedicaments.TabIndex = 2;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // allergyTableAdapter
            // 
            this.allergyTableAdapter.ClearBeforeFill = true;
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Depth = 0;
            this.BtnAdd.Location = new System.Drawing.Point(316, 150);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(165, 41);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "<- Add allergy";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Depth = 0;
            this.BtnRemove.Location = new System.Drawing.Point(316, 197);
            this.BtnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Primary = true;
            this.BtnRemove.Size = new System.Drawing.Size(165, 41);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Remove allergy ->";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(316, 313);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = true;
            this.BtnSave.Size = new System.Drawing.Size(165, 41);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(316, 360);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(165, 41);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Allergies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstBxMedicaments);
            this.Controls.Add(this.LstBxAllergies);
            this.Controls.Add(this.LblNameSurname);
            this.MaximizeBox = false;
            this.Name = "Allergies";
            this.Sizable = false;
            this.Text = "Allergies";
            this.Load += new System.EventHandler(this.Allergies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblNameSurname;
        private System.Windows.Forms.ListBox LstBxAllergies;
        private System.Windows.Forms.ListBox LstBxMedicaments;
        private AppData appData;
        private AppDataTableAdapters.PatientTableAdapter patientTableAdapter;
        private AppDataTableAdapters.AllergyTableAdapter allergyTableAdapter;
        private AppDataTableAdapters.MedicamentTableAdapter medicamentTableAdapter;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton BtnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
    }
}
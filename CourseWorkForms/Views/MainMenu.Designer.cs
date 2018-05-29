namespace CourseWorkForms.Views
{
    partial class MainMenu
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
            this.BtnPatients = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnDoctors = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnWards = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnProcedures = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnMedicaments = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // BtnPatients
            // 
            this.BtnPatients.Depth = 0;
            this.BtnPatients.Location = new System.Drawing.Point(300, 75);
            this.BtnPatients.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnPatients.Name = "BtnPatients";
            this.BtnPatients.Primary = true;
            this.BtnPatients.Size = new System.Drawing.Size(200, 50);
            this.BtnPatients.TabIndex = 0;
            this.BtnPatients.Text = "Patients";
            this.BtnPatients.UseVisualStyleBackColor = true;
            // 
            // BtnDoctors
            // 
            this.BtnDoctors.Depth = 0;
            this.BtnDoctors.Location = new System.Drawing.Point(300, 131);
            this.BtnDoctors.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDoctors.Name = "BtnDoctors";
            this.BtnDoctors.Primary = true;
            this.BtnDoctors.Size = new System.Drawing.Size(200, 50);
            this.BtnDoctors.TabIndex = 1;
            this.BtnDoctors.Text = "Doctors";
            this.BtnDoctors.UseVisualStyleBackColor = true;
            // 
            // BtnWards
            // 
            this.BtnWards.Depth = 0;
            this.BtnWards.Location = new System.Drawing.Point(300, 187);
            this.BtnWards.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnWards.Name = "BtnWards";
            this.BtnWards.Primary = true;
            this.BtnWards.Size = new System.Drawing.Size(200, 50);
            this.BtnWards.TabIndex = 2;
            this.BtnWards.Text = "Wards";
            this.BtnWards.UseVisualStyleBackColor = true;
            // 
            // BtnProcedures
            // 
            this.BtnProcedures.Depth = 0;
            this.BtnProcedures.Location = new System.Drawing.Point(300, 243);
            this.BtnProcedures.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProcedures.Name = "BtnProcedures";
            this.BtnProcedures.Primary = true;
            this.BtnProcedures.Size = new System.Drawing.Size(200, 50);
            this.BtnProcedures.TabIndex = 3;
            this.BtnProcedures.Text = "Procedures";
            this.BtnProcedures.UseVisualStyleBackColor = true;
            this.BtnProcedures.Click += new System.EventHandler(this.BtnProcedures_Click);
            // 
            // BtnMedicaments
            // 
            this.BtnMedicaments.Depth = 0;
            this.BtnMedicaments.Location = new System.Drawing.Point(300, 299);
            this.BtnMedicaments.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMedicaments.Name = "BtnMedicaments";
            this.BtnMedicaments.Primary = true;
            this.BtnMedicaments.Size = new System.Drawing.Size(200, 50);
            this.BtnMedicaments.TabIndex = 4;
            this.BtnMedicaments.Text = "Medicaments";
            this.BtnMedicaments.UseVisualStyleBackColor = true;
            this.BtnMedicaments.Click += new System.EventHandler(this.BtnMedicaments_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Depth = 0;
            this.BtnExit.Location = new System.Drawing.Point(588, 388);
            this.BtnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Primary = true;
            this.BtnExit.Size = new System.Drawing.Size(200, 50);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMedicaments);
            this.Controls.Add(this.BtnProcedures);
            this.Controls.Add(this.BtnWards);
            this.Controls.Add(this.BtnDoctors);
            this.Controls.Add(this.BtnPatients);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "MainMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital manager";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnPatients;
        private MaterialSkin.Controls.MaterialRaisedButton BtnDoctors;
        private MaterialSkin.Controls.MaterialRaisedButton BtnWards;
        private MaterialSkin.Controls.MaterialRaisedButton BtnProcedures;
        private MaterialSkin.Controls.MaterialRaisedButton BtnMedicaments;
        private MaterialSkin.Controls.MaterialRaisedButton BtnExit;
    }
}
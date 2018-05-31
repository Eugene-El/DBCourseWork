namespace CourseWorkForms.Views
{
    partial class ProcedureAssigment
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
            this.LstBxProcdure2 = new System.Windows.Forms.ListBox();
            this.LstBxProcdure1 = new System.Windows.Forms.ListBox();
            this.LblNameSurname = new MaterialSkin.Controls.MaterialLabel();
            this.appData = new CourseWorkForms.AppData();
            this.procedureAssignmentTableAdapter = new CourseWorkForms.AppDataTableAdapters.ProcedureAssignmentTableAdapter();
            this.procedureTableAdapter = new CourseWorkForms.AppDataTableAdapters.ProcedureTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(319, 362);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = true;
            this.BtnCancel.Size = new System.Drawing.Size(165, 41);
            this.BtnCancel.TabIndex = 20;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(319, 315);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = true;
            this.BtnSave.Size = new System.Drawing.Size(165, 41);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Depth = 0;
            this.BtnRemove.Location = new System.Drawing.Point(319, 199);
            this.BtnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Primary = true;
            this.BtnRemove.Size = new System.Drawing.Size(165, 41);
            this.BtnRemove.TabIndex = 18;
            this.BtnRemove.Text = "Remove  ->";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Depth = 0;
            this.BtnAdd.Location = new System.Drawing.Point(319, 152);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Primary = true;
            this.BtnAdd.Size = new System.Drawing.Size(165, 41);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "<- Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LstBxProcdure2
            // 
            this.LstBxProcdure2.FormattingEnabled = true;
            this.LstBxProcdure2.Location = new System.Drawing.Point(490, 152);
            this.LstBxProcdure2.Name = "LstBxProcdure2";
            this.LstBxProcdure2.Size = new System.Drawing.Size(251, 251);
            this.LstBxProcdure2.TabIndex = 16;
            // 
            // LstBxProcdure1
            // 
            this.LstBxProcdure1.FormattingEnabled = true;
            this.LstBxProcdure1.Location = new System.Drawing.Point(62, 152);
            this.LstBxProcdure1.Name = "LstBxProcdure1";
            this.LstBxProcdure1.Size = new System.Drawing.Size(251, 251);
            this.LstBxProcdure1.TabIndex = 15;
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Depth = 0;
            this.LblNameSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNameSurname.Location = new System.Drawing.Point(58, 107);
            this.LblNameSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(120, 19);
            this.LblNameSurname.TabIndex = 14;
            this.LblNameSurname.Text = "[Name Surname]";
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procedureAssignmentTableAdapter
            // 
            this.procedureAssignmentTableAdapter.ClearBeforeFill = true;
            // 
            // procedureTableAdapter
            // 
            this.procedureTableAdapter.ClearBeforeFill = true;
            // 
            // ProcedureAssigment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstBxProcdure2);
            this.Controls.Add(this.LstBxProcdure1);
            this.Controls.Add(this.LblNameSurname);
            this.MaximizeBox = false;
            this.Name = "ProcedureAssigment";
            this.Sizable = false;
            this.Text = "ProcedureAssigment";
            this.Load += new System.EventHandler(this.ProcedureAssigment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSave;
        private MaterialSkin.Controls.MaterialRaisedButton BtnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdd;
        private System.Windows.Forms.ListBox LstBxProcdure2;
        private System.Windows.Forms.ListBox LstBxProcdure1;
        private MaterialSkin.Controls.MaterialLabel LblNameSurname;
        private AppData appData;
        private AppDataTableAdapters.ProcedureAssignmentTableAdapter procedureAssignmentTableAdapter;
        private AppDataTableAdapters.ProcedureTableAdapter procedureTableAdapter;
    }
}
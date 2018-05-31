namespace CourseWorkForms.Views
{
    partial class Treatment
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
            this.components = new System.ComponentModel.Container();
            this.LblNameSurname = new MaterialSkin.Controls.MaterialLabel();
            this.dtGrdTreatment = new System.Windows.Forms.DataGridView();
            this.beginningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPersonalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new CourseWorkForms.AppData();
            this.treatmentTableAdapter = new CourseWorkForms.AppDataTableAdapters.TreatmentTableAdapter();
            this.BtnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.CmBxDoctor = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblDoctor = new MaterialSkin.Controls.MaterialLabel();
            this.DtTmEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.DtTmBeginDate = new System.Windows.Forms.DateTimePicker();
            this.LblBeginDate = new MaterialSkin.Controls.MaterialLabel();
            this.doctorTableAdapter = new CourseWorkForms.AppDataTableAdapters.DoctorTableAdapter();
            this.patientTableAdapter = new CourseWorkForms.AppDataTableAdapters.PatientTableAdapter();
            this.BtnProcedureAssignment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnMedicamentAssignment = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTreatment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
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
            this.LblNameSurname.TabIndex = 2;
            this.LblNameSurname.Text = "[Name Surname]";
            // 
            // dtGrdTreatment
            // 
            this.dtGrdTreatment.AutoGenerateColumns = false;
            this.dtGrdTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdTreatment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beginningDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.doctorPersonalCodeDataGridViewTextBoxColumn});
            this.dtGrdTreatment.DataSource = this.treatmentBindingSource;
            this.dtGrdTreatment.Location = new System.Drawing.Point(59, 140);
            this.dtGrdTreatment.Name = "dtGrdTreatment";
            this.dtGrdTreatment.Size = new System.Drawing.Size(305, 264);
            this.dtGrdTreatment.TabIndex = 3;
            this.dtGrdTreatment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtGrdTreatment_KeyDown);
            // 
            // beginningDateDataGridViewTextBoxColumn
            // 
            this.beginningDateDataGridViewTextBoxColumn.DataPropertyName = "BeginningDate";
            this.beginningDateDataGridViewTextBoxColumn.HeaderText = "BeginningDate";
            this.beginningDateDataGridViewTextBoxColumn.Name = "beginningDateDataGridViewTextBoxColumn";
            this.beginningDateDataGridViewTextBoxColumn.Width = 85;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 85;
            // 
            // doctorPersonalCodeDataGridViewTextBoxColumn
            // 
            this.doctorPersonalCodeDataGridViewTextBoxColumn.DataPropertyName = "DoctorPersonalCode";
            this.doctorPersonalCodeDataGridViewTextBoxColumn.HeaderText = "DoctorPersonalCode";
            this.doctorPersonalCodeDataGridViewTextBoxColumn.Name = "doctorPersonalCodeDataGridViewTextBoxColumn";
            this.doctorPersonalCodeDataGridViewTextBoxColumn.Width = 90;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "Treatment";
            this.treatmentBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(687, 368);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = false;
            this.BtnSave.Size = new System.Drawing.Size(46, 36);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(615, 368);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = false;
            this.BtnCancel.Size = new System.Drawing.Size(64, 36);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.Location = new System.Drawing.Point(566, 368);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Primary = false;
            this.BtnEdit.Size = new System.Drawing.Size(41, 36);
            this.BtnEdit.TabIndex = 23;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.AutoSize = true;
            this.BtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNew.Depth = 0;
            this.BtnNew.Location = new System.Drawing.Point(516, 368);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Primary = false;
            this.BtnNew.Size = new System.Drawing.Size(42, 36);
            this.BtnNew.TabIndex = 22;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // CmBxDoctor
            // 
            this.CmBxDoctor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.treatmentBindingSource, "DoctorPersonalCode", true));
            this.CmBxDoctor.DataSource = this.doctorBindingSource;
            this.CmBxDoctor.DisplayMember = "Name";
            this.CmBxDoctor.FormattingEnabled = true;
            this.CmBxDoctor.Location = new System.Drawing.Point(460, 192);
            this.CmBxDoctor.Name = "CmBxDoctor";
            this.CmBxDoctor.Size = new System.Drawing.Size(273, 21);
            this.CmBxDoctor.TabIndex = 21;
            this.CmBxDoctor.ValueMember = "PersonalCode";
            this.CmBxDoctor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmBxDoctor_Format);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.appData;
            // 
            // LblDoctor
            // 
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.Depth = 0;
            this.LblDoctor.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDoctor.Location = new System.Drawing.Point(371, 194);
            this.LblDoctor.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(59, 19);
            this.LblDoctor.TabIndex = 20;
            this.LblDoctor.Text = "Doctor:";
            // 
            // DtTmEndDate
            // 
            this.DtTmEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.treatmentBindingSource, "EndDate", true));
            this.DtTmEndDate.Location = new System.Drawing.Point(460, 166);
            this.DtTmEndDate.Name = "DtTmEndDate";
            this.DtTmEndDate.Size = new System.Drawing.Size(273, 20);
            this.DtTmEndDate.TabIndex = 19;
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Depth = 0;
            this.LblEndDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEndDate.Location = new System.Drawing.Point(371, 168);
            this.LblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(71, 19);
            this.LblEndDate.TabIndex = 18;
            this.LblEndDate.Text = "End date:";
            // 
            // DtTmBeginDate
            // 
            this.DtTmBeginDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.treatmentBindingSource, "BeginningDate", true));
            this.DtTmBeginDate.Location = new System.Drawing.Point(460, 140);
            this.DtTmBeginDate.Name = "DtTmBeginDate";
            this.DtTmBeginDate.Size = new System.Drawing.Size(273, 20);
            this.DtTmBeginDate.TabIndex = 17;
            // 
            // LblBeginDate
            // 
            this.LblBeginDate.AutoSize = true;
            this.LblBeginDate.Depth = 0;
            this.LblBeginDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBeginDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBeginDate.Location = new System.Drawing.Point(371, 142);
            this.LblBeginDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBeginDate.Name = "LblBeginDate";
            this.LblBeginDate.Size = new System.Drawing.Size(83, 19);
            this.LblBeginDate.TabIndex = 16;
            this.LblBeginDate.Text = "Begin date:";
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // BtnProcedureAssignment
            // 
            this.BtnProcedureAssignment.Depth = 0;
            this.BtnProcedureAssignment.Location = new System.Drawing.Point(516, 286);
            this.BtnProcedureAssignment.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnProcedureAssignment.Name = "BtnProcedureAssignment";
            this.BtnProcedureAssignment.Primary = true;
            this.BtnProcedureAssignment.Size = new System.Drawing.Size(217, 28);
            this.BtnProcedureAssignment.TabIndex = 27;
            this.BtnProcedureAssignment.Text = "ProcedureAssignment";
            this.BtnProcedureAssignment.UseVisualStyleBackColor = true;
            this.BtnProcedureAssignment.Click += new System.EventHandler(this.BtnProcedureAssignment_Click);
            // 
            // BtnMedicamentAssignment
            // 
            this.BtnMedicamentAssignment.Depth = 0;
            this.BtnMedicamentAssignment.Location = new System.Drawing.Point(516, 252);
            this.BtnMedicamentAssignment.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMedicamentAssignment.Name = "BtnMedicamentAssignment";
            this.BtnMedicamentAssignment.Primary = true;
            this.BtnMedicamentAssignment.Size = new System.Drawing.Size(217, 28);
            this.BtnMedicamentAssignment.TabIndex = 26;
            this.BtnMedicamentAssignment.Text = "Medicament assignment";
            this.BtnMedicamentAssignment.UseVisualStyleBackColor = true;
            this.BtnMedicamentAssignment.Click += new System.EventHandler(this.BtnMedicamentAssignment_Click);
            // 
            // Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProcedureAssignment);
            this.Controls.Add(this.BtnMedicamentAssignment);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.CmBxDoctor);
            this.Controls.Add(this.LblDoctor);
            this.Controls.Add(this.DtTmEndDate);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.DtTmBeginDate);
            this.Controls.Add(this.LblBeginDate);
            this.Controls.Add(this.dtGrdTreatment);
            this.Controls.Add(this.LblNameSurname);
            this.MaximizeBox = false;
            this.Name = "Treatment";
            this.Sizable = false;
            this.Text = "Treatment";
            this.Load += new System.EventHandler(this.Treatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTreatment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblNameSurname;
        private System.Windows.Forms.DataGridView dtGrdTreatment;
        private AppData appData;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private AppDataTableAdapters.TreatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPersonalCodeDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialFlatButton BtnSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnCancel;
        private MaterialSkin.Controls.MaterialFlatButton BtnEdit;
        private MaterialSkin.Controls.MaterialFlatButton BtnNew;
        private System.Windows.Forms.ComboBox CmBxDoctor;
        private MaterialSkin.Controls.MaterialLabel LblDoctor;
        private System.Windows.Forms.DateTimePicker DtTmEndDate;
        private MaterialSkin.Controls.MaterialLabel LblEndDate;
        private System.Windows.Forms.DateTimePicker DtTmBeginDate;
        private MaterialSkin.Controls.MaterialLabel LblBeginDate;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private AppDataTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private AppDataTableAdapters.PatientTableAdapter patientTableAdapter;
        private MaterialSkin.Controls.MaterialRaisedButton BtnProcedureAssignment;
        private MaterialSkin.Controls.MaterialRaisedButton BtnMedicamentAssignment;
    }
}
namespace CourseWorkForms.Views
{
    partial class DiseaseHistory
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
            this.dtGrdDiseaseHistory = new System.Windows.Forms.DataGridView();
            this.beginningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new CourseWorkForms.AppData();
            this.LblNameSurname = new MaterialSkin.Controls.MaterialLabel();
            this.LblBeginDate = new MaterialSkin.Controls.MaterialLabel();
            this.DtTmBeginDate = new System.Windows.Forms.DateTimePicker();
            this.DtTmEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.BtnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnShowStayings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnShowTreatments = new MaterialSkin.Controls.MaterialRaisedButton();
            this.diseaseHistoryTableAdapter = new CourseWorkForms.AppDataTableAdapters.DiseaseHistoryTableAdapter();
            this.patientTableAdapter = new CourseWorkForms.AppDataTableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDiseaseHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdDiseaseHistory
            // 
            this.dtGrdDiseaseHistory.AutoGenerateColumns = false;
            this.dtGrdDiseaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdDiseaseHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beginningDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.dtGrdDiseaseHistory.DataSource = this.diseaseHistoryBindingSource;
            this.dtGrdDiseaseHistory.Location = new System.Drawing.Point(59, 139);
            this.dtGrdDiseaseHistory.Name = "dtGrdDiseaseHistory";
            this.dtGrdDiseaseHistory.Size = new System.Drawing.Size(305, 263);
            this.dtGrdDiseaseHistory.TabIndex = 0;
            this.dtGrdDiseaseHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtGrdDiseaseHistory_KeyDown);
            // 
            // beginningDateDataGridViewTextBoxColumn
            // 
            this.beginningDateDataGridViewTextBoxColumn.DataPropertyName = "BeginningDate";
            this.beginningDateDataGridViewTextBoxColumn.HeaderText = "BeginningDate";
            this.beginningDateDataGridViewTextBoxColumn.Name = "beginningDateDataGridViewTextBoxColumn";
            this.beginningDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // diseaseHistoryBindingSource
            // 
            this.diseaseHistoryBindingSource.DataMember = "DiseaseHistory";
            this.diseaseHistoryBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.LblNameSurname.TabIndex = 1;
            this.LblNameSurname.Text = "[Name Surname]";
            // 
            // LblBeginDate
            // 
            this.LblBeginDate.AutoSize = true;
            this.LblBeginDate.Depth = 0;
            this.LblBeginDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBeginDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBeginDate.Location = new System.Drawing.Point(370, 139);
            this.LblBeginDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBeginDate.Name = "LblBeginDate";
            this.LblBeginDate.Size = new System.Drawing.Size(83, 19);
            this.LblBeginDate.TabIndex = 2;
            this.LblBeginDate.Text = "Begin date:";
            // 
            // DtTmBeginDate
            // 
            this.DtTmBeginDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diseaseHistoryBindingSource, "BeginningDate", true));
            this.DtTmBeginDate.Location = new System.Drawing.Point(459, 139);
            this.DtTmBeginDate.Name = "DtTmBeginDate";
            this.DtTmBeginDate.Size = new System.Drawing.Size(273, 20);
            this.DtTmBeginDate.TabIndex = 3;
            // 
            // DtTmEndDate
            // 
            this.DtTmEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.diseaseHistoryBindingSource, "EndDate", true));
            this.DtTmEndDate.Location = new System.Drawing.Point(459, 165);
            this.DtTmEndDate.Name = "DtTmEndDate";
            this.DtTmEndDate.Size = new System.Drawing.Size(273, 20);
            this.DtTmEndDate.TabIndex = 5;
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Depth = 0;
            this.LblEndDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEndDate.Location = new System.Drawing.Point(370, 165);
            this.LblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(71, 19);
            this.LblEndDate.TabIndex = 4;
            this.LblEndDate.Text = "End date:";
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(686, 366);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = false;
            this.BtnSave.Size = new System.Drawing.Size(46, 36);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(614, 366);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = false;
            this.BtnCancel.Size = new System.Drawing.Size(64, 36);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.Location = new System.Drawing.Point(565, 366);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Primary = false;
            this.BtnEdit.Size = new System.Drawing.Size(41, 36);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.AutoSize = true;
            this.BtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNew.Depth = 0;
            this.BtnNew.Location = new System.Drawing.Point(515, 366);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Primary = false;
            this.BtnNew.Size = new System.Drawing.Size(42, 36);
            this.BtnNew.TabIndex = 12;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnShowStayings
            // 
            this.BtnShowStayings.Depth = 0;
            this.BtnShowStayings.Location = new System.Drawing.Point(515, 270);
            this.BtnShowStayings.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnShowStayings.Name = "BtnShowStayings";
            this.BtnShowStayings.Primary = true;
            this.BtnShowStayings.Size = new System.Drawing.Size(217, 28);
            this.BtnShowStayings.TabIndex = 17;
            this.BtnShowStayings.Text = "Show Stayings";
            this.BtnShowStayings.UseVisualStyleBackColor = true;
            this.BtnShowStayings.Click += new System.EventHandler(this.BtnShowStayings_Click);
            // 
            // BtnShowTreatments
            // 
            this.BtnShowTreatments.Depth = 0;
            this.BtnShowTreatments.Location = new System.Drawing.Point(515, 236);
            this.BtnShowTreatments.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnShowTreatments.Name = "BtnShowTreatments";
            this.BtnShowTreatments.Primary = true;
            this.BtnShowTreatments.Size = new System.Drawing.Size(217, 28);
            this.BtnShowTreatments.TabIndex = 16;
            this.BtnShowTreatments.Text = "Show treatments";
            this.BtnShowTreatments.UseVisualStyleBackColor = true;
            this.BtnShowTreatments.Click += new System.EventHandler(this.BtnShowTreatments_Click);
            // 
            // diseaseHistoryTableAdapter
            // 
            this.diseaseHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // DiseaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShowStayings);
            this.Controls.Add(this.BtnShowTreatments);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.DtTmEndDate);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.DtTmBeginDate);
            this.Controls.Add(this.LblBeginDate);
            this.Controls.Add(this.LblNameSurname);
            this.Controls.Add(this.dtGrdDiseaseHistory);
            this.MaximizeBox = false;
            this.Name = "DiseaseHistory";
            this.Sizable = false;
            this.Text = "DiseaseHistory";
            this.Load += new System.EventHandler(this.DiseaseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDiseaseHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diseaseHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdDiseaseHistory;
        private MaterialSkin.Controls.MaterialLabel LblNameSurname;
        private AppData appData;
        private System.Windows.Forms.BindingSource diseaseHistoryBindingSource;
        private AppDataTableAdapters.DiseaseHistoryTableAdapter diseaseHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel LblBeginDate;
        private System.Windows.Forms.DateTimePicker DtTmBeginDate;
        private System.Windows.Forms.DateTimePicker DtTmEndDate;
        private MaterialSkin.Controls.MaterialLabel LblEndDate;
        private MaterialSkin.Controls.MaterialFlatButton BtnSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnCancel;
        private MaterialSkin.Controls.MaterialFlatButton BtnEdit;
        private MaterialSkin.Controls.MaterialFlatButton BtnNew;
        private AppDataTableAdapters.PatientTableAdapter patientTableAdapter;
        private MaterialSkin.Controls.MaterialRaisedButton BtnShowStayings;
        private MaterialSkin.Controls.MaterialRaisedButton BtnShowTreatments;
    }
}
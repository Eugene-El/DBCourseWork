namespace CourseWorkForms.Views
{
    partial class Patients
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
            this.dtGrdPatient = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new CourseWorkForms.AppData();
            this.patientTableAdapter = new CourseWorkForms.AppDataTableAdapters.PatientTableAdapter();
            this.TxtFldSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldPersonalCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblPersonalCode = new MaterialSkin.Controls.MaterialLabel();
            this.LblName = new MaterialSkin.Controls.MaterialLabel();
            this.LblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.LblPhone = new MaterialSkin.Controls.MaterialLabel();
            this.LblAdress = new MaterialSkin.Controls.MaterialLabel();
            this.BtnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnShowAllergies = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnShowDiseaseHistory = new MaterialSkin.Controls.MaterialRaisedButton();
            this.personalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdPatient
            // 
            this.dtGrdPatient.AutoGenerateColumns = false;
            this.dtGrdPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dtGrdPatient.DataSource = this.patientBindingSource;
            this.dtGrdPatient.Location = new System.Drawing.Point(55, 105);
            this.dtGrdPatient.Name = "dtGrdPatient";
            this.dtGrdPatient.Size = new System.Drawing.Size(305, 300);
            this.dtGrdPatient.TabIndex = 0;
            this.dtGrdPatient.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtGrdPatient_EditingControlShowing);
            this.dtGrdPatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtGrdPatient_KeyDown);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.appData;
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
            // TxtFldSurname
            // 
            this.TxtFldSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Surname", true));
            this.TxtFldSurname.Depth = 0;
            this.TxtFldSurname.Hint = "";
            this.TxtFldSurname.Location = new System.Drawing.Point(481, 163);
            this.TxtFldSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldSurname.Name = "TxtFldSurname";
            this.TxtFldSurname.PasswordChar = '\0';
            this.TxtFldSurname.SelectedText = "";
            this.TxtFldSurname.SelectionLength = 0;
            this.TxtFldSurname.SelectionStart = 0;
            this.TxtFldSurname.Size = new System.Drawing.Size(254, 23);
            this.TxtFldSurname.TabIndex = 3;
            this.TxtFldSurname.UseSystemPasswordChar = false;
            // 
            // TxtFldName
            // 
            this.TxtFldName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Name", true));
            this.TxtFldName.Depth = 0;
            this.TxtFldName.Hint = "";
            this.TxtFldName.Location = new System.Drawing.Point(481, 134);
            this.TxtFldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldName.Name = "TxtFldName";
            this.TxtFldName.PasswordChar = '\0';
            this.TxtFldName.SelectedText = "";
            this.TxtFldName.SelectionLength = 0;
            this.TxtFldName.SelectionStart = 0;
            this.TxtFldName.Size = new System.Drawing.Size(254, 23);
            this.TxtFldName.TabIndex = 2;
            this.TxtFldName.UseSystemPasswordChar = false;
            // 
            // TxtFldPersonalCode
            // 
            this.TxtFldPersonalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "PersonalCode", true));
            this.TxtFldPersonalCode.Depth = 0;
            this.TxtFldPersonalCode.Hint = "";
            this.TxtFldPersonalCode.Location = new System.Drawing.Point(481, 105);
            this.TxtFldPersonalCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldPersonalCode.Name = "TxtFldPersonalCode";
            this.TxtFldPersonalCode.PasswordChar = '\0';
            this.TxtFldPersonalCode.SelectedText = "";
            this.TxtFldPersonalCode.SelectionLength = 0;
            this.TxtFldPersonalCode.SelectionStart = 0;
            this.TxtFldPersonalCode.Size = new System.Drawing.Size(254, 23);
            this.TxtFldPersonalCode.TabIndex = 1;
            this.TxtFldPersonalCode.UseSystemPasswordChar = false;
            // 
            // TxtFldPhone
            // 
            this.TxtFldPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Phone", true));
            this.TxtFldPhone.Depth = 0;
            this.TxtFldPhone.Hint = "";
            this.TxtFldPhone.Location = new System.Drawing.Point(481, 192);
            this.TxtFldPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldPhone.Name = "TxtFldPhone";
            this.TxtFldPhone.PasswordChar = '\0';
            this.TxtFldPhone.SelectedText = "";
            this.TxtFldPhone.SelectionLength = 0;
            this.TxtFldPhone.SelectionStart = 0;
            this.TxtFldPhone.Size = new System.Drawing.Size(254, 23);
            this.TxtFldPhone.TabIndex = 4;
            this.TxtFldPhone.UseSystemPasswordChar = false;
            // 
            // TxtFldAdress
            // 
            this.TxtFldAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Adress", true));
            this.TxtFldAdress.Depth = 0;
            this.TxtFldAdress.Hint = "";
            this.TxtFldAdress.Location = new System.Drawing.Point(481, 221);
            this.TxtFldAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldAdress.Name = "TxtFldAdress";
            this.TxtFldAdress.PasswordChar = '\0';
            this.TxtFldAdress.SelectedText = "";
            this.TxtFldAdress.SelectionLength = 0;
            this.TxtFldAdress.SelectionStart = 0;
            this.TxtFldAdress.Size = new System.Drawing.Size(254, 23);
            this.TxtFldAdress.TabIndex = 5;
            this.TxtFldAdress.UseSystemPasswordChar = false;
            // 
            // LblPersonalCode
            // 
            this.LblPersonalCode.AutoSize = true;
            this.LblPersonalCode.Depth = 0;
            this.LblPersonalCode.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblPersonalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPersonalCode.Location = new System.Drawing.Point(366, 109);
            this.LblPersonalCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPersonalCode.Name = "LblPersonalCode";
            this.LblPersonalCode.Size = new System.Drawing.Size(109, 19);
            this.LblPersonalCode.TabIndex = 12;
            this.LblPersonalCode.Text = "Personal code:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Depth = 0;
            this.LblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblName.Location = new System.Drawing.Point(366, 138);
            this.LblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(53, 19);
            this.LblName.TabIndex = 13;
            this.LblName.Text = "Name:";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Depth = 0;
            this.LblSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSurname.Location = new System.Drawing.Point(366, 167);
            this.LblSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(72, 19);
            this.LblSurname.TabIndex = 14;
            this.LblSurname.Text = "Surname:";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Depth = 0;
            this.LblPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPhone.Location = new System.Drawing.Point(366, 196);
            this.LblPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(55, 19);
            this.LblPhone.TabIndex = 15;
            this.LblPhone.Text = "Phone:";
            // 
            // LblAdress
            // 
            this.LblAdress.AutoSize = true;
            this.LblAdress.Depth = 0;
            this.LblAdress.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdress.Location = new System.Drawing.Point(366, 225);
            this.LblAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdress.Name = "LblAdress";
            this.LblAdress.Size = new System.Drawing.Size(60, 19);
            this.LblAdress.TabIndex = 16;
            this.LblAdress.Text = "Adress:";
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(689, 369);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = false;
            this.BtnSave.Size = new System.Drawing.Size(46, 36);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(617, 369);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = false;
            this.BtnCancel.Size = new System.Drawing.Size(64, 36);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.Location = new System.Drawing.Point(568, 369);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Primary = false;
            this.BtnEdit.Size = new System.Drawing.Size(41, 36);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.AutoSize = true;
            this.BtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNew.Depth = 0;
            this.BtnNew.Location = new System.Drawing.Point(518, 369);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Primary = false;
            this.BtnNew.Size = new System.Drawing.Size(42, 36);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnShowAllergies
            // 
            this.BtnShowAllergies.Depth = 0;
            this.BtnShowAllergies.Location = new System.Drawing.Point(518, 272);
            this.BtnShowAllergies.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnShowAllergies.Name = "BtnShowAllergies";
            this.BtnShowAllergies.Primary = true;
            this.BtnShowAllergies.Size = new System.Drawing.Size(217, 28);
            this.BtnShowAllergies.TabIndex = 6;
            this.BtnShowAllergies.Text = "Show allergies";
            this.BtnShowAllergies.UseVisualStyleBackColor = true;
            // 
            // BtnShowDiseaseHistory
            // 
            this.BtnShowDiseaseHistory.Depth = 0;
            this.BtnShowDiseaseHistory.Location = new System.Drawing.Point(518, 306);
            this.BtnShowDiseaseHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnShowDiseaseHistory.Name = "BtnShowDiseaseHistory";
            this.BtnShowDiseaseHistory.Primary = true;
            this.BtnShowDiseaseHistory.Size = new System.Drawing.Size(217, 28);
            this.BtnShowDiseaseHistory.TabIndex = 7;
            this.BtnShowDiseaseHistory.Text = "Show Disease History";
            this.BtnShowDiseaseHistory.UseVisualStyleBackColor = true;
            // 
            // personalCodeDataGridViewTextBoxColumn
            // 
            this.personalCodeDataGridViewTextBoxColumn.DataPropertyName = "PersonalCode";
            this.personalCodeDataGridViewTextBoxColumn.HeaderText = "PersonalCode";
            this.personalCodeDataGridViewTextBoxColumn.MaxInputLength = 12;
            this.personalCodeDataGridViewTextBoxColumn.Name = "personalCodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 256;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MaxInputLength = 256;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MaxInputLength = 16;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MaxInputLength = 256;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShowDiseaseHistory);
            this.Controls.Add(this.BtnShowAllergies);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.LblAdress);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblPersonalCode);
            this.Controls.Add(this.TxtFldAdress);
            this.Controls.Add(this.TxtFldPhone);
            this.Controls.Add(this.TxtFldSurname);
            this.Controls.Add(this.TxtFldName);
            this.Controls.Add(this.TxtFldPersonalCode);
            this.Controls.Add(this.dtGrdPatient);
            this.MaximizeBox = false;
            this.Name = "Patients";
            this.Sizable = false;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdPatient;
        private AppData appData;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private AppDataTableAdapters.PatientTableAdapter patientTableAdapter;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldPersonalCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldAdress;
        private MaterialSkin.Controls.MaterialLabel LblPersonalCode;
        private MaterialSkin.Controls.MaterialLabel LblName;
        private MaterialSkin.Controls.MaterialLabel LblSurname;
        private MaterialSkin.Controls.MaterialLabel LblPhone;
        private MaterialSkin.Controls.MaterialLabel LblAdress;
        private MaterialSkin.Controls.MaterialFlatButton BtnSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnCancel;
        private MaterialSkin.Controls.MaterialFlatButton BtnEdit;
        private MaterialSkin.Controls.MaterialFlatButton BtnNew;
        private MaterialSkin.Controls.MaterialRaisedButton BtnShowAllergies;
        private MaterialSkin.Controls.MaterialRaisedButton BtnShowDiseaseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}
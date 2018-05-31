namespace CourseWorkForms.Views
{
    partial class Doctors
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
            this.BtnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.LblAdress = new MaterialSkin.Controls.MaterialLabel();
            this.LblPhone = new MaterialSkin.Controls.MaterialLabel();
            this.LblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.LblName = new MaterialSkin.Controls.MaterialLabel();
            this.LblPersonalCode = new MaterialSkin.Controls.MaterialLabel();
            this.TxtFldAdress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldPersonalCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtGrdDoctor = new System.Windows.Forms.DataGridView();
            this.appData = new CourseWorkForms.AppData();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new CourseWorkForms.AppDataTableAdapters.DoctorTableAdapter();
            this.personalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(698, 371);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = false;
            this.BtnSave.Size = new System.Drawing.Size(46, 36);
            this.BtnSave.TabIndex = 28;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(626, 371);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = false;
            this.BtnCancel.Size = new System.Drawing.Size(64, 36);
            this.BtnCancel.TabIndex = 27;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.Location = new System.Drawing.Point(577, 371);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Primary = false;
            this.BtnEdit.Size = new System.Drawing.Size(41, 36);
            this.BtnEdit.TabIndex = 26;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.AutoSize = true;
            this.BtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNew.Depth = 0;
            this.BtnNew.Location = new System.Drawing.Point(527, 371);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Primary = false;
            this.BtnNew.Size = new System.Drawing.Size(42, 36);
            this.BtnNew.TabIndex = 25;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // LblAdress
            // 
            this.LblAdress.AutoSize = true;
            this.LblAdress.Depth = 0;
            this.LblAdress.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdress.Location = new System.Drawing.Point(375, 227);
            this.LblAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdress.Name = "LblAdress";
            this.LblAdress.Size = new System.Drawing.Size(60, 19);
            this.LblAdress.TabIndex = 33;
            this.LblAdress.Text = "Adress:";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Depth = 0;
            this.LblPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPhone.Location = new System.Drawing.Point(375, 198);
            this.LblPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(55, 19);
            this.LblPhone.TabIndex = 32;
            this.LblPhone.Text = "Phone:";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Depth = 0;
            this.LblSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSurname.Location = new System.Drawing.Point(375, 169);
            this.LblSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(72, 19);
            this.LblSurname.TabIndex = 31;
            this.LblSurname.Text = "Surname:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Depth = 0;
            this.LblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblName.Location = new System.Drawing.Point(375, 140);
            this.LblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(53, 19);
            this.LblName.TabIndex = 30;
            this.LblName.Text = "Name:";
            // 
            // LblPersonalCode
            // 
            this.LblPersonalCode.AutoSize = true;
            this.LblPersonalCode.Depth = 0;
            this.LblPersonalCode.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblPersonalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPersonalCode.Location = new System.Drawing.Point(375, 111);
            this.LblPersonalCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblPersonalCode.Name = "LblPersonalCode";
            this.LblPersonalCode.Size = new System.Drawing.Size(109, 19);
            this.LblPersonalCode.TabIndex = 29;
            this.LblPersonalCode.Text = "Personal code:";
            // 
            // TxtFldAdress
            // 
            this.TxtFldAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Adress", true));
            this.TxtFldAdress.Depth = 0;
            this.TxtFldAdress.Hint = "";
            this.TxtFldAdress.Location = new System.Drawing.Point(490, 223);
            this.TxtFldAdress.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldAdress.Name = "TxtFldAdress";
            this.TxtFldAdress.PasswordChar = '\0';
            this.TxtFldAdress.SelectedText = "";
            this.TxtFldAdress.SelectionLength = 0;
            this.TxtFldAdress.SelectionStart = 0;
            this.TxtFldAdress.Size = new System.Drawing.Size(254, 23);
            this.TxtFldAdress.TabIndex = 22;
            this.TxtFldAdress.UseSystemPasswordChar = false;
            // 
            // TxtFldPhone
            // 
            this.TxtFldPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Phone", true));
            this.TxtFldPhone.Depth = 0;
            this.TxtFldPhone.Hint = "";
            this.TxtFldPhone.Location = new System.Drawing.Point(490, 194);
            this.TxtFldPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldPhone.Name = "TxtFldPhone";
            this.TxtFldPhone.PasswordChar = '\0';
            this.TxtFldPhone.SelectedText = "";
            this.TxtFldPhone.SelectionLength = 0;
            this.TxtFldPhone.SelectionStart = 0;
            this.TxtFldPhone.Size = new System.Drawing.Size(254, 23);
            this.TxtFldPhone.TabIndex = 21;
            this.TxtFldPhone.UseSystemPasswordChar = false;
            // 
            // TxtFldSurname
            // 
            this.TxtFldSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Surname", true));
            this.TxtFldSurname.Depth = 0;
            this.TxtFldSurname.Hint = "";
            this.TxtFldSurname.Location = new System.Drawing.Point(490, 165);
            this.TxtFldSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldSurname.Name = "TxtFldSurname";
            this.TxtFldSurname.PasswordChar = '\0';
            this.TxtFldSurname.SelectedText = "";
            this.TxtFldSurname.SelectionLength = 0;
            this.TxtFldSurname.SelectionStart = 0;
            this.TxtFldSurname.Size = new System.Drawing.Size(254, 23);
            this.TxtFldSurname.TabIndex = 20;
            this.TxtFldSurname.UseSystemPasswordChar = false;
            // 
            // TxtFldName
            // 
            this.TxtFldName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Name", true));
            this.TxtFldName.Depth = 0;
            this.TxtFldName.Hint = "";
            this.TxtFldName.Location = new System.Drawing.Point(490, 136);
            this.TxtFldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldName.Name = "TxtFldName";
            this.TxtFldName.PasswordChar = '\0';
            this.TxtFldName.SelectedText = "";
            this.TxtFldName.SelectionLength = 0;
            this.TxtFldName.SelectionStart = 0;
            this.TxtFldName.Size = new System.Drawing.Size(254, 23);
            this.TxtFldName.TabIndex = 19;
            this.TxtFldName.UseSystemPasswordChar = false;
            // 
            // TxtFldPersonalCode
            // 
            this.TxtFldPersonalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "PersonalCode", true));
            this.TxtFldPersonalCode.Depth = 0;
            this.TxtFldPersonalCode.Hint = "";
            this.TxtFldPersonalCode.Location = new System.Drawing.Point(490, 107);
            this.TxtFldPersonalCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldPersonalCode.Name = "TxtFldPersonalCode";
            this.TxtFldPersonalCode.PasswordChar = '\0';
            this.TxtFldPersonalCode.SelectedText = "";
            this.TxtFldPersonalCode.SelectionLength = 0;
            this.TxtFldPersonalCode.SelectionStart = 0;
            this.TxtFldPersonalCode.Size = new System.Drawing.Size(254, 23);
            this.TxtFldPersonalCode.TabIndex = 18;
            this.TxtFldPersonalCode.UseSystemPasswordChar = false;
            // 
            // dtGrdDoctor
            // 
            this.dtGrdDoctor.AutoGenerateColumns = false;
            this.dtGrdDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dtGrdDoctor.DataSource = this.doctorBindingSource;
            this.dtGrdDoctor.Location = new System.Drawing.Point(64, 107);
            this.dtGrdDoctor.Name = "dtGrdDoctor";
            this.dtGrdDoctor.Size = new System.Drawing.Size(305, 300);
            this.dtGrdDoctor.TabIndex = 17;
            this.dtGrdDoctor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtGrdDoctor_KeyDown);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.appData;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // personalCodeDataGridViewTextBoxColumn
            // 
            this.personalCodeDataGridViewTextBoxColumn.DataPropertyName = "PersonalCode";
            this.personalCodeDataGridViewTextBoxColumn.HeaderText = "PersonalCode";
            this.personalCodeDataGridViewTextBoxColumn.Name = "personalCodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.dtGrdDoctor);
            this.MaximizeBox = false;
            this.Name = "Doctors";
            this.Sizable = false;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton BtnSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnCancel;
        private MaterialSkin.Controls.MaterialFlatButton BtnEdit;
        private MaterialSkin.Controls.MaterialFlatButton BtnNew;
        private MaterialSkin.Controls.MaterialLabel LblAdress;
        private MaterialSkin.Controls.MaterialLabel LblPhone;
        private MaterialSkin.Controls.MaterialLabel LblSurname;
        private MaterialSkin.Controls.MaterialLabel LblName;
        private MaterialSkin.Controls.MaterialLabel LblPersonalCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldAdress;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldPersonalCode;
        private System.Windows.Forms.DataGridView dtGrdDoctor;
        private AppData appData;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private AppDataTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}
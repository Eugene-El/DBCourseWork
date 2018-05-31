namespace CourseWorkForms.Views
{
    partial class Stayings
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
            this.dtGrdStaying = new System.Windows.Forms.DataGridView();
            this.beginningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stayingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new CourseWorkForms.AppData();
            this.LblNameSurname = new MaterialSkin.Controls.MaterialLabel();
            this.stayingTableAdapter = new CourseWorkForms.AppDataTableAdapters.StayingTableAdapter();
            this.DtTmEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.DtTmBeginDate = new System.Windows.Forms.DateTimePicker();
            this.LblBeginDate = new MaterialSkin.Controls.MaterialLabel();
            this.LblWard = new MaterialSkin.Controls.MaterialLabel();
            this.CmBxWard = new System.Windows.Forms.ComboBox();
            this.wardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wardTableAdapter = new CourseWorkForms.AppDataTableAdapters.WardTableAdapter();
            this.BtnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnNew = new MaterialSkin.Controls.MaterialFlatButton();
            this.patientTableAdapter = new CourseWorkForms.AppDataTableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdStaying)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stayingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdStaying
            // 
            this.dtGrdStaying.AutoGenerateColumns = false;
            this.dtGrdStaying.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdStaying.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.beginningDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.wardNumberDataGridViewTextBoxColumn});
            this.dtGrdStaying.DataSource = this.stayingBindingSource;
            this.dtGrdStaying.Location = new System.Drawing.Point(59, 140);
            this.dtGrdStaying.Name = "dtGrdStaying";
            this.dtGrdStaying.Size = new System.Drawing.Size(305, 264);
            this.dtGrdStaying.TabIndex = 0;
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
            // wardNumberDataGridViewTextBoxColumn
            // 
            this.wardNumberDataGridViewTextBoxColumn.DataPropertyName = "WardNumber";
            this.wardNumberDataGridViewTextBoxColumn.HeaderText = "WardNumber";
            this.wardNumberDataGridViewTextBoxColumn.Name = "wardNumberDataGridViewTextBoxColumn";
            this.wardNumberDataGridViewTextBoxColumn.Width = 90;
            // 
            // stayingBindingSource
            // 
            this.stayingBindingSource.DataMember = "Staying";
            this.stayingBindingSource.DataSource = this.appData;
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
            // stayingTableAdapter
            // 
            this.stayingTableAdapter.ClearBeforeFill = true;
            // 
            // DtTmEndDate
            // 
            this.DtTmEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stayingBindingSource, "EndDate", true));
            this.DtTmEndDate.Location = new System.Drawing.Point(459, 166);
            this.DtTmEndDate.Name = "DtTmEndDate";
            this.DtTmEndDate.Size = new System.Drawing.Size(273, 20);
            this.DtTmEndDate.TabIndex = 9;
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Depth = 0;
            this.LblEndDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEndDate.Location = new System.Drawing.Point(370, 168);
            this.LblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(71, 19);
            this.LblEndDate.TabIndex = 8;
            this.LblEndDate.Text = "End date:";
            // 
            // DtTmBeginDate
            // 
            this.DtTmBeginDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stayingBindingSource, "BeginningDate", true));
            this.DtTmBeginDate.Location = new System.Drawing.Point(459, 140);
            this.DtTmBeginDate.Name = "DtTmBeginDate";
            this.DtTmBeginDate.Size = new System.Drawing.Size(273, 20);
            this.DtTmBeginDate.TabIndex = 7;
            // 
            // LblBeginDate
            // 
            this.LblBeginDate.AutoSize = true;
            this.LblBeginDate.Depth = 0;
            this.LblBeginDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblBeginDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblBeginDate.Location = new System.Drawing.Point(370, 142);
            this.LblBeginDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblBeginDate.Name = "LblBeginDate";
            this.LblBeginDate.Size = new System.Drawing.Size(83, 19);
            this.LblBeginDate.TabIndex = 6;
            this.LblBeginDate.Text = "Begin date:";
            // 
            // LblWard
            // 
            this.LblWard.AutoSize = true;
            this.LblWard.Depth = 0;
            this.LblWard.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblWard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblWard.Location = new System.Drawing.Point(370, 194);
            this.LblWard.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblWard.Name = "LblWard";
            this.LblWard.Size = new System.Drawing.Size(47, 19);
            this.LblWard.TabIndex = 10;
            this.LblWard.Text = "Ward:";
            // 
            // CmBxWard
            // 
            this.CmBxWard.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stayingBindingSource, "WardNumber", true));
            this.CmBxWard.DataSource = this.wardBindingSource;
            this.CmBxWard.DisplayMember = "Number";
            this.CmBxWard.FormattingEnabled = true;
            this.CmBxWard.Location = new System.Drawing.Point(459, 192);
            this.CmBxWard.Name = "CmBxWard";
            this.CmBxWard.Size = new System.Drawing.Size(273, 21);
            this.CmBxWard.TabIndex = 11;
            this.CmBxWard.ValueMember = "Number";
            // 
            // wardBindingSource
            // 
            this.wardBindingSource.DataMember = "Ward";
            this.wardBindingSource.DataSource = this.appData;
            // 
            // wardTableAdapter
            // 
            this.wardTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(686, 368);
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
            this.BtnCancel.Location = new System.Drawing.Point(614, 368);
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
            this.BtnEdit.Location = new System.Drawing.Point(565, 368);
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
            this.BtnNew.Location = new System.Drawing.Point(515, 368);
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
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // Stayings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.CmBxWard);
            this.Controls.Add(this.LblWard);
            this.Controls.Add(this.DtTmEndDate);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.DtTmBeginDate);
            this.Controls.Add(this.LblBeginDate);
            this.Controls.Add(this.LblNameSurname);
            this.Controls.Add(this.dtGrdStaying);
            this.Name = "Stayings";
            this.Text = "Stayings";
            this.Load += new System.EventHandler(this.Stayings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdStaying)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stayingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdStaying;
        private MaterialSkin.Controls.MaterialLabel LblNameSurname;
        private AppData appData;
        private System.Windows.Forms.BindingSource stayingBindingSource;
        private AppDataTableAdapters.StayingTableAdapter stayingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker DtTmEndDate;
        private MaterialSkin.Controls.MaterialLabel LblEndDate;
        private System.Windows.Forms.DateTimePicker DtTmBeginDate;
        private MaterialSkin.Controls.MaterialLabel LblBeginDate;
        private MaterialSkin.Controls.MaterialLabel LblWard;
        private System.Windows.Forms.ComboBox CmBxWard;
        private System.Windows.Forms.BindingSource wardBindingSource;
        private AppDataTableAdapters.WardTableAdapter wardTableAdapter;
        private MaterialSkin.Controls.MaterialFlatButton BtnSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnCancel;
        private MaterialSkin.Controls.MaterialFlatButton BtnEdit;
        private MaterialSkin.Controls.MaterialFlatButton BtnNew;
        private AppDataTableAdapters.PatientTableAdapter patientTableAdapter;
    }
}
namespace CourseWorkForms.Views
{
    partial class Wards
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
            this.dtGrdWard = new System.Windows.Forms.DataGridView();
            this.appData = new CourseWorkForms.AppData();
            this.wardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wardTableAdapter = new CourseWorkForms.AppDataTableAdapters.WardTableAdapter();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LblFloor = new MaterialSkin.Controls.MaterialLabel();
            this.LblHousing = new MaterialSkin.Controls.MaterialLabel();
            this.TxtFldNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldFloor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtFldHousing = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSave = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnNew = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdWard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdWard
            // 
            this.dtGrdWard.AutoGenerateColumns = false;
            this.dtGrdWard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdWard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.housingDataGridViewTextBoxColumn});
            this.dtGrdWard.DataSource = this.wardBindingSource;
            this.dtGrdWard.Location = new System.Drawing.Point(55, 105);
            this.dtGrdWard.Name = "dtGrdWard";
            this.dtGrdWard.Size = new System.Drawing.Size(305, 300);
            this.dtGrdWard.TabIndex = 0;
            this.dtGrdWard.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtGrdWard_EditingControlShowing);
            this.dtGrdWard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtGrdWard_KeyDown);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 140;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.Width = 60;
            // 
            // housingDataGridViewTextBoxColumn
            // 
            this.housingDataGridViewTextBoxColumn.DataPropertyName = "Housing";
            this.housingDataGridViewTextBoxColumn.HeaderText = "Housing";
            this.housingDataGridViewTextBoxColumn.Name = "housingDataGridViewTextBoxColumn";
            this.housingDataGridViewTextBoxColumn.Width = 60;
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Depth = 0;
            this.LblNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblNumber.Location = new System.Drawing.Point(366, 105);
            this.LblNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(66, 19);
            this.LblNumber.TabIndex = 1;
            this.LblNumber.Text = "Number:";
            // 
            // LblFloor
            // 
            this.LblFloor.AutoSize = true;
            this.LblFloor.Depth = 0;
            this.LblFloor.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFloor.Location = new System.Drawing.Point(366, 134);
            this.LblFloor.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFloor.Name = "LblFloor";
            this.LblFloor.Size = new System.Drawing.Size(48, 19);
            this.LblFloor.TabIndex = 2;
            this.LblFloor.Text = "Floor:";
            // 
            // LblHousing
            // 
            this.LblHousing.AutoSize = true;
            this.LblHousing.Depth = 0;
            this.LblHousing.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblHousing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblHousing.Location = new System.Drawing.Point(366, 163);
            this.LblHousing.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHousing.Name = "LblHousing";
            this.LblHousing.Size = new System.Drawing.Size(69, 19);
            this.LblHousing.TabIndex = 3;
            this.LblHousing.Text = "Housing:";
            // 
            // TxtFldNumber
            // 
            this.TxtFldNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wardBindingSource, "Number", true));
            this.TxtFldNumber.Depth = 0;
            this.TxtFldNumber.Hint = "";
            this.TxtFldNumber.Location = new System.Drawing.Point(438, 101);
            this.TxtFldNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldNumber.Name = "TxtFldNumber";
            this.TxtFldNumber.PasswordChar = '\0';
            this.TxtFldNumber.SelectedText = "";
            this.TxtFldNumber.SelectionLength = 0;
            this.TxtFldNumber.SelectionStart = 0;
            this.TxtFldNumber.Size = new System.Drawing.Size(291, 23);
            this.TxtFldNumber.TabIndex = 4;
            this.TxtFldNumber.UseSystemPasswordChar = false;
            // 
            // TxtFldFloor
            // 
            this.TxtFldFloor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wardBindingSource, "Floor", true));
            this.TxtFldFloor.Depth = 0;
            this.TxtFldFloor.Hint = "";
            this.TxtFldFloor.Location = new System.Drawing.Point(438, 130);
            this.TxtFldFloor.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldFloor.Name = "TxtFldFloor";
            this.TxtFldFloor.PasswordChar = '\0';
            this.TxtFldFloor.SelectedText = "";
            this.TxtFldFloor.SelectionLength = 0;
            this.TxtFldFloor.SelectionStart = 0;
            this.TxtFldFloor.Size = new System.Drawing.Size(291, 23);
            this.TxtFldFloor.TabIndex = 5;
            this.TxtFldFloor.UseSystemPasswordChar = false;
            // 
            // TxtFldHousing
            // 
            this.TxtFldHousing.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wardBindingSource, "Housing", true));
            this.TxtFldHousing.Depth = 0;
            this.TxtFldHousing.Hint = "";
            this.TxtFldHousing.Location = new System.Drawing.Point(438, 159);
            this.TxtFldHousing.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFldHousing.Name = "TxtFldHousing";
            this.TxtFldHousing.PasswordChar = '\0';
            this.TxtFldHousing.SelectedText = "";
            this.TxtFldHousing.SelectionLength = 0;
            this.TxtFldHousing.SelectionStart = 0;
            this.TxtFldHousing.Size = new System.Drawing.Size(291, 23);
            this.TxtFldHousing.TabIndex = 6;
            this.TxtFldHousing.UseSystemPasswordChar = false;
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSave.Depth = 0;
            this.BtnSave.Location = new System.Drawing.Point(683, 369);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Primary = false;
            this.BtnSave.Size = new System.Drawing.Size(46, 36);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSize = true;
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.Depth = 0;
            this.BtnCancel.Location = new System.Drawing.Point(611, 369);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Primary = false;
            this.BtnCancel.Size = new System.Drawing.Size(64, 36);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.Location = new System.Drawing.Point(562, 369);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Primary = false;
            this.BtnEdit.Size = new System.Drawing.Size(41, 36);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.AutoSize = true;
            this.BtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNew.Depth = 0;
            this.BtnNew.Location = new System.Drawing.Point(512, 369);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Primary = false;
            this.BtnNew.Size = new System.Drawing.Size(42, 36);
            this.BtnNew.TabIndex = 7;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Wards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TxtFldHousing);
            this.Controls.Add(this.TxtFldFloor);
            this.Controls.Add(this.TxtFldNumber);
            this.Controls.Add(this.LblHousing);
            this.Controls.Add(this.LblFloor);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.dtGrdWard);
            this.MaximizeBox = false;
            this.Name = "Wards";
            this.Sizable = false;
            this.Text = "Wards";
            this.Load += new System.EventHandler(this.Wards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdWard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdWard;
        private AppData appData;
        private System.Windows.Forms.BindingSource wardBindingSource;
        private AppDataTableAdapters.WardTableAdapter wardTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housingDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel LblNumber;
        private MaterialSkin.Controls.MaterialLabel LblFloor;
        private MaterialSkin.Controls.MaterialLabel LblHousing;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldFloor;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFldHousing;
        private MaterialSkin.Controls.MaterialFlatButton BtnSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnCancel;
        private MaterialSkin.Controls.MaterialFlatButton BtnEdit;
        private MaterialSkin.Controls.MaterialFlatButton BtnNew;
    }
}
namespace Danilov_stadium
{
    partial class StaffListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffListForm));
            this.DGV_Staff = new System.Windows.Forms.DataGridView();
            this.team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.staffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isheadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Staff
            // 
            this.DGV_Staff.AllowUserToAddRows = false;
            this.DGV_Staff.AllowUserToDeleteRows = false;
            this.DGV_Staff.AutoGenerateColumns = false;
            this.DGV_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffidDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.team,
            this.role,
            this.isheadDataGridViewCheckBoxColumn,
            this.team_id,
            this.role_id});
            this.DGV_Staff.DataSource = this.staffBindingSource;
            this.DGV_Staff.Location = new System.Drawing.Point(12, 28);
            this.DGV_Staff.Name = "DGV_Staff";
            this.DGV_Staff.ReadOnly = true;
            this.DGV_Staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Staff.Size = new System.Drawing.Size(1087, 241);
            this.DGV_Staff.TabIndex = 0;
            this.DGV_Staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Staff_CellContentClick);
            // 
            // team
            // 
            this.team.HeaderText = "Команда";
            this.team.Name = "team";
            this.team.ReadOnly = true;
            // 
            // role
            // 
            this.role.HeaderText = "Должность";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // team_id
            // 
            this.team_id.DataPropertyName = "team_id";
            this.team_id.HeaderText = "team_id";
            this.team_id.Name = "team_id";
            this.team_id.ReadOnly = true;
            this.team_id.Visible = false;
            // 
            // role_id
            // 
            this.role_id.DataPropertyName = "role_id";
            this.role_id.HeaderText = "role_id";
            this.role_id.Name = "role_id";
            this.role_id.ReadOnly = true;
            this.role_id.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-69, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add.Location = new System.Drawing.Point(753, 275);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 2;
            this.bt_add.Text = "Добавить";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.Bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_edit.Location = new System.Drawing.Point(833, 275);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(99, 23);
            this.bt_edit.TabIndex = 2;
            this.bt_edit.Text = "Редактировать";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.Bt_edit_Click);
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.Location = new System.Drawing.Point(1023, 275);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 2;
            this.bt_close.Text = "Закрыть";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_delete.Location = new System.Drawing.Point(942, 275);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // staffidDataGridViewTextBoxColumn
            // 
            this.staffidDataGridViewTextBoxColumn.DataPropertyName = "staff_id";
            this.staffidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.staffidDataGridViewTextBoxColumn.Name = "staffidDataGridViewTextBoxColumn";
            this.staffidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isheadDataGridViewCheckBoxColumn
            // 
            this.isheadDataGridViewCheckBoxColumn.DataPropertyName = "is_head";
            this.isheadDataGridViewCheckBoxColumn.HeaderText = "Глава службы?";
            this.isheadDataGridViewCheckBoxColumn.Name = "isheadDataGridViewCheckBoxColumn";
            this.isheadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Danilov_stadium.staff);
            this.staffBindingSource.CurrentChanged += new System.EventHandler(this.StaffBindingSource_CurrentChanged);
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 321);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Staff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffListForm";
            this.Text = "Список персонала";
            this.Load += new System.EventHandler(this.StaffListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Staff;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isheadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_id;
        private System.Windows.Forms.Button bt_delete;
    }
}
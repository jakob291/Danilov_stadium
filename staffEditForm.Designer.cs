namespace Danilov_stadium
{
    partial class staffEditForm
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
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label is_headLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label role_idLabel;
            System.Windows.Forms.Label team_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffEditForm));
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.is_headCheckBox = new System.Windows.Forms.CheckBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.role_nameComboBox = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.team_nameComboBox = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            first_nameLabel = new System.Windows.Forms.Label();
            is_headLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            role_idLabel = new System.Windows.Forms.Label();
            team_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(18, 37);
            first_nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(29, 13);
            first_nameLabel.TabIndex = 1;
            first_nameLabel.Text = "Имя";
            // 
            // is_headLabel
            // 
            is_headLabel.AutoSize = true;
            is_headLabel.Location = new System.Drawing.Point(18, 65);
            is_headLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            is_headLabel.Name = "is_headLabel";
            is_headLabel.Size = new System.Drawing.Size(79, 13);
            is_headLabel.TabIndex = 3;
            is_headLabel.Text = "Глава службы";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(18, 13);
            last_nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(56, 13);
            last_nameLabel.TabIndex = 5;
            last_nameLabel.Text = "Фамилия";
            // 
            // role_idLabel
            // 
            role_idLabel.AutoSize = true;
            role_idLabel.Location = new System.Drawing.Point(18, 92);
            role_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            role_idLabel.Name = "role_idLabel";
            role_idLabel.Size = new System.Drawing.Size(65, 13);
            role_idLabel.TabIndex = 7;
            role_idLabel.Text = "Должность";
            // 
            // team_idLabel
            // 
            team_idLabel.AutoSize = true;
            team_idLabel.Location = new System.Drawing.Point(18, 118);
            team_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            team_idLabel.Name = "team_idLabel";
            team_idLabel.Size = new System.Drawing.Size(52, 13);
            team_idLabel.TabIndex = 9;
            team_idLabel.Text = "Команда";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(127, 34);
            this.first_nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_nameTextBox.TabIndex = 2;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Danilov_stadium.staff);
            // 
            // is_headCheckBox
            // 
            this.is_headCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.staffBindingSource, "is_head", true));
            this.is_headCheckBox.Location = new System.Drawing.Point(127, 64);
            this.is_headCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.is_headCheckBox.Name = "is_headCheckBox";
            this.is_headCheckBox.Size = new System.Drawing.Size(78, 20);
            this.is_headCheckBox.TabIndex = 4;
            this.is_headCheckBox.Text = "Да";
            this.is_headCheckBox.UseVisualStyleBackColor = true;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(127, 10);
            this.last_nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_nameTextBox.TabIndex = 1;
            // 
            // role_nameComboBox
            // 
            this.role_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "role_name", true));
            this.role_nameComboBox.DataSource = this.rolesBindingSource;
            this.role_nameComboBox.DisplayMember = "role_name";
            this.role_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_nameComboBox.FormattingEnabled = true;
            this.role_nameComboBox.Location = new System.Drawing.Point(127, 89);
            this.role_nameComboBox.Name = "role_nameComboBox";
            this.role_nameComboBox.Size = new System.Drawing.Size(100, 21);
            this.role_nameComboBox.TabIndex = 5;
            this.role_nameComboBox.ValueMember = "role_id";
            this.role_nameComboBox.SelectedIndexChanged += new System.EventHandler(this.Role_nameComboBox_SelectedIndexChanged);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(Danilov_stadium.roles);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 156);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 7;
            this.bt_save.Text = "Сохранить";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(152, 156);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Отмена";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.Bt_cancel_Click);
            // 
            // team_nameComboBox
            // 
            this.team_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "team_name", true));
            this.team_nameComboBox.DataSource = this.teamsBindingSource;
            this.team_nameComboBox.DisplayMember = "team_name";
            this.team_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team_nameComboBox.FormattingEnabled = true;
            this.team_nameComboBox.Location = new System.Drawing.Point(127, 115);
            this.team_nameComboBox.Name = "team_nameComboBox";
            this.team_nameComboBox.Size = new System.Drawing.Size(100, 21);
            this.team_nameComboBox.TabIndex = 6;
            this.team_nameComboBox.ValueMember = "team_id";
            this.team_nameComboBox.SelectedIndexChanged += new System.EventHandler(this.Team_nameComboBox_SelectedIndexChanged);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(Danilov_stadium.teams);
            // 
            // staffEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 206);
            this.Controls.Add(this.team_nameComboBox);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.role_nameComboBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(is_headLabel);
            this.Controls.Add(this.is_headCheckBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(role_idLabel);
            this.Controls.Add(team_idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "staffEditForm";
            this.Text = "Редактор персонала";
            this.Load += new System.EventHandler(this.StaffEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.CheckBox is_headCheckBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.ComboBox role_nameComboBox;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.ComboBox team_nameComboBox;
    }
}
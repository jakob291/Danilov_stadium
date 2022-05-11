namespace Danilov_stadium
{
    partial class roles_evtypes_edit
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
            System.Windows.Forms.Label role_nameLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roles_evtypes_edit));
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roles_list = new System.Windows.Forms.ListBox();
            this.tb_new_role = new System.Windows.Forms.TextBox();
            this.bt_add_role = new System.Windows.Forms.Button();
            this.bt_delete_role = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lb_event_types = new System.Windows.Forms.ListBox();
            this.eventtypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_new_eventtype = new System.Windows.Forms.TextBox();
            this.bt_add_eventtype = new System.Windows.Forms.Button();
            this.bt_delete_eventtype = new System.Windows.Forms.Button();
            role_nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventtypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // role_nameLabel
            // 
            role_nameLabel.AutoSize = true;
            role_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            role_nameLabel.Location = new System.Drawing.Point(12, 9);
            role_nameLabel.Name = "role_nameLabel";
            role_nameLabel.Size = new System.Drawing.Size(104, 20);
            role_nameLabel.TabIndex = 2;
            role_nameLabel.Text = "Должности";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(172, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 20);
            label1.TabIndex = 2;
            label1.Text = "Типы событий";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(Danilov_stadium.roles);
            this.rolesBindingSource.CurrentChanged += new System.EventHandler(this.RolesBindingSource_CurrentChanged);
            // 
            // roles_list
            // 
            this.roles_list.DataSource = this.rolesBindingSource;
            this.roles_list.DisplayMember = "role_name";
            this.roles_list.FormattingEnabled = true;
            this.roles_list.Location = new System.Drawing.Point(12, 35);
            this.roles_list.Name = "roles_list";
            this.roles_list.Size = new System.Drawing.Size(120, 95);
            this.roles_list.TabIndex = 3;
            this.roles_list.ValueMember = "role_id";
            this.roles_list.SelectedIndexChanged += new System.EventHandler(this.Roles_list_SelectedIndexChanged);
            // 
            // tb_new_role
            // 
            this.tb_new_role.Location = new System.Drawing.Point(12, 173);
            this.tb_new_role.Name = "tb_new_role";
            this.tb_new_role.Size = new System.Drawing.Size(120, 20);
            this.tb_new_role.TabIndex = 4;
            // 
            // bt_add_role
            // 
            this.bt_add_role.BackgroundImage = global::Danilov_stadium.Properties.Resources.green_add_button_12023;
            this.bt_add_role.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_add_role.Location = new System.Drawing.Point(12, 136);
            this.bt_add_role.Name = "bt_add_role";
            this.bt_add_role.Size = new System.Drawing.Size(30, 31);
            this.bt_add_role.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bt_add_role, "Чтобы добавить должность введите новую роль в окно ниже и нажмите эту кнопку");
            this.bt_add_role.UseVisualStyleBackColor = true;
            this.bt_add_role.Click += new System.EventHandler(this.Bt_add_Click);
            // 
            // bt_delete_role
            // 
            this.bt_delete_role.BackgroundImage = global::Danilov_stadium.Properties.Resources.cancel_close_10374;
            this.bt_delete_role.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_delete_role.Location = new System.Drawing.Point(102, 136);
            this.bt_delete_role.Name = "bt_delete_role";
            this.bt_delete_role.Size = new System.Drawing.Size(30, 31);
            this.bt_delete_role.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bt_delete_role, "Чтобы удалить должность выберите ее и нажмите кнопку");
            this.bt_delete_role.UseVisualStyleBackColor = true;
            this.bt_delete_role.Click += new System.EventHandler(this.Bt_delete_Click);
            // 
            // lb_event_types
            // 
            this.lb_event_types.DataSource = this.eventtypesBindingSource;
            this.lb_event_types.DisplayMember = "event_type_name";
            this.lb_event_types.FormattingEnabled = true;
            this.lb_event_types.Location = new System.Drawing.Point(172, 35);
            this.lb_event_types.Name = "lb_event_types";
            this.lb_event_types.Size = new System.Drawing.Size(120, 95);
            this.lb_event_types.TabIndex = 3;
            this.lb_event_types.ValueMember = "event_type_id";
            this.lb_event_types.SelectedIndexChanged += new System.EventHandler(this.Roles_list_SelectedIndexChanged);
            // 
            // eventtypesBindingSource
            // 
            this.eventtypesBindingSource.DataSource = typeof(Danilov_stadium.event_types);
            // 
            // tb_new_eventtype
            // 
            this.tb_new_eventtype.Location = new System.Drawing.Point(172, 173);
            this.tb_new_eventtype.Name = "tb_new_eventtype";
            this.tb_new_eventtype.Size = new System.Drawing.Size(120, 20);
            this.tb_new_eventtype.TabIndex = 4;
            // 
            // bt_add_eventtype
            // 
            this.bt_add_eventtype.BackgroundImage = global::Danilov_stadium.Properties.Resources.green_add_button_12023;
            this.bt_add_eventtype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_add_eventtype.Location = new System.Drawing.Point(172, 136);
            this.bt_add_eventtype.Name = "bt_add_eventtype";
            this.bt_add_eventtype.Size = new System.Drawing.Size(30, 31);
            this.bt_add_eventtype.TabIndex = 5;
            this.bt_add_eventtype.UseVisualStyleBackColor = true;
            this.bt_add_eventtype.Click += new System.EventHandler(this.Bt_add_eventtype_Click);
            // 
            // bt_delete_eventtype
            // 
            this.bt_delete_eventtype.BackgroundImage = global::Danilov_stadium.Properties.Resources.cancel_close_10374;
            this.bt_delete_eventtype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_delete_eventtype.Location = new System.Drawing.Point(262, 136);
            this.bt_delete_eventtype.Name = "bt_delete_eventtype";
            this.bt_delete_eventtype.Size = new System.Drawing.Size(30, 31);
            this.bt_delete_eventtype.TabIndex = 5;
            this.bt_delete_eventtype.UseVisualStyleBackColor = true;
            this.bt_delete_eventtype.Click += new System.EventHandler(this.Bt_delete_eventtype_Click);
            // 
            // roles_evtypes_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 220);
            this.Controls.Add(this.bt_delete_eventtype);
            this.Controls.Add(this.bt_delete_role);
            this.Controls.Add(this.bt_add_eventtype);
            this.Controls.Add(this.bt_add_role);
            this.Controls.Add(this.tb_new_eventtype);
            this.Controls.Add(this.tb_new_role);
            this.Controls.Add(this.lb_event_types);
            this.Controls.Add(label1);
            this.Controls.Add(this.roles_list);
            this.Controls.Add(role_nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "roles_evtypes_edit";
            this.Text = "Редактирование должностей и типов событий";
            this.Load += new System.EventHandler(this.Roles_evtypes_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventtypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.ListBox roles_list;
        private System.Windows.Forms.TextBox tb_new_role;
        private System.Windows.Forms.Button bt_add_role;
        private System.Windows.Forms.Button bt_delete_role;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lb_event_types;
        private System.Windows.Forms.TextBox tb_new_eventtype;
        private System.Windows.Forms.Button bt_add_eventtype;
        private System.Windows.Forms.Button bt_delete_eventtype;
        private System.Windows.Forms.BindingSource eventtypesBindingSource;
    }
}
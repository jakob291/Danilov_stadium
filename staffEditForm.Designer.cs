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
            System.Windows.Forms.Label role_idLabel1;
            System.Windows.Forms.Label role_nameLabel;
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.is_headCheckBox = new System.Windows.Forms.CheckBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.role_idTextBox = new System.Windows.Forms.TextBox();
            this.team_idTextBox = new System.Windows.Forms.TextBox();
            this.role_idTextBox1 = new System.Windows.Forms.TextBox();
            this.role_nameTextBox = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            first_nameLabel = new System.Windows.Forms.Label();
            is_headLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            role_idLabel = new System.Windows.Forms.Label();
            team_idLabel = new System.Windows.Forms.Label();
            role_idLabel1 = new System.Windows.Forms.Label();
            role_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(24, 21);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(74, 17);
            first_nameLabel.TabIndex = 1;
            first_nameLabel.Text = "first name:";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(104, 18);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(104, 22);
            this.first_nameTextBox.TabIndex = 2;
            // 
            // is_headLabel
            // 
            is_headLabel.AutoSize = true;
            is_headLabel.Location = new System.Drawing.Point(24, 51);
            is_headLabel.Name = "is_headLabel";
            is_headLabel.Size = new System.Drawing.Size(58, 17);
            is_headLabel.TabIndex = 3;
            is_headLabel.Text = "is head:";
            // 
            // is_headCheckBox
            // 
            this.is_headCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.staffBindingSource, "is_head", true));
            this.is_headCheckBox.Location = new System.Drawing.Point(104, 46);
            this.is_headCheckBox.Name = "is_headCheckBox";
            this.is_headCheckBox.Size = new System.Drawing.Size(104, 24);
            this.is_headCheckBox.TabIndex = 4;
            this.is_headCheckBox.Text = "checkBox1";
            this.is_headCheckBox.UseVisualStyleBackColor = true;
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(24, 79);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(73, 17);
            last_nameLabel.TabIndex = 5;
            last_nameLabel.Text = "last name:";
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(104, 76);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(104, 22);
            this.last_nameTextBox.TabIndex = 6;
            // 
            // role_idLabel
            // 
            role_idLabel.AutoSize = true;
            role_idLabel.Location = new System.Drawing.Point(24, 107);
            role_idLabel.Name = "role_idLabel";
            role_idLabel.Size = new System.Drawing.Size(51, 17);
            role_idLabel.TabIndex = 7;
            role_idLabel.Text = "role id:";
            // 
            // role_idTextBox
            // 
            this.role_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "role_id", true));
            this.role_idTextBox.Location = new System.Drawing.Point(104, 104);
            this.role_idTextBox.Name = "role_idTextBox";
            this.role_idTextBox.Size = new System.Drawing.Size(104, 22);
            this.role_idTextBox.TabIndex = 8;
            // 
            // team_idLabel
            // 
            team_idLabel.AutoSize = true;
            team_idLabel.Location = new System.Drawing.Point(24, 135);
            team_idLabel.Name = "team_idLabel";
            team_idLabel.Size = new System.Drawing.Size(58, 17);
            team_idLabel.TabIndex = 9;
            team_idLabel.Text = "team id:";
            // 
            // team_idTextBox
            // 
            this.team_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "team_id", true));
            this.team_idTextBox.Location = new System.Drawing.Point(104, 132);
            this.team_idTextBox.Name = "team_idTextBox";
            this.team_idTextBox.Size = new System.Drawing.Size(104, 22);
            this.team_idTextBox.TabIndex = 10;
            // 
            // role_idLabel1
            // 
            role_idLabel1.AutoSize = true;
            role_idLabel1.Location = new System.Drawing.Point(24, 197);
            role_idLabel1.Name = "role_idLabel1";
            role_idLabel1.Size = new System.Drawing.Size(51, 17);
            role_idLabel1.TabIndex = 11;
            role_idLabel1.Text = "role id:";
            // 
            // role_idTextBox1
            // 
            this.role_idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "roles.role_id", true));
            this.role_idTextBox1.Location = new System.Drawing.Point(105, 194);
            this.role_idTextBox1.Name = "role_idTextBox1";
            this.role_idTextBox1.Size = new System.Drawing.Size(100, 22);
            this.role_idTextBox1.TabIndex = 12;
            // 
            // role_nameLabel
            // 
            role_nameLabel.AutoSize = true;
            role_nameLabel.Location = new System.Drawing.Point(24, 225);
            role_nameLabel.Name = "role_nameLabel";
            role_nameLabel.Size = new System.Drawing.Size(75, 17);
            role_nameLabel.TabIndex = 13;
            role_nameLabel.Text = "role name:";
            // 
            // role_nameTextBox
            // 
            this.role_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "roles.role_name", true));
            this.role_nameTextBox.Location = new System.Drawing.Point(105, 222);
            this.role_nameTextBox.Name = "role_nameTextBox";
            this.role_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.role_nameTextBox.TabIndex = 14;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Danilov_stadium.staff);
            // 
            // staffEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 355);
            this.Controls.Add(role_idLabel1);
            this.Controls.Add(this.role_idTextBox1);
            this.Controls.Add(role_nameLabel);
            this.Controls.Add(this.role_nameTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(is_headLabel);
            this.Controls.Add(this.is_headCheckBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(role_idLabel);
            this.Controls.Add(this.role_idTextBox);
            this.Controls.Add(team_idLabel);
            this.Controls.Add(this.team_idTextBox);
            this.Name = "staffEditForm";
            this.Text = "staffEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.CheckBox is_headCheckBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox role_idTextBox;
        private System.Windows.Forms.TextBox team_idTextBox;
        private System.Windows.Forms.TextBox role_idTextBox1;
        private System.Windows.Forms.TextBox role_nameTextBox;
    }
}
namespace Danilov_stadium
{
    partial class teamsEditForm
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label emblemLabel;
            System.Windows.Forms.Label team_nameLabel;
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.emblemTextBox = new System.Windows.Forms.TextBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.team_nameTextBox = new System.Windows.Forms.TextBox();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            emblemLabel = new System.Windows.Forms.Label();
            team_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(24, 122);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(33, 17);
            cityLabel.TabIndex = 1;
            cityLabel.Text = "city:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(112, 119);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 2;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(24, 150);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(59, 17);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(112, 147);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 22);
            this.countryTextBox.TabIndex = 4;
            // 
            // emblemLabel
            // 
            emblemLabel.AutoSize = true;
            emblemLabel.Location = new System.Drawing.Point(24, 178);
            emblemLabel.Name = "emblemLabel";
            emblemLabel.Size = new System.Drawing.Size(61, 17);
            emblemLabel.TabIndex = 5;
            emblemLabel.Text = "emblem:";
            // 
            // emblemTextBox
            // 
            this.emblemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "emblem", true));
            this.emblemTextBox.Location = new System.Drawing.Point(112, 175);
            this.emblemTextBox.Name = "emblemTextBox";
            this.emblemTextBox.Size = new System.Drawing.Size(100, 22);
            this.emblemTextBox.TabIndex = 6;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(Danilov_stadium.teams);
            // 
            // team_nameLabel
            // 
            team_nameLabel.AutoSize = true;
            team_nameLabel.Location = new System.Drawing.Point(24, 92);
            team_nameLabel.Name = "team_nameLabel";
            team_nameLabel.Size = new System.Drawing.Size(82, 17);
            team_nameLabel.TabIndex = 8;
            team_nameLabel.Text = "team name:";
            // 
            // team_nameTextBox
            // 
            this.team_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "team_name", true));
            this.team_nameTextBox.Location = new System.Drawing.Point(112, 89);
            this.team_nameTextBox.Name = "team_nameTextBox";
            this.team_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.team_nameTextBox.TabIndex = 9;
            // 
            // teamsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(team_nameLabel);
            this.Controls.Add(this.team_nameTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(emblemLabel);
            this.Controls.Add(this.emblemTextBox);
            this.Name = "teamsEditForm";
            this.Text = "teamsEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox emblemTextBox;
        private System.Windows.Forms.TextBox team_nameTextBox;
    }
}
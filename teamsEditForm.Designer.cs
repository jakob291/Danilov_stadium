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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teamsEditForm));
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.team_nameTextBox = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.pb_emblem = new System.Windows.Forms.PictureBox();
            this.bt__selectImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_cancel = new System.Windows.Forms.Button();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            emblemLabel = new System.Windows.Forms.Label();
            team_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_emblem)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(19, 118);
            cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(40, 13);
            cityLabel.TabIndex = 1;
            cityLabel.Text = "Город:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(19, 89);
            countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(43, 13);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Страна";
            // 
            // emblemLabel
            // 
            emblemLabel.AutoSize = true;
            emblemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emblemLabel.Location = new System.Drawing.Point(223, 18);
            emblemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emblemLabel.Name = "emblemLabel";
            emblemLabel.Size = new System.Drawing.Size(91, 24);
            emblemLabel.TabIndex = 5;
            emblemLabel.Text = "Эмблема";
            // 
            // team_nameLabel
            // 
            team_nameLabel.AutoSize = true;
            team_nameLabel.Location = new System.Drawing.Point(19, 60);
            team_nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            team_nameLabel.Name = "team_nameLabel";
            team_nameLabel.Size = new System.Drawing.Size(57, 13);
            team_nameLabel.TabIndex = 8;
            team_nameLabel.Text = "Название";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(85, 115);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(76, 20);
            this.cityTextBox.TabIndex = 2;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(Danilov_stadium.teams);
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(85, 86);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(76, 20);
            this.countryTextBox.TabIndex = 4;
            // 
            // team_nameTextBox
            // 
            this.team_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamsBindingSource, "team_name", true));
            this.team_nameTextBox.Location = new System.Drawing.Point(85, 57);
            this.team_nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.team_nameTextBox.Name = "team_nameTextBox";
            this.team_nameTextBox.Size = new System.Drawing.Size(76, 20);
            this.team_nameTextBox.TabIndex = 9;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(103, 172);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 10;
            this.bt_save.Text = "Сохранить";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Bt_save_Click);
            // 
            // pb_emblem
            // 
            this.pb_emblem.Location = new System.Drawing.Point(197, 57);
            this.pb_emblem.Name = "pb_emblem";
            this.pb_emblem.Size = new System.Drawing.Size(130, 78);
            this.pb_emblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_emblem.TabIndex = 11;
            this.pb_emblem.TabStop = false;
            // 
            // bt__selectImg
            // 
            this.bt__selectImg.Location = new System.Drawing.Point(226, 141);
            this.bt__selectImg.Name = "bt__selectImg";
            this.bt__selectImg.Size = new System.Drawing.Size(75, 23);
            this.bt__selectImg.TabIndex = 12;
            this.bt__selectImg.Text = "Выбрать";
            this.bt__selectImg.UseVisualStyleBackColor = true;
            this.bt__selectImg.Click += new System.EventHandler(this.Bt__selectImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.jpg|*.png";
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(184, 172);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Отмена";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.Bt_save_Click);
            // 
            // teamsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 207);
            this.Controls.Add(this.bt__selectImg);
            this.Controls.Add(this.pb_emblem);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(team_nameLabel);
            this.Controls.Add(this.team_nameTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(emblemLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "teamsEditForm";
            this.Text = "Редактор  комманд";
            this.Load += new System.EventHandler(this.TeamsEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_emblem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox team_nameTextBox;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.PictureBox pb_emblem;
        private System.Windows.Forms.Button bt__selectImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_cancel;
    }
}
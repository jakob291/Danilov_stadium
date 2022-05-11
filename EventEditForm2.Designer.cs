namespace Danilov_stadium
{
    partial class EventEditForm2
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
            System.Windows.Forms.Label event_type_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventEditForm2));
            this.event_typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.event_type_nameComboBox = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            event_type_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.event_typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // event_type_nameLabel
            // 
            event_type_nameLabel.AutoSize = true;
            event_type_nameLabel.Location = new System.Drawing.Point(12, 9);
            event_type_nameLabel.Name = "event_type_nameLabel";
            event_type_nameLabel.Size = new System.Drawing.Size(123, 13);
            event_type_nameLabel.TabIndex = 1;
            event_type_nameLabel.Text = "Выберите тип события";
            // 
            // event_typesBindingSource
            // 
            this.event_typesBindingSource.DataSource = typeof(Danilov_stadium.event_types);
            this.event_typesBindingSource.CurrentChanged += new System.EventHandler(this.Event_typesBindingSource_CurrentChanged);
            // 
            // event_type_nameComboBox
            // 
            this.event_type_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.event_typesBindingSource, "event_type_name", true));
            this.event_type_nameComboBox.DataSource = this.event_typesBindingSource;
            this.event_type_nameComboBox.DisplayMember = "event_type_name";
            this.event_type_nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.event_type_nameComboBox.FormattingEnabled = true;
            this.event_type_nameComboBox.Location = new System.Drawing.Point(14, 25);
            this.event_type_nameComboBox.Name = "event_type_nameComboBox";
            this.event_type_nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.event_type_nameComboBox.TabIndex = 2;
            this.event_type_nameComboBox.ValueMember = "event_type_id";
            this.event_type_nameComboBox.SelectedIndexChanged += new System.EventHandler(this.Event_type_nameComboBox_SelectedIndexChanged);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Danilov_stadium.staff);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.09058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.09058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.09058F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.72825F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 407);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(Danilov_stadium.teams);
            // 
            // teamsBindingSource2
            // 
            this.teamsBindingSource2.DataSource = typeof(Danilov_stadium.teams);
            // 
            // EventEditForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(event_type_nameLabel);
            this.Controls.Add(this.event_type_nameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EventEditForm2";
            this.Text = "Отредактировать событие";
            this.Load += new System.EventHandler(this.EventEditForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.event_typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource event_typesBindingSource;
        private System.Windows.Forms.ComboBox event_type_nameComboBox;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.BindingSource teamsBindingSource2;
    }
}
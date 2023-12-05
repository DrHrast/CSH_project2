namespace CSH_project2
{
    partial class PH_Projekt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataPersonView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.spolLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.drzavaLabel = new System.Windows.Forms.Label();
            this.mjestoLabel = new System.Windows.Forms.Label();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.prezimeBox = new System.Windows.Forms.TextBox();
            this.drzavaBox = new System.Windows.Forms.TextBox();
            this.mjestoBox = new System.Windows.Forms.TextBox();
            this.spolBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.datumBox = new System.Windows.Forms.DateTimePicker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sPProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jGProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkKeepDataBox = new System.Windows.Forms.CheckBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPersonView
            // 
            this.dataPersonView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPersonView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPersonView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPersonView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPersonView.Location = new System.Drawing.Point(248, 55);
            this.dataPersonView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataPersonView.Name = "dataPersonView";
            this.dataPersonView.ReadOnly = true;
            this.dataPersonView.Size = new System.Drawing.Size(901, 486);
            this.dataPersonView.TabIndex = 0;
            this.dataPersonView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataPersonView_ColumnHeaderMouseClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 98);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Ime";
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(20, 142);
            this.prezimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(56, 16);
            this.prezimeLabel.TabIndex = 2;
            this.prezimeLabel.Text = "Prezime";
            // 
            // spolLabel
            // 
            this.spolLabel.AutoSize = true;
            this.spolLabel.Location = new System.Drawing.Point(20, 185);
            this.spolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spolLabel.Name = "spolLabel";
            this.spolLabel.Size = new System.Drawing.Size(35, 16);
            this.spolLabel.TabIndex = 3;
            this.spolLabel.Text = "Spol";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(20, 229);
            this.datumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(98, 16);
            this.datumLabel.TabIndex = 4;
            this.datumLabel.Text = "DatumRođenja";
            // 
            // drzavaLabel
            // 
            this.drzavaLabel.AutoSize = true;
            this.drzavaLabel.Location = new System.Drawing.Point(20, 298);
            this.drzavaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drzavaLabel.Name = "drzavaLabel";
            this.drzavaLabel.Size = new System.Drawing.Size(50, 16);
            this.drzavaLabel.TabIndex = 5;
            this.drzavaLabel.Text = "Država";
            // 
            // mjestoLabel
            // 
            this.mjestoLabel.AutoSize = true;
            this.mjestoLabel.Location = new System.Drawing.Point(20, 336);
            this.mjestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mjestoLabel.Name = "mjestoLabel";
            this.mjestoLabel.Size = new System.Drawing.Size(99, 16);
            this.mjestoLabel.TabIndex = 6;
            this.mjestoLabel.Text = "MjestoRođenja";
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(81, 90);
            this.imeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(132, 22);
            this.imeBox.TabIndex = 7;
            this.imeBox.Validated += new System.EventHandler(this.imeBox_Validated);
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(81, 133);
            this.prezimeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(132, 22);
            this.prezimeBox.TabIndex = 8;
            this.prezimeBox.Validated += new System.EventHandler(this.prezimeBox_Validated);
            // 
            // drzavaBox
            // 
            this.drzavaBox.Location = new System.Drawing.Point(81, 289);
            this.drzavaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drzavaBox.Name = "drzavaBox";
            this.drzavaBox.Size = new System.Drawing.Size(132, 22);
            this.drzavaBox.TabIndex = 11;
            this.drzavaBox.Validated += new System.EventHandler(this.drzavaBox_Validated);
            // 
            // mjestoBox
            // 
            this.mjestoBox.Location = new System.Drawing.Point(81, 356);
            this.mjestoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mjestoBox.Name = "mjestoBox";
            this.mjestoBox.Size = new System.Drawing.Size(132, 22);
            this.mjestoBox.TabIndex = 12;
            this.mjestoBox.Validated += new System.EventHandler(this.mjestoBox_Validated);
            // 
            // spolBox
            // 
            this.spolBox.FormattingEnabled = true;
            this.spolBox.Location = new System.Drawing.Point(81, 175);
            this.spolBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spolBox.Name = "spolBox";
            this.spolBox.Size = new System.Drawing.Size(61, 24);
            this.spolBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(23, 468);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(191, 28);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Dodaj osobu";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // datumBox
            // 
            this.datumBox.CustomFormat = "dd,MM,yyyy";
            this.datumBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumBox.Location = new System.Drawing.Point(81, 249);
            this.datumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datumBox.Name = "datumBox";
            this.datumBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datumBox.Size = new System.Drawing.Size(135, 22);
            this.datumBox.TabIndex = 10;
            this.datumBox.Value = new System.DateTime(2023, 12, 5, 0, 0, 0, 0);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(23, 415);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Maximum = 102;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(189, 23);
            this.progressBar.Step = 17;
            this.progressBar.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sPProjectToolStripMenuItem,
            this.jGProjectToolStripMenuItem});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // sPProjectToolStripMenuItem
            // 
            this.sPProjectToolStripMenuItem.Name = "sPProjectToolStripMenuItem";
            this.sPProjectToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sPProjectToolStripMenuItem.Text = "SP_Project";
            // 
            // jGProjectToolStripMenuItem
            // 
            this.jGProjectToolStripMenuItem.Name = "jGProjectToolStripMenuItem";
            this.jGProjectToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.jGProjectToolStripMenuItem.Text = "JG_Project";
            // 
            // checkKeepDataBox
            // 
            this.checkKeepDataBox.AutoSize = true;
            this.checkKeepDataBox.Location = new System.Drawing.Point(24, 444);
            this.checkKeepDataBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkKeepDataBox.Name = "checkKeepDataBox";
            this.checkKeepDataBox.Size = new System.Drawing.Size(90, 20);
            this.checkKeepDataBox.TabIndex = 19;
            this.checkKeepDataBox.Text = "Keep Data";
            this.checkKeepDataBox.UseVisualStyleBackColor = true;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(CSH_project2.Program);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(CSH_project2.Program);
            // 
            // PH_Projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 654);
            this.Controls.Add(this.checkKeepDataBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.datumBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.spolBox);
            this.Controls.Add(this.mjestoBox);
            this.Controls.Add(this.drzavaBox);
            this.Controls.Add(this.prezimeBox);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.mjestoLabel);
            this.Controls.Add(this.drzavaLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.spolLabel);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dataPersonView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PH_Projekt";
            this.Text = "PH_Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.DataGridView dataPersonView;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.Label spolLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label drzavaLabel;
        private System.Windows.Forms.Label mjestoLabel;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.TextBox prezimeBox;
        private System.Windows.Forms.TextBox drzavaBox;
        private System.Windows.Forms.TextBox mjestoBox;
        private System.Windows.Forms.ComboBox spolBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker datumBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sPProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jGProjectToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkKeepDataBox;
    }
}


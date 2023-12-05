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
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sPProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jGProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkKeepDataBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dataPersonView.Location = new System.Drawing.Point(186, 45);
            this.dataPersonView.Name = "dataPersonView";
            this.dataPersonView.ReadOnly = true;
            this.dataPersonView.Size = new System.Drawing.Size(676, 395);
            this.dataPersonView.TabIndex = 0;
            this.dataPersonView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataPersonView_ColumnHeaderMouseClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(24, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Ime";
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(15, 115);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(44, 13);
            this.prezimeLabel.TabIndex = 2;
            this.prezimeLabel.Text = "Prezime";
            // 
            // spolLabel
            // 
            this.spolLabel.AutoSize = true;
            this.spolLabel.Location = new System.Drawing.Point(15, 150);
            this.spolLabel.Name = "spolLabel";
            this.spolLabel.Size = new System.Drawing.Size(28, 13);
            this.spolLabel.TabIndex = 3;
            this.spolLabel.Text = "Spol";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(15, 186);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(79, 13);
            this.datumLabel.TabIndex = 4;
            this.datumLabel.Text = "DatumRođenja";
            // 
            // drzavaLabel
            // 
            this.drzavaLabel.AutoSize = true;
            this.drzavaLabel.Location = new System.Drawing.Point(15, 242);
            this.drzavaLabel.Name = "drzavaLabel";
            this.drzavaLabel.Size = new System.Drawing.Size(41, 13);
            this.drzavaLabel.TabIndex = 5;
            this.drzavaLabel.Text = "Država";
            // 
            // mjestoLabel
            // 
            this.mjestoLabel.AutoSize = true;
            this.mjestoLabel.Location = new System.Drawing.Point(15, 273);
            this.mjestoLabel.Name = "mjestoLabel";
            this.mjestoLabel.Size = new System.Drawing.Size(79, 13);
            this.mjestoLabel.TabIndex = 6;
            this.mjestoLabel.Text = "MjestoRođenja";
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(61, 73);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(100, 20);
            this.imeBox.TabIndex = 7;
            this.imeBox.Validated += new System.EventHandler(this.imeBox_Validated);
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(61, 108);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeBox.TabIndex = 8;
            this.prezimeBox.Validated += new System.EventHandler(this.prezimeBox_Validated);
            // 
            // drzavaBox
            // 
            this.drzavaBox.Location = new System.Drawing.Point(61, 235);
            this.drzavaBox.Name = "drzavaBox";
            this.drzavaBox.Size = new System.Drawing.Size(100, 20);
            this.drzavaBox.TabIndex = 11;
            this.drzavaBox.Validated += new System.EventHandler(this.drzavaBox_Validated);
            // 
            // mjestoBox
            // 
            this.mjestoBox.Location = new System.Drawing.Point(61, 289);
            this.mjestoBox.Name = "mjestoBox";
            this.mjestoBox.Size = new System.Drawing.Size(100, 20);
            this.mjestoBox.TabIndex = 12;
            this.mjestoBox.Validated += new System.EventHandler(this.mjestoBox_Validated);
            // 
            // spolBox
            // 
            this.spolBox.FormattingEnabled = true;
            this.spolBox.Location = new System.Drawing.Point(61, 142);
            this.spolBox.Name = "spolBox";
            this.spolBox.Size = new System.Drawing.Size(47, 21);
            this.spolBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(17, 380);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Dodaj osobu";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // datumBox
            // 
            this.datumBox.CustomFormat = "yyyy,mm,dd";
            this.datumBox.Location = new System.Drawing.Point(61, 202);
            this.datumBox.Margin = new System.Windows.Forms.Padding(2);
            this.datumBox.Name = "datumBox";
            this.datumBox.Size = new System.Drawing.Size(102, 20);
            this.datumBox.TabIndex = 10;
            this.datumBox.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(17, 337);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Maximum = 102;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(142, 19);
            this.progressBar.Step = 17;
            this.progressBar.TabIndex = 17;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(CSH_project2.Program);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(CSH_project2.Program);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
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
            this.checkKeepDataBox.Location = new System.Drawing.Point(18, 361);
            this.checkKeepDataBox.Name = "checkKeepDataBox";
            this.checkKeepDataBox.Size = new System.Drawing.Size(77, 17);
            this.checkKeepDataBox.TabIndex = 19;
            this.checkKeepDataBox.Text = "Keep Data";
            this.checkKeepDataBox.UseVisualStyleBackColor = true;
            // 
            // PH_Projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 531);
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
            this.Name = "PH_Projekt";
            this.Text = "PH_Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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


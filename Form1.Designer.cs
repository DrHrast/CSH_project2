namespace CSH_project2
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).BeginInit();
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
            this.dataPersonView.Location = new System.Drawing.Point(248, 31);
            this.dataPersonView.Margin = new System.Windows.Forms.Padding(4);
            this.dataPersonView.Name = "dataPersonView";
            this.dataPersonView.ReadOnly = true;
            this.dataPersonView.Size = new System.Drawing.Size(784, 486);
            this.dataPersonView.TabIndex = 0;
            this.dataPersonView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataPersonView_ColumnHeaderMouseClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 55);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Ime";
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(27, 98);
            this.prezimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(56, 16);
            this.prezimeLabel.TabIndex = 2;
            this.prezimeLabel.Text = "Prezime";
            // 
            // spolLabel
            // 
            this.spolLabel.AutoSize = true;
            this.spolLabel.Location = new System.Drawing.Point(27, 142);
            this.spolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spolLabel.Name = "spolLabel";
            this.spolLabel.Size = new System.Drawing.Size(35, 16);
            this.spolLabel.TabIndex = 3;
            this.spolLabel.Text = "Spol";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(27, 186);
            this.datumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(98, 16);
            this.datumLabel.TabIndex = 4;
            this.datumLabel.Text = "DatumRođenja";
            // 
            // drzavaLabel
            // 
            this.drzavaLabel.AutoSize = true;
            this.drzavaLabel.Location = new System.Drawing.Point(27, 255);
            this.drzavaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drzavaLabel.Name = "drzavaLabel";
            this.drzavaLabel.Size = new System.Drawing.Size(50, 16);
            this.drzavaLabel.TabIndex = 5;
            this.drzavaLabel.Text = "Država";
            // 
            // mjestoLabel
            // 
            this.mjestoLabel.AutoSize = true;
            this.mjestoLabel.Location = new System.Drawing.Point(27, 293);
            this.mjestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mjestoLabel.Name = "mjestoLabel";
            this.mjestoLabel.Size = new System.Drawing.Size(99, 16);
            this.mjestoLabel.TabIndex = 6;
            this.mjestoLabel.Text = "MjestoRođenja";
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(88, 47);
            this.imeBox.Margin = new System.Windows.Forms.Padding(4);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(132, 22);
            this.imeBox.TabIndex = 7;
            this.imeBox.Validated += new System.EventHandler(this.imeBox_Validated);
            // 
            // prezimeBox
            // 
            this.prezimeBox.Location = new System.Drawing.Point(88, 90);
            this.prezimeBox.Margin = new System.Windows.Forms.Padding(4);
            this.prezimeBox.Name = "prezimeBox";
            this.prezimeBox.Size = new System.Drawing.Size(132, 22);
            this.prezimeBox.TabIndex = 8;
            // 
            // drzavaBox
            // 
            this.drzavaBox.Location = new System.Drawing.Point(88, 246);
            this.drzavaBox.Margin = new System.Windows.Forms.Padding(4);
            this.drzavaBox.Name = "drzavaBox";
            this.drzavaBox.Size = new System.Drawing.Size(132, 22);
            this.drzavaBox.TabIndex = 11;
            // 
            // mjestoBox
            // 
            this.mjestoBox.Location = new System.Drawing.Point(88, 313);
            this.mjestoBox.Margin = new System.Windows.Forms.Padding(4);
            this.mjestoBox.Name = "mjestoBox";
            this.mjestoBox.Size = new System.Drawing.Size(132, 22);
            this.mjestoBox.TabIndex = 12;
            // 
            // spolBox
            // 
            this.spolBox.FormattingEnabled = true;
            this.spolBox.Location = new System.Drawing.Point(88, 132);
            this.spolBox.Margin = new System.Windows.Forms.Padding(4);
            this.spolBox.Name = "spolBox";
            this.spolBox.Size = new System.Drawing.Size(61, 24);
            this.spolBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(29, 425);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(191, 28);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Dodaj osobu";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // datumBox
            // 
            this.datumBox.CustomFormat = "yyyy,mm,dd";
            this.datumBox.Location = new System.Drawing.Point(88, 205);
            this.datumBox.Name = "datumBox";
            this.datumBox.Size = new System.Drawing.Size(134, 22);
            this.datumBox.TabIndex = 10;
            this.datumBox.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Lime;
            this.progressBar.Location = new System.Drawing.Point(30, 372);
            this.progressBar.Maximum = 102;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(190, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonView)).EndInit();
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
    }
}


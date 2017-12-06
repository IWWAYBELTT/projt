namespace CrudRepository
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
            this.btn_ajout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductIdentifier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRemoveFilter = new System.Windows.Forms.Button();
            this.txtCompanyNameFilter = new System.Windows.Forms.TextBox();
            this.cboFilterOptionsForString = new System.Windows.Forms.ComboBox();
            this.cmdCompanyName = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(586, 73);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(139, 23);
            this.btn_ajout.TabIndex = 0;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 435);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 224);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Btn_supprimer);
            this.panel1.Controls.Add(this.btn_modif);
            this.panel1.Controls.Add(this.btn_ajout);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 227);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 177);
            this.panel1.TabIndex = 3;
            // 
           
           
            // 
            // Btn_supprimer
            // 
            this.Btn_supprimer.Location = new System.Drawing.Point(586, 103);
            this.Btn_supprimer.Name = "Btn_supprimer";
            this.Btn_supprimer.Size = new System.Drawing.Size(139, 23);
            this.Btn_supprimer.TabIndex = 4;
            this.Btn_supprimer.Text = "Supprimer";
            this.Btn_supprimer.UseVisualStyleBackColor = true;
            this.Btn_supprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_modif
            // 
            this.btn_modif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modif.Location = new System.Drawing.Point(586, 44);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(139, 23);
            this.btn_modif.TabIndex = 3;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.cmdEditCurrent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblProductIdentifier);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(273, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(206, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Binding on current row";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(56, 41);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(44, 15);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "ABCDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // lblProductIdentifier
            // 
            this.lblProductIdentifier.AutoSize = true;
            this.lblProductIdentifier.Location = new System.Drawing.Point(56, 25);
            this.lblProductIdentifier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductIdentifier.Name = "lblProductIdentifier";
            this.lblProductIdentifier.Size = new System.Drawing.Size(31, 15);
            this.lblProductIdentifier.TabIndex = 1;
            this.lblProductIdentifier.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifier";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRemoveFilter);
            this.groupBox1.Controls.Add(this.txtCompanyNameFilter);
            this.groupBox1.Controls.Add(this.cboFilterOptionsForString);
            this.groupBox1.Controls.Add(this.cmdCompanyName);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company name filter";
            // 
            // cmdRemoveFilter
            // 
            this.cmdRemoveFilter.Location = new System.Drawing.Point(158, 48);
            this.cmdRemoveFilter.Name = "cmdRemoveFilter";
            this.cmdRemoveFilter.Size = new System.Drawing.Size(92, 23);
            this.cmdRemoveFilter.TabIndex = 3;
            this.cmdRemoveFilter.Text = "Supprimer";
            this.cmdRemoveFilter.UseVisualStyleBackColor = true;
            // 
            // txtCompanyNameFilter
            // 
            this.txtCompanyNameFilter.Location = new System.Drawing.Point(5, 25);
            this.txtCompanyNameFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyNameFilter.Name = "txtCompanyNameFilter";
            this.txtCompanyNameFilter.Size = new System.Drawing.Size(148, 23);
            this.txtCompanyNameFilter.TabIndex = 0;
            // 
            // cboFilterOptionsForString
            // 
            this.cboFilterOptionsForString.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterOptionsForString.FormattingEnabled = true;
            this.cboFilterOptionsForString.Location = new System.Drawing.Point(5, 48);
            this.cboFilterOptionsForString.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterOptionsForString.Name = "cboFilterOptionsForString";
            this.cboFilterOptionsForString.Size = new System.Drawing.Size(148, 23);
            this.cboFilterOptionsForString.TabIndex = 2;
            // 
            // cmdCompanyName
            // 
            this.cmdCompanyName.Location = new System.Drawing.Point(158, 25);
            this.cmdCompanyName.Name = "cmdCompanyName";
            this.cmdCompanyName.Size = new System.Drawing.Size(92, 23);
            this.cmdCompanyName.TabIndex = 1;
            this.cmdCompanyName.Text = "Filter";
            this.cmdCompanyName.UseVisualStyleBackColor = true;
            this.cmdCompanyName.Click += new System.EventHandler(this.cmdCompanyName_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(746, 437);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button cmdAddNew;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductIdentifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdRemoveFilter;
        private System.Windows.Forms.TextBox txtCompanyNameFilter;
        private System.Windows.Forms.ComboBox cboFilterOptionsForString;
        private System.Windows.Forms.Button cmdCompanyName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_supprimer;
        private System.Windows.Forms.Button button1;
    }
}


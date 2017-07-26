namespace AHP
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Criteria_textBox = new System.Windows.Forms.TextBox();
            this.CriteriasAdd_button = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Criterias_groupBox = new System.Windows.Forms.GroupBox();
            this.CheckConsistency_button = new System.Windows.Forms.Button();
            this.CriteriaWeight_label = new System.Windows.Forms.Label();
            this.CriteriaWeight_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NormalizedMatrix_dgv = new System.Windows.Forms.DataGridView();
            this.Update_button = new System.Windows.Forms.Button();
            this.CriteriaCPC_button = new System.Windows.Forms.Button();
            this.Criterias_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alt_table_label = new System.Windows.Forms.Label();
            this.FinalTab_button = new System.Windows.Forms.Button();
            this.AltPeriority_dgv = new System.Windows.Forms.DataGridView();
            this.ShowPeriorityMatrix_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AltWeight_label = new System.Windows.Forms.Label();
            this.AltNorm_label = new System.Windows.Forms.Label();
            this.Criterias_comboBox = new System.Windows.Forms.ComboBox();
            this.AltCheckConsistency_button = new System.Windows.Forms.Button();
            this.AlternativesWeight_dgv = new System.Windows.Forms.DataGridView();
            this.AlterNormalizedMatrix_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AlternativesCPC_button = new System.Windows.Forms.Button();
            this.Alternatives_dgv = new System.Windows.Forms.DataGridView();
            this.Alternatives_listBox = new System.Windows.Forms.ListBox();
            this.Alternatives_textBox = new System.Windows.Forms.TextBox();
            this.AddAlternative_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FRM_listBox = new System.Windows.Forms.ListBox();
            this.FRM_label = new System.Windows.Forms.Label();
            this.FinalRating_label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Criterias_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaWeight_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizedMatrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Criterias_dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltPeriority_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesWeight_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlterNormalizedMatrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alternatives_dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Criteria_textBox);
            this.tabPage1.Controls.Add(this.CriteriasAdd_button);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.Criterias_groupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Criterias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Criteria_textBox
            // 
            this.Criteria_textBox.Location = new System.Drawing.Point(163, 33);
            this.Criteria_textBox.Name = "Criteria_textBox";
            this.Criteria_textBox.Size = new System.Drawing.Size(124, 20);
            this.Criteria_textBox.TabIndex = 10;
            // 
            // CriteriasAdd_button
            // 
            this.CriteriasAdd_button.Location = new System.Drawing.Point(293, 30);
            this.CriteriasAdd_button.Name = "CriteriasAdd_button";
            this.CriteriasAdd_button.Size = new System.Drawing.Size(75, 23);
            this.CriteriasAdd_button.TabIndex = 9;
            this.CriteriasAdd_button.Text = "Add";
            this.CriteriasAdd_button.UseVisualStyleBackColor = true;
            this.CriteriasAdd_button.Click += new System.EventHandler(this.CriteriasAdd_button_Click_1);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(2, 20);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(140, 267);
            this.treeView1.TabIndex = 6;
            // 
            // Criterias_groupBox
            // 
            this.Criterias_groupBox.Controls.Add(this.CheckConsistency_button);
            this.Criterias_groupBox.Controls.Add(this.CriteriaWeight_label);
            this.Criterias_groupBox.Controls.Add(this.CriteriaWeight_dgv);
            this.Criterias_groupBox.Controls.Add(this.label1);
            this.Criterias_groupBox.Controls.Add(this.NormalizedMatrix_dgv);
            this.Criterias_groupBox.Controls.Add(this.Update_button);
            this.Criterias_groupBox.Controls.Add(this.CriteriaCPC_button);
            this.Criterias_groupBox.Controls.Add(this.Criterias_dgv);
            this.Criterias_groupBox.Location = new System.Drawing.Point(155, 7);
            this.Criterias_groupBox.Name = "Criterias_groupBox";
            this.Criterias_groupBox.Size = new System.Drawing.Size(663, 296);
            this.Criterias_groupBox.TabIndex = 11;
            this.Criterias_groupBox.TabStop = false;
            this.Criterias_groupBox.Text = "Criterias";
            // 
            // CheckConsistency_button
            // 
            this.CheckConsistency_button.Location = new System.Drawing.Point(503, 264);
            this.CheckConsistency_button.Name = "CheckConsistency_button";
            this.CheckConsistency_button.Size = new System.Drawing.Size(110, 23);
            this.CheckConsistency_button.TabIndex = 13;
            this.CheckConsistency_button.Text = "Check Consistency";
            this.CheckConsistency_button.UseVisualStyleBackColor = true;
            this.CheckConsistency_button.Click += new System.EventHandler(this.CheckConsistency_button_Click_1);
            // 
            // CriteriaWeight_label
            // 
            this.CriteriaWeight_label.AutoSize = true;
            this.CriteriaWeight_label.Location = new System.Drawing.Point(519, 92);
            this.CriteriaWeight_label.Name = "CriteriaWeight_label";
            this.CriteriaWeight_label.Size = new System.Drawing.Size(76, 13);
            this.CriteriaWeight_label.TabIndex = 12;
            this.CriteriaWeight_label.Text = "Criteria Weight";
            // 
            // CriteriaWeight_dgv
            // 
            this.CriteriaWeight_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CriteriaWeight_dgv.Location = new System.Drawing.Point(522, 108);
            this.CriteriaWeight_dgv.Name = "CriteriaWeight_dgv";
            this.CriteriaWeight_dgv.Size = new System.Drawing.Size(135, 150);
            this.CriteriaWeight_dgv.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Normalized Matrix";
            // 
            // NormalizedMatrix_dgv
            // 
            this.NormalizedMatrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NormalizedMatrix_dgv.Location = new System.Drawing.Point(263, 108);
            this.NormalizedMatrix_dgv.Name = "NormalizedMatrix_dgv";
            this.NormalizedMatrix_dgv.Size = new System.Drawing.Size(240, 150);
            this.NormalizedMatrix_dgv.TabIndex = 9;
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(171, 264);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 8;
            this.Update_button.Text = "Next";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click_1);
            // 
            // CriteriaCPC_button
            // 
            this.CriteriaCPC_button.Location = new System.Drawing.Point(6, 79);
            this.CriteriaCPC_button.Name = "CriteriaCPC_button";
            this.CriteriaCPC_button.Size = new System.Drawing.Size(155, 23);
            this.CriteriaCPC_button.TabIndex = 7;
            this.CriteriaCPC_button.Text = "Create Pairwise Comparison";
            this.CriteriaCPC_button.UseVisualStyleBackColor = true;
            this.CriteriaCPC_button.Click += new System.EventHandler(this.CriteriaCPC_button_Click);
            // 
            // Criterias_dgv
            // 
            this.Criterias_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Criterias_dgv.Location = new System.Drawing.Point(6, 108);
            this.Criterias_dgv.Name = "Criterias_dgv";
            this.Criterias_dgv.Size = new System.Drawing.Size(240, 150);
            this.Criterias_dgv.TabIndex = 6;
            this.Criterias_dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Criterias_dgv_CellEndEdit);
            this.Criterias_dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Criterias_dgv_CellValueChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.alt_table_label);
            this.tabPage2.Controls.Add(this.FinalTab_button);
            this.tabPage2.Controls.Add(this.AltPeriority_dgv);
            this.tabPage2.Controls.Add(this.ShowPeriorityMatrix_button);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.AltWeight_label);
            this.tabPage2.Controls.Add(this.AltNorm_label);
            this.tabPage2.Controls.Add(this.Criterias_comboBox);
            this.tabPage2.Controls.Add(this.AltCheckConsistency_button);
            this.tabPage2.Controls.Add(this.AlternativesWeight_dgv);
            this.tabPage2.Controls.Add(this.AlterNormalizedMatrix_dgv);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.AlternativesCPC_button);
            this.tabPage2.Controls.Add(this.Alternatives_dgv);
            this.tabPage2.Controls.Add(this.Alternatives_listBox);
            this.tabPage2.Controls.Add(this.Alternatives_textBox);
            this.tabPage2.Controls.Add(this.AddAlternative_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alternatives";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // alt_table_label
            // 
            this.alt_table_label.AutoSize = true;
            this.alt_table_label.Location = new System.Drawing.Point(148, 107);
            this.alt_table_label.Name = "alt_table_label";
            this.alt_table_label.Size = new System.Drawing.Size(0, 13);
            this.alt_table_label.TabIndex = 40;
            // 
            // FinalTab_button
            // 
            this.FinalTab_button.Location = new System.Drawing.Point(885, 289);
            this.FinalTab_button.Name = "FinalTab_button";
            this.FinalTab_button.Size = new System.Drawing.Size(149, 23);
            this.FinalTab_button.TabIndex = 38;
            this.FinalTab_button.Text = "Get Final Rating Matrix";
            this.FinalTab_button.UseVisualStyleBackColor = true;
            this.FinalTab_button.Click += new System.EventHandler(this.FinalTab_button_Click);
            // 
            // AltPeriority_dgv
            // 
            this.AltPeriority_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AltPeriority_dgv.Location = new System.Drawing.Point(794, 126);
            this.AltPeriority_dgv.Name = "AltPeriority_dgv";
            this.AltPeriority_dgv.Size = new System.Drawing.Size(240, 150);
            this.AltPeriority_dgv.TabIndex = 1;
            // 
            // ShowPeriorityMatrix_button
            // 
            this.ShowPeriorityMatrix_button.Location = new System.Drawing.Point(794, 97);
            this.ShowPeriorityMatrix_button.Name = "ShowPeriorityMatrix_button";
            this.ShowPeriorityMatrix_button.Size = new System.Drawing.Size(113, 23);
            this.ShowPeriorityMatrix_button.TabIndex = 37;
            this.ShowPeriorityMatrix_button.Text = "Show Periority Matrix";
            this.ShowPeriorityMatrix_button.UseVisualStyleBackColor = true;
            this.ShowPeriorityMatrix_button.Click += new System.EventHandler(this.ShowPeriorityMatrix_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Select Criteria";
            // 
            // AltWeight_label
            // 
            this.AltWeight_label.AutoSize = true;
            this.AltWeight_label.Location = new System.Drawing.Point(663, 107);
            this.AltWeight_label.Name = "AltWeight_label";
            this.AltWeight_label.Size = new System.Drawing.Size(99, 13);
            this.AltWeight_label.TabIndex = 34;
            this.AltWeight_label.Text = "Alternatives Weight";
            // 
            // AltNorm_label
            // 
            this.AltNorm_label.AutoSize = true;
            this.AltNorm_label.Location = new System.Drawing.Point(404, 107);
            this.AltNorm_label.Name = "AltNorm_label";
            this.AltNorm_label.Size = new System.Drawing.Size(90, 13);
            this.AltNorm_label.TabIndex = 33;
            this.AltNorm_label.Text = "Normalized Matrix";
            // 
            // Criterias_comboBox
            // 
            this.Criterias_comboBox.FormattingEnabled = true;
            this.Criterias_comboBox.Location = new System.Drawing.Point(508, 19);
            this.Criterias_comboBox.Name = "Criterias_comboBox";
            this.Criterias_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Criterias_comboBox.TabIndex = 32;
            this.Criterias_comboBox.SelectedIndexChanged += new System.EventHandler(this.Criterias_comboBox_SelectedIndexChanged);
            // 
            // AltCheckConsistency_button
            // 
            this.AltCheckConsistency_button.Location = new System.Drawing.Point(647, 282);
            this.AltCheckConsistency_button.Name = "AltCheckConsistency_button";
            this.AltCheckConsistency_button.Size = new System.Drawing.Size(110, 23);
            this.AltCheckConsistency_button.TabIndex = 31;
            this.AltCheckConsistency_button.Text = "Check Consistency";
            this.AltCheckConsistency_button.UseVisualStyleBackColor = true;
            this.AltCheckConsistency_button.Click += new System.EventHandler(this.AltCheckConsistency_button_Click);
            // 
            // AlternativesWeight_dgv
            // 
            this.AlternativesWeight_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativesWeight_dgv.Location = new System.Drawing.Point(666, 126);
            this.AlternativesWeight_dgv.Name = "AlternativesWeight_dgv";
            this.AlternativesWeight_dgv.Size = new System.Drawing.Size(91, 150);
            this.AlternativesWeight_dgv.TabIndex = 30;
            // 
            // AlterNormalizedMatrix_dgv
            // 
            this.AlterNormalizedMatrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlterNormalizedMatrix_dgv.Location = new System.Drawing.Point(407, 126);
            this.AlterNormalizedMatrix_dgv.Name = "AlterNormalizedMatrix_dgv";
            this.AlterNormalizedMatrix_dgv.Size = new System.Drawing.Size(240, 150);
            this.AlterNormalizedMatrix_dgv.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AlternativesCPC_button
            // 
            this.AlternativesCPC_button.Location = new System.Drawing.Point(139, 69);
            this.AlternativesCPC_button.Name = "AlternativesCPC_button";
            this.AlternativesCPC_button.Size = new System.Drawing.Size(155, 23);
            this.AlternativesCPC_button.TabIndex = 27;
            this.AlternativesCPC_button.Text = "Create Pairwise Comparison";
            this.AlternativesCPC_button.UseVisualStyleBackColor = true;
            this.AlternativesCPC_button.Click += new System.EventHandler(this.AlternativesCPC_button_Click);
            // 
            // Alternatives_dgv
            // 
            this.Alternatives_dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Alternatives_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alternatives_dgv.Location = new System.Drawing.Point(139, 126);
            this.Alternatives_dgv.Name = "Alternatives_dgv";
            this.Alternatives_dgv.Size = new System.Drawing.Size(240, 150);
            this.Alternatives_dgv.TabIndex = 26;
            this.Alternatives_dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Alternatives_dgv_CellEndEdit);
            // 
            // Alternatives_listBox
            // 
            this.Alternatives_listBox.FormattingEnabled = true;
            this.Alternatives_listBox.Location = new System.Drawing.Point(9, 9);
            this.Alternatives_listBox.Name = "Alternatives_listBox";
            this.Alternatives_listBox.Size = new System.Drawing.Size(120, 303);
            this.Alternatives_listBox.TabIndex = 25;
            // 
            // Alternatives_textBox
            // 
            this.Alternatives_textBox.Location = new System.Drawing.Point(139, 21);
            this.Alternatives_textBox.Name = "Alternatives_textBox";
            this.Alternatives_textBox.Size = new System.Drawing.Size(168, 20);
            this.Alternatives_textBox.TabIndex = 24;
            // 
            // AddAlternative_button
            // 
            this.AddAlternative_button.Location = new System.Drawing.Point(313, 19);
            this.AddAlternative_button.Name = "AddAlternative_button";
            this.AddAlternative_button.Size = new System.Drawing.Size(75, 23);
            this.AddAlternative_button.TabIndex = 23;
            this.AddAlternative_button.Text = "Add";
            this.AddAlternative_button.UseVisualStyleBackColor = true;
            this.AddAlternative_button.Click += new System.EventHandler(this.AddAlternative_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FRM_listBox);
            this.tabPage3.Controls.Add(this.FRM_label);
            this.tabPage3.Controls.Add(this.FinalRating_label);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1051, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Final Rating ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FRM_listBox
            // 
            this.FRM_listBox.FormattingEnabled = true;
            this.FRM_listBox.Location = new System.Drawing.Point(11, 47);
            this.FRM_listBox.Name = "FRM_listBox";
            this.FRM_listBox.Size = new System.Drawing.Size(120, 147);
            this.FRM_listBox.TabIndex = 3;
            // 
            // FRM_label
            // 
            this.FRM_label.AutoSize = true;
            this.FRM_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRM_label.ForeColor = System.Drawing.Color.Red;
            this.FRM_label.Location = new System.Drawing.Point(163, 104);
            this.FRM_label.Name = "FRM_label";
            this.FRM_label.Size = new System.Drawing.Size(0, 25);
            this.FRM_label.TabIndex = 2;
            // 
            // FinalRating_label
            // 
            this.FinalRating_label.AutoSize = true;
            this.FinalRating_label.Location = new System.Drawing.Point(8, 31);
            this.FinalRating_label.Name = "FinalRating_label";
            this.FinalRating_label.Size = new System.Drawing.Size(89, 13);
            this.FinalRating_label.TabIndex = 1;
            this.FinalRating_label.Text = "Final rating Matrix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Decision-Making using the Analytic Hierarchy Process (AHP)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Criterias_groupBox.ResumeLayout(false);
            this.Criterias_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CriteriaWeight_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalizedMatrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Criterias_dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AltPeriority_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesWeight_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlterNormalizedMatrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alternatives_dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Criteria_textBox;
        private System.Windows.Forms.Button CriteriasAdd_button;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Criterias_groupBox;
        private System.Windows.Forms.Button CheckConsistency_button;
        private System.Windows.Forms.Label CriteriaWeight_label;
        private System.Windows.Forms.DataGridView CriteriaWeight_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView NormalizedMatrix_dgv;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button CriteriaCPC_button;
        internal System.Windows.Forms.DataGridView Criterias_dgv;
        private System.Windows.Forms.Label AltWeight_label;
        private System.Windows.Forms.Label AltNorm_label;
        private System.Windows.Forms.ComboBox Criterias_comboBox;
        private System.Windows.Forms.Button AltCheckConsistency_button;
        private System.Windows.Forms.DataGridView AlternativesWeight_dgv;
        private System.Windows.Forms.DataGridView AlterNormalizedMatrix_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AlternativesCPC_button;
        internal System.Windows.Forms.DataGridView Alternatives_dgv;
        private System.Windows.Forms.ListBox Alternatives_listBox;
        private System.Windows.Forms.TextBox Alternatives_textBox;
        private System.Windows.Forms.Button AddAlternative_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label FinalRating_label;
        private System.Windows.Forms.Button FinalTab_button;
        private System.Windows.Forms.Label FRM_label;
        private System.Windows.Forms.ListBox FRM_listBox;
        private System.Windows.Forms.Label alt_table_label;
        private System.Windows.Forms.DataGridView AltPeriority_dgv;
        private System.Windows.Forms.Button ShowPeriorityMatrix_button;
    }
}


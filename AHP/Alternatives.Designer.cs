namespace AHP
{
    partial class Alternatives
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
            this.AddAlternative_button = new System.Windows.Forms.Button();
            this.Alternatives_textBox = new System.Windows.Forms.TextBox();
            this.Alternatives_listBox = new System.Windows.Forms.ListBox();
            this.AltCheckConsistency_button = new System.Windows.Forms.Button();
            this.AlternativesWeight_dgv = new System.Windows.Forms.DataGridView();
            this.AlterNormalizedMatrix_dgv = new System.Windows.Forms.DataGridView();
            this.Update_button = new System.Windows.Forms.Button();
            this.AlternativesCPC_button = new System.Windows.Forms.Button();
            this.Alternatives_dgv = new System.Windows.Forms.DataGridView();
            this.Criterias_comboBox = new System.Windows.Forms.ComboBox();
            this.AltNorm_label = new System.Windows.Forms.Label();
            this.AltWeight_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesWeight_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlterNormalizedMatrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alternatives_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAlternative_button
            // 
            this.AddAlternative_button.Location = new System.Drawing.Point(316, 22);
            this.AddAlternative_button.Name = "AddAlternative_button";
            this.AddAlternative_button.Size = new System.Drawing.Size(75, 23);
            this.AddAlternative_button.TabIndex = 0;
            this.AddAlternative_button.Text = "Add";
            this.AddAlternative_button.UseVisualStyleBackColor = true;
            this.AddAlternative_button.Click += new System.EventHandler(this.AddAlternative_button_Click);
            // 
            // Alternatives_textBox
            // 
            this.Alternatives_textBox.Location = new System.Drawing.Point(142, 24);
            this.Alternatives_textBox.Name = "Alternatives_textBox";
            this.Alternatives_textBox.Size = new System.Drawing.Size(168, 20);
            this.Alternatives_textBox.TabIndex = 1;
            // 
            // Alternatives_listBox
            // 
            this.Alternatives_listBox.FormattingEnabled = true;
            this.Alternatives_listBox.Location = new System.Drawing.Point(12, 12);
            this.Alternatives_listBox.Name = "Alternatives_listBox";
            this.Alternatives_listBox.Size = new System.Drawing.Size(120, 303);
            this.Alternatives_listBox.TabIndex = 2;
            // 
            // AltCheckConsistency_button
            // 
            this.AltCheckConsistency_button.Location = new System.Drawing.Point(756, 238);
            this.AltCheckConsistency_button.Name = "AltCheckConsistency_button";
            this.AltCheckConsistency_button.Size = new System.Drawing.Size(110, 23);
            this.AltCheckConsistency_button.TabIndex = 19;
            this.AltCheckConsistency_button.Text = "Check Consistency";
            this.AltCheckConsistency_button.UseVisualStyleBackColor = true;
            this.AltCheckConsistency_button.Click += new System.EventHandler(this.AltCheckConsistency_button_Click);
            // 
            // AlternativesWeight_dgv
            // 
            this.AlternativesWeight_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativesWeight_dgv.Location = new System.Drawing.Point(775, 82);
            this.AlternativesWeight_dgv.Name = "AlternativesWeight_dgv";
            this.AlternativesWeight_dgv.Size = new System.Drawing.Size(91, 150);
            this.AlternativesWeight_dgv.TabIndex = 18;
            // 
            // AlterNormalizedMatrix_dgv
            // 
            this.AlterNormalizedMatrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlterNormalizedMatrix_dgv.Location = new System.Drawing.Point(516, 82);
            this.AlterNormalizedMatrix_dgv.Name = "AlterNormalizedMatrix_dgv";
            this.AlterNormalizedMatrix_dgv.Size = new System.Drawing.Size(240, 150);
            this.AlterNormalizedMatrix_dgv.TabIndex = 17;
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(307, 238);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 16;
            this.Update_button.Text = "Proceed";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // AlternativesCPC_button
            // 
            this.AlternativesCPC_button.Location = new System.Drawing.Point(142, 53);
            this.AlternativesCPC_button.Name = "AlternativesCPC_button";
            this.AlternativesCPC_button.Size = new System.Drawing.Size(155, 23);
            this.AlternativesCPC_button.TabIndex = 15;
            this.AlternativesCPC_button.Text = "Create Pairwise Comparison";
            this.AlternativesCPC_button.UseVisualStyleBackColor = true;
            this.AlternativesCPC_button.Click += new System.EventHandler(this.AlternativesCPC_button_Click);
            // 
            // Alternatives_dgv
            // 
            this.Alternatives_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Alternatives_dgv.Location = new System.Drawing.Point(142, 82);
            this.Alternatives_dgv.Name = "Alternatives_dgv";
            this.Alternatives_dgv.Size = new System.Drawing.Size(240, 150);
            this.Alternatives_dgv.TabIndex = 14;
            // 
            // Criterias_comboBox
            // 
            this.Criterias_comboBox.FormattingEnabled = true;
            this.Criterias_comboBox.Location = new System.Drawing.Point(388, 82);
            this.Criterias_comboBox.Name = "Criterias_comboBox";
            this.Criterias_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Criterias_comboBox.TabIndex = 20;
            // 
            // AltNorm_label
            // 
            this.AltNorm_label.AutoSize = true;
            this.AltNorm_label.Location = new System.Drawing.Point(513, 63);
            this.AltNorm_label.Name = "AltNorm_label";
            this.AltNorm_label.Size = new System.Drawing.Size(90, 13);
            this.AltNorm_label.TabIndex = 21;
            this.AltNorm_label.Text = "Normalized Matrix";
            // 
            // AltWeight_label
            // 
            this.AltWeight_label.AutoSize = true;
            this.AltWeight_label.Location = new System.Drawing.Point(772, 63);
            this.AltWeight_label.Name = "AltWeight_label";
            this.AltWeight_label.Size = new System.Drawing.Size(99, 13);
            this.AltWeight_label.TabIndex = 22;
            this.AltWeight_label.Text = "Alternatives Weight";
            // 
            // Alternatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 328);
            this.Controls.Add(this.AltWeight_label);
            this.Controls.Add(this.AltNorm_label);
            this.Controls.Add(this.Criterias_comboBox);
            this.Controls.Add(this.AltCheckConsistency_button);
            this.Controls.Add(this.AlternativesWeight_dgv);
            this.Controls.Add(this.AlterNormalizedMatrix_dgv);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.AlternativesCPC_button);
            this.Controls.Add(this.Alternatives_dgv);
            this.Controls.Add(this.Alternatives_listBox);
            this.Controls.Add(this.Alternatives_textBox);
            this.Controls.Add(this.AddAlternative_button);
            this.Name = "Alternatives";
            this.Text = "Alternatives";
            this.Load += new System.EventHandler(this.Alternatives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesWeight_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlterNormalizedMatrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alternatives_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAlternative_button;
        private System.Windows.Forms.TextBox Alternatives_textBox;
        private System.Windows.Forms.ListBox Alternatives_listBox;
        private System.Windows.Forms.Button AltCheckConsistency_button;
        private System.Windows.Forms.DataGridView AlternativesWeight_dgv;
        private System.Windows.Forms.DataGridView AlterNormalizedMatrix_dgv;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button AlternativesCPC_button;
        internal System.Windows.Forms.DataGridView Alternatives_dgv;
        private System.Windows.Forms.ComboBox Criterias_comboBox;
        private System.Windows.Forms.Label AltNorm_label;
        private System.Windows.Forms.Label AltWeight_label;
    }
}
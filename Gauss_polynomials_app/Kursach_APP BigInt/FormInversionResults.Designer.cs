namespace Kursach_APP
{
    partial class FormInversionResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInversions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInversions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "text";
            
            // 
            // dataGridViewInversions
            // 
            this.dataGridViewInversions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInversions.Location = new System.Drawing.Point(4, 25);
            this.dataGridViewInversions.Name = "dataGridViewInversions";
            this.dataGridViewInversions.ReadOnly = true;
            this.dataGridViewInversions.Size = new System.Drawing.Size(1471, 700);
            this.dataGridViewInversions.TabIndex = 1;
            
            // 
            // FormInversionResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 721);
            this.Controls.Add(this.dataGridViewInversions);
            this.Controls.Add(this.label1);
            this.Name = "FormInversionResults";
            this.Text = "FormInversionResults";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInversions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInversions;
    }
}
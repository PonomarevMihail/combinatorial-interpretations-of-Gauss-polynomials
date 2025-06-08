namespace Kursach_APP
{
    partial class WaysOfTheLameKing
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
            this.dataGridViewWaysLameKing = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaysLameKing)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridViewWaysLameKing
            // 
            this.dataGridViewWaysLameKing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWaysLameKing.Location = new System.Drawing.Point(13, 30);
            this.dataGridViewWaysLameKing.Name = "dataGridViewWaysLameKing";
            this.dataGridViewWaysLameKing.ReadOnly = true;
            this.dataGridViewWaysLameKing.Size = new System.Drawing.Size(775, 408);
            this.dataGridViewWaysLameKing.TabIndex = 1;
            this.dataGridViewWaysLameKing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WaysOfTheLameKing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewWaysLameKing);
            this.Controls.Add(this.label1);
            this.Name = "WaysOfTheLameKing";
            this.Text = "WaysOfTheLameKing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWaysLameKing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewWaysLameKing;
    }
}
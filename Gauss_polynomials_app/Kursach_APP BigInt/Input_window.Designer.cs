namespace Kursach_APP
{
    partial class Input_window
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
            this.label3 = new System.Windows.Forms.Label();
            this.InputCountOfInversions = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(100, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сколько инверсий вы хотите получить между двумя блоками:";
            // 
            // InputCountOfInversions
            // 
            this.InputCountOfInversions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputCountOfInversions.Location = new System.Drawing.Point(231, 80);
            this.InputCountOfInversions.Name = "InputCountOfInversions";
            this.InputCountOfInversions.Size = new System.Drawing.Size(204, 20);
            this.InputCountOfInversions.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Input_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputCountOfInversions);
            this.Controls.Add(this.label3);
            this.Name = "Input_window";
            this.Text = "Input_Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputCountOfInversions;
        private System.Windows.Forms.Button button1;
    }
}
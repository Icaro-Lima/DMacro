namespace DMacro
{
    partial class FormWait
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
            this.NumericUpDownMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMilliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUpDownMilliseconds
            // 
            this.NumericUpDownMilliseconds.Location = new System.Drawing.Point(94, 12);
            this.NumericUpDownMilliseconds.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumericUpDownMilliseconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownMilliseconds.Name = "NumericUpDownMilliseconds";
            this.NumericUpDownMilliseconds.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownMilliseconds.TabIndex = 4;
            this.NumericUpDownMilliseconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Milissegundos:";
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(12, 38);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(202, 23);
            this.ButtonOk.TabIndex = 6;
            this.ButtonOk.Text = "Ok!";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // FormWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 73);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownMilliseconds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWait";
            this.Text = "Esperar...";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMilliseconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUpDownMilliseconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonOk;
    }
}
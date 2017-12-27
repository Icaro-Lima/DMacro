namespace DMacro
{
    partial class FormComparePixel
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
            this.PictureBoxSelectColor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericUpDownLineToGoIfEquals = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownLineToGoIfNotEquals = new System.Windows.Forms.NumericUpDown();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureBoxSelectPixel = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLineToGoIfEquals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLineToGoIfNotEquals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectPixel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a cor:";
            // 
            // PictureBoxSelectColor
            // 
            this.PictureBoxSelectColor.BackColor = System.Drawing.Color.Black;
            this.PictureBoxSelectColor.Location = new System.Drawing.Point(102, 87);
            this.PictureBoxSelectColor.Name = "PictureBoxSelectColor";
            this.PictureBoxSelectColor.Size = new System.Drawing.Size(24, 24);
            this.PictureBoxSelectColor.TabIndex = 1;
            this.PictureBoxSelectColor.TabStop = false;
            this.PictureBoxSelectColor.Click += new System.EventHandler(this.PictureBoxSelectColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Linha para ir caso seja igual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Linha para ir caso seja diferente:";
            // 
            // NumericUpDownLineToGoIfEquals
            // 
            this.NumericUpDownLineToGoIfEquals.Location = new System.Drawing.Point(176, 117);
            this.NumericUpDownLineToGoIfEquals.Name = "NumericUpDownLineToGoIfEquals";
            this.NumericUpDownLineToGoIfEquals.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownLineToGoIfEquals.TabIndex = 4;
            // 
            // NumericUpDownLineToGoIfNotEquals
            // 
            this.NumericUpDownLineToGoIfNotEquals.Location = new System.Drawing.Point(176, 143);
            this.NumericUpDownLineToGoIfNotEquals.Name = "NumericUpDownLineToGoIfNotEquals";
            this.NumericUpDownLineToGoIfNotEquals.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownLineToGoIfNotEquals.TabIndex = 5;
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.Location = new System.Drawing.Point(12, 169);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(395, 23);
            this.ButtonOk.TabIndex = 6;
            this.ButtonOk.Text = "Ok!";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capturar posição do pixel:";
            // 
            // PictureBoxSelectPixel
            // 
            this.PictureBoxSelectPixel.Location = new System.Drawing.Point(147, 12);
            this.PictureBoxSelectPixel.Name = "PictureBoxSelectPixel";
            this.PictureBoxSelectPixel.Size = new System.Drawing.Size(69, 69);
            this.PictureBoxSelectPixel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxSelectPixel.TabIndex = 8;
            this.PictureBoxSelectPixel.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "(pressione Esc para gravar a posição)";
            // 
            // FormComparePixel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 204);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PictureBoxSelectPixel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.NumericUpDownLineToGoIfNotEquals);
            this.Controls.Add(this.NumericUpDownLineToGoIfEquals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PictureBoxSelectColor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormComparePixel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comparar pixel";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLineToGoIfEquals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLineToGoIfNotEquals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectPixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBoxSelectColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericUpDownLineToGoIfEquals;
        private System.Windows.Forms.NumericUpDown NumericUpDownLineToGoIfNotEquals;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PictureBoxSelectPixel;
        private System.Windows.Forms.Label label5;
    }
}
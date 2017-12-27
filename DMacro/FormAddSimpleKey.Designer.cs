namespace DMacro
{
    partial class FormAddSimpleKey
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
            this.ComboBoxKey = new System.Windows.Forms.ComboBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxKey
            // 
            this.ComboBoxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxKey.FormattingEnabled = true;
            this.ComboBoxKey.Location = new System.Drawing.Point(12, 14);
            this.ComboBoxKey.Name = "ComboBoxKey";
            this.ComboBoxKey.Size = new System.Drawing.Size(202, 21);
            this.ComboBoxKey.TabIndex = 1;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(12, 41);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(202, 23);
            this.ButtonOk.TabIndex = 2;
            this.ButtonOk.Text = "Ok!";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // FormAddSimpleKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 76);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ComboBoxKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddSimpleKey";
            this.Text = "Adicionar tecla simples";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxKey;
        private System.Windows.Forms.Button ButtonOk;
    }
}
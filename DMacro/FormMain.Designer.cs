namespace DMacro
{
    partial class FormMain
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
            this.ButtonAddEvent = new System.Windows.Forms.Button();
            this.ButtonRemoveSelected = new System.Windows.Forms.Button();
            this.ButtonConfigureHotkeys = new System.Windows.Forms.Button();
            this.ListBoxEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddEvent
            // 
            this.ButtonAddEvent.AutoSize = true;
            this.ButtonAddEvent.Location = new System.Drawing.Point(12, 553);
            this.ButtonAddEvent.Name = "ButtonAddEvent";
            this.ButtonAddEvent.Size = new System.Drawing.Size(97, 23);
            this.ButtonAddEvent.TabIndex = 0;
            this.ButtonAddEvent.Text = "Adicionar evento";
            this.ButtonAddEvent.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveSelected
            // 
            this.ButtonRemoveSelected.AutoSize = true;
            this.ButtonRemoveSelected.Location = new System.Drawing.Point(115, 553);
            this.ButtonRemoveSelected.Name = "ButtonRemoveSelected";
            this.ButtonRemoveSelected.Size = new System.Drawing.Size(120, 23);
            this.ButtonRemoveSelected.TabIndex = 1;
            this.ButtonRemoveSelected.Text = "Remover selecionado";
            this.ButtonRemoveSelected.UseVisualStyleBackColor = true;
            // 
            // ButtonConfigureHotkeys
            // 
            this.ButtonConfigureHotkeys.AutoSize = true;
            this.ButtonConfigureHotkeys.Location = new System.Drawing.Point(711, 553);
            this.ButtonConfigureHotkeys.Name = "ButtonConfigureHotkeys";
            this.ButtonConfigureHotkeys.Size = new System.Drawing.Size(105, 23);
            this.ButtonConfigureHotkeys.TabIndex = 2;
            this.ButtonConfigureHotkeys.Text = "Configurar hotkeys";
            this.ButtonConfigureHotkeys.UseVisualStyleBackColor = true;
            // 
            // ListBoxEvents
            // 
            this.ListBoxEvents.FormattingEnabled = true;
            this.ListBoxEvents.IntegralHeight = false;
            this.ListBoxEvents.Location = new System.Drawing.Point(12, 25);
            this.ListBoxEvents.Name = "ListBoxEvents";
            this.ListBoxEvents.Size = new System.Drawing.Size(804, 522);
            this.ListBoxEvents.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eventos:";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(468, 553);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Iniciar";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(549, 553);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 6;
            this.ButtonStop.Text = "Parar";
            this.ButtonStop.UseVisualStyleBackColor = true;
            // 
            // ButtonRecord
            // 
            this.ButtonRecord.Location = new System.Drawing.Point(630, 553);
            this.ButtonRecord.Name = "ButtonRecord";
            this.ButtonRecord.Size = new System.Drawing.Size(75, 23);
            this.ButtonRecord.TabIndex = 7;
            this.ButtonRecord.Text = "Gravar";
            this.ButtonRecord.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 588);
            this.Controls.Add(this.ButtonRecord);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxEvents);
            this.Controls.Add(this.ButtonConfigureHotkeys);
            this.Controls.Add(this.ButtonRemoveSelected);
            this.Controls.Add(this.ButtonAddEvent);
            this.Name = "Form1";
            this.Text = "DMacro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddEvent;
        private System.Windows.Forms.Button ButtonRemoveSelected;
        private System.Windows.Forms.Button ButtonConfigureHotkeys;
        private System.Windows.Forms.ListBox ListBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonRecord;
    }
}


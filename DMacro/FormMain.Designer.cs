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
            this.components = new System.ComponentModel.Container();
            this.ButtonAddEvent = new System.Windows.Forms.Button();
            this.ButtonRemoveSelected = new System.Windows.Forms.Button();
            this.ButtonConfigureHotkeys = new System.Windows.Forms.Button();
            this.ListBoxEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonRecord = new System.Windows.Forms.Button();
            this.ContextMenuStripAddEvent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MouseLeftButtonClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyboardKeyPressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WaitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PixelColorCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBoxEnumerated = new System.Windows.Forms.ListBox();
            this.MoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripAddEvent.SuspendLayout();
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
            this.ButtonAddEvent.Click += new System.EventHandler(this.ButtonAddEvent_Click);
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
            this.ButtonRemoveSelected.Click += new System.EventHandler(this.ButtonRemoveSelected_Click);
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
            this.ListBoxEvents.Location = new System.Drawing.Point(49, 25);
            this.ListBoxEvents.Name = "ListBoxEvents";
            this.ListBoxEvents.Size = new System.Drawing.Size(767, 522);
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
            // ContextMenuStripAddEvent
            // 
            this.ContextMenuStripAddEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseToolStripMenuItem,
            this.tecladoToolStripMenuItem,
            this.variadosToolStripMenuItem});
            this.ContextMenuStripAddEvent.Name = "ContextMenuStripAddEvent";
            this.ContextMenuStripAddEvent.Size = new System.Drawing.Size(153, 92);
            // 
            // mouseToolStripMenuItem
            // 
            this.mouseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveToolStripMenuItem,
            this.MouseLeftButtonClickToolStripMenuItem});
            this.mouseToolStripMenuItem.Name = "mouseToolStripMenuItem";
            this.mouseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mouseToolStripMenuItem.Text = "Mouse";
            // 
            // MouseLeftButtonClickToolStripMenuItem
            // 
            this.MouseLeftButtonClickToolStripMenuItem.Name = "MouseLeftButtonClickToolStripMenuItem";
            this.MouseLeftButtonClickToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.MouseLeftButtonClickToolStripMenuItem.Text = "Click com botão esquerdo";
            this.MouseLeftButtonClickToolStripMenuItem.Click += new System.EventHandler(this.MouseLeftButtonClickToolStripMenuItem_Click);
            // 
            // tecladoToolStripMenuItem
            // 
            this.tecladoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyboardKeyPressToolStripMenuItem});
            this.tecladoToolStripMenuItem.Name = "tecladoToolStripMenuItem";
            this.tecladoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tecladoToolStripMenuItem.Text = "Teclado";
            // 
            // KeyboardKeyPressToolStripMenuItem
            // 
            this.KeyboardKeyPressToolStripMenuItem.Name = "KeyboardKeyPressToolStripMenuItem";
            this.KeyboardKeyPressToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.KeyboardKeyPressToolStripMenuItem.Text = "Apertar tecla";
            this.KeyboardKeyPressToolStripMenuItem.Click += new System.EventHandler(this.KeyboardKeyPressToolStripMenuItem_Click);
            // 
            // variadosToolStripMenuItem
            // 
            this.variadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WaitToolStripMenuItem,
            this.GotoToolStripMenuItem,
            this.PixelColorCompareToolStripMenuItem});
            this.variadosToolStripMenuItem.Name = "variadosToolStripMenuItem";
            this.variadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.variadosToolStripMenuItem.Text = "Variados";
            // 
            // WaitToolStripMenuItem
            // 
            this.WaitToolStripMenuItem.Name = "WaitToolStripMenuItem";
            this.WaitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.WaitToolStripMenuItem.Text = "Esperar";
            this.WaitToolStripMenuItem.Click += new System.EventHandler(this.WaitToolStripMenuItem_Click);
            // 
            // GotoToolStripMenuItem
            // 
            this.GotoToolStripMenuItem.Name = "GotoToolStripMenuItem";
            this.GotoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.GotoToolStripMenuItem.Text = "Ir para...";
            this.GotoToolStripMenuItem.Click += new System.EventHandler(this.GotoToolStripMenuItem_Click);
            // 
            // PixelColorCompareToolStripMenuItem
            // 
            this.PixelColorCompareToolStripMenuItem.Name = "PixelColorCompareToolStripMenuItem";
            this.PixelColorCompareToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.PixelColorCompareToolStripMenuItem.Text = "Comparar cor de pixel";
            this.PixelColorCompareToolStripMenuItem.Click += new System.EventHandler(this.PixelColorCompareToolStripMenuItem_Click);
            // 
            // ListBoxEnumerated
            // 
            this.ListBoxEnumerated.FormattingEnabled = true;
            this.ListBoxEnumerated.IntegralHeight = false;
            this.ListBoxEnumerated.Location = new System.Drawing.Point(12, 25);
            this.ListBoxEnumerated.Name = "ListBoxEnumerated";
            this.ListBoxEnumerated.Size = new System.Drawing.Size(31, 522);
            this.ListBoxEnumerated.TabIndex = 8;
            // 
            // MoveToolStripMenuItem
            // 
            this.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem";
            this.MoveToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.MoveToolStripMenuItem.Text = "Mover";
            this.MoveToolStripMenuItem.Click += new System.EventHandler(this.MoveToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 588);
            this.Controls.Add(this.ListBoxEnumerated);
            this.Controls.Add(this.ButtonRecord);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxEvents);
            this.Controls.Add(this.ButtonConfigureHotkeys);
            this.Controls.Add(this.ButtonRemoveSelected);
            this.Controls.Add(this.ButtonAddEvent);
            this.Name = "FormMain";
            this.Text = "DMacro";
            this.ContextMenuStripAddEvent.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripAddEvent;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MouseLeftButtonClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyboardKeyPressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WaitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PixelColorCompareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GotoToolStripMenuItem;
        private System.Windows.Forms.ListBox ListBoxEnumerated;
        private System.Windows.Forms.ToolStripMenuItem MoveToolStripMenuItem;
    }
}


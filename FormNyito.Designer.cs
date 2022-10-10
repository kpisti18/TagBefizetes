namespace TagBefizetes
{
    partial class FormNyito
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ügyfélToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUGyfelek = new System.Windows.Forms.ListBox();
            this.befizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ügyfélToolStripMenuItem,
            this.befizetésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ügyfélToolStripMenuItem
            // 
            this.ügyfélToolStripMenuItem.Name = "ügyfélToolStripMenuItem";
            this.ügyfélToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ügyfélToolStripMenuItem.Text = "Ügyfél";
            // 
            // befizetésekToolStripMenuItem
            // 
            this.befizetésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.törlésToolStripMenuItem,
            this.befizetésToolStripMenuItem});
            this.befizetésekToolStripMenuItem.Name = "befizetésekToolStripMenuItem";
            this.befizetésekToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.befizetésekToolStripMenuItem.Text = "Befizetések";
            // 
            // lbUGyfelek
            // 
            this.lbUGyfelek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUGyfelek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUGyfelek.FormattingEnabled = true;
            this.lbUGyfelek.ItemHeight = 20;
            this.lbUGyfelek.Location = new System.Drawing.Point(0, 24);
            this.lbUGyfelek.Name = "lbUGyfelek";
            this.lbUGyfelek.Size = new System.Drawing.Size(414, 426);
            this.lbUGyfelek.TabIndex = 1;
            // 
            // befizetésToolStripMenuItem
            // 
            this.befizetésToolStripMenuItem.Name = "befizetésToolStripMenuItem";
            this.befizetésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.befizetésToolStripMenuItem.Text = "befizetés";
            this.befizetésToolStripMenuItem.Click += new System.EventHandler(this.befizetésToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "törlés";
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.lbUGyfelek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNyito";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormNyito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ügyfélToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem befizetésekToolStripMenuItem;
        public System.Windows.Forms.ListBox lbUGyfelek;
        private System.Windows.Forms.ToolStripMenuItem befizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
    }
}


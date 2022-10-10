namespace TagBefizetes
{
    partial class FormBefizetes
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
            this.tbNev = new System.Windows.Forms.TextBox();
            this.nudBefizet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btBefizet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBefizet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ügyfél neve";
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(110, 30);
            this.tbNev.Name = "tbNev";
            this.tbNev.ReadOnly = true;
            this.tbNev.Size = new System.Drawing.Size(173, 26);
            this.tbNev.TabIndex = 1;
            // 
            // nudBefizet
            // 
            this.nudBefizet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudBefizet.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBefizet.Location = new System.Drawing.Point(296, 30);
            this.nudBefizet.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudBefizet.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBefizet.Name = "nudBefizet";
            this.nudBefizet.Size = new System.Drawing.Size(120, 26);
            this.nudBefizet.TabIndex = 2;
            this.nudBefizet.ThousandsSeparator = true;
            this.nudBefizet.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(422, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ft";
            // 
            // btBefizet
            // 
            this.btBefizet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBefizet.Location = new System.Drawing.Point(461, 26);
            this.btBefizet.Name = "btBefizet";
            this.btBefizet.Size = new System.Drawing.Size(75, 35);
            this.btBefizet.TabIndex = 4;
            this.btBefizet.Text = "Befizet";
            this.btBefizet.UseVisualStyleBackColor = true;
            this.btBefizet.Click += new System.EventHandler(this.btBefizet_Click);
            // 
            // FormBefizetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 164);
            this.Controls.Add(this.btBefizet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudBefizet);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Name = "FormBefizetes";
            this.Text = "FormBefizetes";
            this.Load += new System.EventHandler(this.FormBefizetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBefizet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.NumericUpDown nudBefizet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBefizet;
    }
}
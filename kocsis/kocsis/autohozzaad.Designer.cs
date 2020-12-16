namespace kocsis
{
    partial class autohozzaad
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kor = new System.Windows.Forms.TextBox();
            this.fogyaszt = new System.Windows.Forms.TextBox();
            this.anyag = new System.Windows.Forms.TextBox();
            this.Nev = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hány éves?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mennyit fogyaszt 100-on?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Üzemanyag?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adja meg az autó nevét:";
            // 
            // kor
            // 
            this.kor.Location = new System.Drawing.Point(192, 134);
            this.kor.Name = "kor";
            this.kor.Size = new System.Drawing.Size(100, 20);
            this.kor.TabIndex = 22;
            this.kor.TextChanged += new System.EventHandler(this.kor_TextChanged);
            this.kor.Validating += new System.ComponentModel.CancelEventHandler(this.kor_Validating);
            // 
            // fogyaszt
            // 
            this.fogyaszt.Location = new System.Drawing.Point(192, 99);
            this.fogyaszt.Name = "fogyaszt";
            this.fogyaszt.Size = new System.Drawing.Size(100, 20);
            this.fogyaszt.TabIndex = 21;
            this.fogyaszt.TextChanged += new System.EventHandler(this.fogyaszt_TextChanged);
            this.fogyaszt.Validating += new System.ComponentModel.CancelEventHandler(this.fogyaszt_Validating);
            // 
            // anyag
            // 
            this.anyag.Location = new System.Drawing.Point(192, 58);
            this.anyag.Name = "anyag";
            this.anyag.Size = new System.Drawing.Size(100, 20);
            this.anyag.TabIndex = 20;
            this.anyag.TextChanged += new System.EventHandler(this.anyag_TextChanged);
            this.anyag.Validating += new System.ComponentModel.CancelEventHandler(this.anyag_Validating);
            // 
            // Nev
            // 
            this.Nev.Location = new System.Drawing.Point(192, 25);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(100, 20);
            this.Nev.TabIndex = 19;
            this.Nev.UseWaitCursor = true;
            this.Nev.TextChanged += new System.EventHandler(this.Nev_TextChanged);
            this.Nev.Validating += new System.ComponentModel.CancelEventHandler(this.Nev_Validating);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(43, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 76);
            this.button1.TabIndex = 27;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(265, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 76);
            this.button2.TabIndex = 28;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // autohozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kor);
            this.Controls.Add(this.fogyaszt);
            this.Controls.Add(this.anyag);
            this.Controls.Add(this.Nev);
            this.Name = "autohozzaad";
            this.Text = "autohozzaad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox kor;
        public System.Windows.Forms.TextBox fogyaszt;
        public System.Windows.Forms.TextBox anyag;
        public System.Windows.Forms.TextBox Nev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
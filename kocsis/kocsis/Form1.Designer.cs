namespace kocsis
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.createtimer = new System.Windows.Forms.Timer(this.components);
            this.conveyortimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 150);
            this.panel1.TabIndex = 0;
            // 
            // createtimer
            // 
            this.createtimer.Enabled = true;
            this.createtimer.Interval = 5000;
            this.createtimer.Tick += new System.EventHandler(this.createtimer_Tick);
            // 
            // conveyortimer
            // 
            this.conveyortimer.Enabled = true;
            this.conveyortimer.Interval = 10;
            this.conveyortimer.Tick += new System.EventHandler(this.conveyortimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 154);
            this.button1.TabIndex = 1;
            this.button1.Text = "Autó választás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 154);
            this.button2.TabIndex = 2;
            this.button2.Text = "Adatbázis szerkesztése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer createtimer;
        private System.Windows.Forms.Timer conveyortimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


namespace Reszke
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sideNavPanel.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideNavPanel.Controls.Add(this.panel1);
            this.sideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(163, 450);
            this.sideNavPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(169, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 438);
            this.panel1.TabIndex = 1;
            // 
            // welcomePanel
            // 
            this.welcomePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.welcomePanel.Controls.Add(this.button1);
            this.welcomePanel.Location = new System.Drawing.Point(169, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(619, 450);
            this.welcomePanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(510, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 574);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.sideNavPanel);
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "mainForm";
            this.Text = "Biblioteka - Reszke, Zaindin, Wierkin, Wysocki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideNavPanel.ResumeLayout(false);
            this.welcomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sideNavPanel;
        private Panel panel1;
        private Panel welcomePanel;
        private Button button1;
    }
}
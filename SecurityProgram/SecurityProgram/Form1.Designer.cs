namespace SecurityProgram
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
            this.btnTurnOnFirewall = new System.Windows.Forms.Button();
            this.btnTurnOnDefender = new System.Windows.Forms.Button();
            this.btnAutomateDefender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTurnOnFirewall
            // 
            this.btnTurnOnFirewall.Location = new System.Drawing.Point(66, 12);
            this.btnTurnOnFirewall.Name = "btnTurnOnFirewall";
            this.btnTurnOnFirewall.Size = new System.Drawing.Size(155, 23);
            this.btnTurnOnFirewall.TabIndex = 0;
            this.btnTurnOnFirewall.Text = "Turn On Firewall";
            this.btnTurnOnFirewall.UseVisualStyleBackColor = true;
            this.btnTurnOnFirewall.Click += new System.EventHandler(this.btnTurnOnFirewall_Click);
            // 
            // btnTurnOnDefender
            // 
            this.btnTurnOnDefender.Location = new System.Drawing.Point(66, 41);
            this.btnTurnOnDefender.Name = "btnTurnOnDefender";
            this.btnTurnOnDefender.Size = new System.Drawing.Size(155, 23);
            this.btnTurnOnDefender.TabIndex = 1;
            this.btnTurnOnDefender.Text = "Turn On Defender";
            this.btnTurnOnDefender.UseVisualStyleBackColor = true;
            this.btnTurnOnDefender.Click += new System.EventHandler(this.btnTurnOnDefender_Click);
            // 
            // btnAutomateDefender
            // 
            this.btnAutomateDefender.Location = new System.Drawing.Point(66, 71);
            this.btnAutomateDefender.Name = "btnAutomateDefender";
            this.btnAutomateDefender.Size = new System.Drawing.Size(155, 23);
            this.btnAutomateDefender.TabIndex = 2;
            this.btnAutomateDefender.Text = "Automate Defender";
            this.btnAutomateDefender.UseVisualStyleBackColor = true;
            this.btnAutomateDefender.Click += new System.EventHandler(this.btnAutomateDefender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAutomateDefender);
            this.Controls.Add(this.btnTurnOnDefender);
            this.Controls.Add(this.btnTurnOnFirewall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTurnOnFirewall;
        private System.Windows.Forms.Button btnTurnOnDefender;
        private System.Windows.Forms.Button btnAutomateDefender;
    }
}


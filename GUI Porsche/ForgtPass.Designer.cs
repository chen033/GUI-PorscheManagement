namespace GUI_Porsche
{
    partial class ForgtPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgtPass));
            this.txtMail3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRePass = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.LinkLabel();
            this.lblpass1 = new System.Windows.Forms.Label();
            this.txtpass3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMail3
            // 
            this.txtMail3.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail3.Location = new System.Drawing.Point(263, 115);
            this.txtMail3.Name = "txtMail3";
            this.txtMail3.Size = new System.Drawing.Size(221, 35);
            this.txtMail3.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Email ID";
            // 
            // btnRePass
            // 
            this.btnRePass.BackColor = System.Drawing.Color.LightBlue;
            this.btnRePass.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePass.Location = new System.Drawing.Point(115, 324);
            this.btnRePass.Name = "btnRePass";
            this.btnRePass.Size = new System.Drawing.Size(369, 43);
            this.btnRePass.TabIndex = 23;
            this.btnRePass.Text = "Retrive Password";
            this.btnRePass.UseVisualStyleBackColor = false;
            this.btnRePass.Click += new System.EventHandler(this.btnRePass_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(76, 441);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(258, 28);
            this.lblLog.TabIndex = 24;
            this.lblLog.TabStop = true;
            this.lblLog.Text = "Go Back to Login";
            this.lblLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLog_LinkClicked);
            // 
            // lblpass1
            // 
            this.lblpass1.AutoSize = true;
            this.lblpass1.BackColor = System.Drawing.Color.Transparent;
            this.lblpass1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass1.ForeColor = System.Drawing.Color.White;
            this.lblpass1.Location = new System.Drawing.Point(75, 210);
            this.lblpass1.Name = "lblpass1";
            this.lblpass1.Size = new System.Drawing.Size(150, 28);
            this.lblpass1.TabIndex = 20;
            this.lblpass1.Text = "Password";
            // 
            // txtpass3
            // 
            this.txtpass3.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass3.Location = new System.Drawing.Point(263, 203);
            this.txtpass3.Name = "txtpass3";
            this.txtpass3.ReadOnly = true;
            this.txtpass3.Size = new System.Drawing.Size(221, 35);
            this.txtpass3.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRePass);
            this.panel1.Controls.Add(this.txtMail3);
            this.panel1.Controls.Add(this.txtpass3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblpass1);
            this.panel1.Controls.Add(this.lblLog);
            this.panel1.Location = new System.Drawing.Point(36, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 525);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ForgtPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 636);
            this.Controls.Add(this.panel1);
            this.Name = "ForgtPass";
            this.Text = "ForgtPass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRePass;
        private System.Windows.Forms.LinkLabel lblLog;
        private System.Windows.Forms.Label lblpass1;
        private System.Windows.Forms.TextBox txtpass3;
        private System.Windows.Forms.Panel panel1;
    }
}
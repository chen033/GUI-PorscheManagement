namespace GUI_Porsche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkFpass = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbllnkSign = new System.Windows.Forms.LinkLabel();
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblpass1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.txtpass1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkFpass
            // 
            this.linkFpass.AutoSize = true;
            this.linkFpass.BackColor = System.Drawing.Color.Transparent;
            this.linkFpass.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFpass.LinkColor = System.Drawing.Color.Red;
            this.linkFpass.Location = new System.Drawing.Point(322, 333);
            this.linkFpass.Name = "linkFpass";
            this.linkFpass.Size = new System.Drawing.Size(269, 28);
            this.linkFpass.TabIndex = 18;
            this.linkFpass.TabStop = true;
            this.linkFpass.Text = "Forgot Password?";
            this.linkFpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFpass_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(270, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Log In";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogin.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(179, 405);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(279, 48);
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbllnkSign
            // 
            this.lbllnkSign.AutoSize = true;
            this.lbllnkSign.BackColor = System.Drawing.Color.Transparent;
            this.lbllnkSign.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllnkSign.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbllnkSign.Location = new System.Drawing.Point(374, 505);
            this.lbllnkSign.Name = "lbllnkSign";
            this.lbllnkSign.Size = new System.Drawing.Size(185, 28);
            this.lbllnkSign.TabIndex = 16;
            this.lbllnkSign.TabStop = true;
            this.lbllnkSign.Text = "Sign up now";
            this.lbllnkSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllnkSign_LinkClicked);
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.BackColor = System.Drawing.Color.Transparent;
            this.lblname1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname1.ForeColor = System.Drawing.Color.White;
            this.lblname1.Location = new System.Drawing.Point(125, 171);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(149, 28);
            this.lblname1.TabIndex = 10;
            this.lblname1.Text = "Username";
            // 
            // lblpass1
            // 
            this.lblpass1.AutoSize = true;
            this.lblpass1.BackColor = System.Drawing.Color.Transparent;
            this.lblpass1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass1.ForeColor = System.Drawing.Color.White;
            this.lblpass1.Location = new System.Drawing.Point(124, 275);
            this.lblpass1.Name = "lblpass1";
            this.lblpass1.Size = new System.Drawing.Size(150, 28);
            this.lblpass1.TabIndex = 11;
            this.lblpass1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Not a member?";
            // 
            // txtname1
            // 
            this.txtname1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname1.Location = new System.Drawing.Point(300, 171);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(221, 35);
            this.txtname1.TabIndex = 12;
            // 
            // txtpass1
            // 
            this.txtpass1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass1.Location = new System.Drawing.Point(300, 268);
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(221, 35);
            this.txtpass1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkFpass);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtpass1);
            this.panel1.Controls.Add(this.txtname1);
            this.panel1.Controls.Add(this.lbllnkSign);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblname1);
            this.panel1.Controls.Add(this.lblpass1);
            this.panel1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(32, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 589);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 667);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkFpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lbllnkSign;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Label lblpass1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.TextBox txtpass1;
        private System.Windows.Forms.Panel panel1;
    }
}


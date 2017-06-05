namespace PlantaePickerus_proto
{
    partial class CreateAccount
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
            System.Windows.Forms.Label labelHeader;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.labelEnterDetails = new System.Windows.Forms.Label();
            this.labelNewUsername = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonSubmitNewUser = new System.Windows.Forms.Button();
            labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            labelHeader.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelHeader.ForeColor = System.Drawing.Color.White;
            labelHeader.Location = new System.Drawing.Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Padding = new System.Windows.Forms.Padding(12, 0, 0, 4);
            labelHeader.Size = new System.Drawing.Size(664, 64);
            labelHeader.TabIndex = 4;
            labelHeader.Text = "Create New Account";
            labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEnterDetails
            // 
            this.labelEnterDetails.AutoSize = true;
            this.labelEnterDetails.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelEnterDetails.Location = new System.Drawing.Point(131, 107);
            this.labelEnterDetails.Name = "labelEnterDetails";
            this.labelEnterDetails.Size = new System.Drawing.Size(370, 25);
            this.labelEnterDetails.TabIndex = 5;
            this.labelEnterDetails.Text = "Enter your details below and click “submit”";
            this.labelEnterDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNewUsername
            // 
            this.labelNewUsername.AutoSize = true;
            this.labelNewUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNewUsername.Location = new System.Drawing.Point(120, 217);
            this.labelNewUsername.Name = "labelNewUsername";
            this.labelNewUsername.Size = new System.Drawing.Size(99, 25);
            this.labelNewUsername.TabIndex = 6;
            this.labelNewUsername.Text = "username:";
            this.labelNewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNewPassword.Location = new System.Drawing.Point(123, 269);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(96, 25);
            this.labelNewPassword.TabIndex = 7;
            this.labelNewPassword.Text = "password:";
            this.labelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxNewUsername.Location = new System.Drawing.Point(225, 214);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(298, 32);
            this.textBoxNewUsername.TabIndex = 8;
            this.textBoxNewUsername.TextChanged += new System.EventHandler(this.textBoxNewUsername_TextChanged);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxNewPassword.Location = new System.Drawing.Point(225, 266);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(298, 32);
            this.textBoxNewPassword.TabIndex = 9;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged);
            // 
            // buttonSubmitNewUser
            // 
            this.buttonSubmitNewUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSubmitNewUser.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSubmitNewUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSubmitNewUser.FlatAppearance.BorderSize = 2;
            this.buttonSubmitNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitNewUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonSubmitNewUser.ForeColor = System.Drawing.Color.White;
            this.buttonSubmitNewUser.Location = new System.Drawing.Point(242, 378);
            this.buttonSubmitNewUser.Name = "buttonSubmitNewUser";
            this.buttonSubmitNewUser.Size = new System.Drawing.Size(180, 43);
            this.buttonSubmitNewUser.TabIndex = 11;
            this.buttonSubmitNewUser.Text = "Submit";
            this.buttonSubmitNewUser.UseVisualStyleBackColor = false;
            this.buttonSubmitNewUser.Click += new System.EventHandler(this.buttonSubmitNewUser_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(664, 482);
            this.Controls.Add(this.buttonSubmitNewUser);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewUsername);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelNewUsername);
            this.Controls.Add(this.labelEnterDetails);
            this.Controls.Add(labelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantae Pickerus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateAccount_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterDetails;
        private System.Windows.Forms.Label labelNewUsername;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonSubmitNewUser;
    }
}
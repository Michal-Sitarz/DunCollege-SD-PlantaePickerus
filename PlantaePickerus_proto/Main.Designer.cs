

namespace PlantaePickerus_proto
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonManageMyHouse = new System.Windows.Forms.Button();
            this.buttonFindPlant = new System.Windows.Forms.Button();
            this.buttonFindSpot = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
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
            labelHeader.Size = new System.Drawing.Size(1008, 64);
            labelHeader.TabIndex = 3;
            labelHeader.Text = "user:";
            labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonManageMyHouse
            // 
            this.buttonManageMyHouse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonManageMyHouse.FlatAppearance.BorderSize = 2;
            this.buttonManageMyHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageMyHouse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonManageMyHouse.ForeColor = System.Drawing.Color.White;
            this.buttonManageMyHouse.Location = new System.Drawing.Point(383, 214);
            this.buttonManageMyHouse.Name = "buttonManageMyHouse";
            this.buttonManageMyHouse.Size = new System.Drawing.Size(256, 64);
            this.buttonManageMyHouse.TabIndex = 0;
            this.buttonManageMyHouse.Text = "Manage My House";
            this.buttonManageMyHouse.UseVisualStyleBackColor = false;
            this.buttonManageMyHouse.Click += new System.EventHandler(this.buttonManageMyHouse_Click);
            // 
            // buttonFindPlant
            // 
            this.buttonFindPlant.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonFindPlant.FlatAppearance.BorderSize = 2;
            this.buttonFindPlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindPlant.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonFindPlant.ForeColor = System.Drawing.Color.White;
            this.buttonFindPlant.Location = new System.Drawing.Point(238, 373);
            this.buttonFindPlant.Name = "buttonFindPlant";
            this.buttonFindPlant.Size = new System.Drawing.Size(256, 64);
            this.buttonFindPlant.TabIndex = 1;
            this.buttonFindPlant.Text = "Find a plant\r\nfor desired place";
            this.buttonFindPlant.UseVisualStyleBackColor = false;
            this.buttonFindPlant.Click += new System.EventHandler(this.buttonFindPlant_Click);
            // 
            // buttonFindSpot
            // 
            this.buttonFindSpot.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonFindSpot.FlatAppearance.BorderSize = 2;
            this.buttonFindSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindSpot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonFindSpot.ForeColor = System.Drawing.Color.White;
            this.buttonFindSpot.Location = new System.Drawing.Point(531, 373);
            this.buttonFindSpot.Name = "buttonFindSpot";
            this.buttonFindSpot.Size = new System.Drawing.Size(256, 64);
            this.buttonFindSpot.TabIndex = 2;
            this.buttonFindSpot.Text = "Find a spot\r\nfor desired plant";
            this.buttonFindSpot.UseVisualStyleBackColor = false;
            this.buttonFindSpot.Click += new System.EventHandler(this.buttonFindSpot_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogOut.FlatAppearance.BorderSize = 2;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(827, 16);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(149, 33);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(67, 14);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 32);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(labelHeader);
            this.Controls.Add(this.buttonFindSpot);
            this.Controls.Add(this.buttonFindPlant);
            this.Controls.Add(this.buttonManageMyHouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantae Pickerus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManageMyHouse;
        private System.Windows.Forms.Button buttonFindPlant;
        private System.Windows.Forms.Button buttonFindSpot;
        private System.Windows.Forms.Button buttonLogOut;
        internal System.Windows.Forms.Label labelUsername;
    }
}


namespace PlantaePickerus_proto
{
    partial class MyRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRoom));
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.buttonDeleteSpot = new System.Windows.Forms.Button();
            this.buttonEditSpot = new System.Windows.Forms.Button();
            this.buttonAddSpot = new System.Windows.Forms.Button();
            this.listBoxSpots = new System.Windows.Forms.ListBox();
            this.groupBoxSpots = new System.Windows.Forms.GroupBox();
            this.labelSpotsShowTip = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            labelHeader = new System.Windows.Forms.Label();
            this.groupBoxSpots.SuspendLayout();
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
            labelHeader.TabIndex = 4;
            labelHeader.Text = "Room:";
            labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGoBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGoBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGoBack.FlatAppearance.BorderSize = 2;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGoBack.ForeColor = System.Drawing.Color.White;
            this.buttonGoBack.Location = new System.Drawing.Point(647, 16);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.buttonGoBack.Size = new System.Drawing.Size(149, 33);
            this.buttonGoBack.TabIndex = 6;
            this.buttonGoBack.Text = "<<   Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelRoomName.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.labelRoomName.ForeColor = System.Drawing.Color.White;
            this.labelRoomName.Location = new System.Drawing.Point(85, 14);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(0, 32);
            this.labelRoomName.TabIndex = 15;
            this.labelRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeleteSpot
            // 
            this.buttonDeleteSpot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteSpot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDeleteSpot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteSpot.FlatAppearance.BorderSize = 2;
            this.buttonDeleteSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSpot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonDeleteSpot.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteSpot.Location = new System.Drawing.Point(636, 494);
            this.buttonDeleteSpot.Name = "buttonDeleteSpot";
            this.buttonDeleteSpot.Size = new System.Drawing.Size(160, 38);
            this.buttonDeleteSpot.TabIndex = 13;
            this.buttonDeleteSpot.Text = "Delete Spot";
            this.buttonDeleteSpot.UseVisualStyleBackColor = false;
            this.buttonDeleteSpot.Click += new System.EventHandler(this.buttonDeleteSpot_Click);
            // 
            // buttonEditSpot
            // 
            this.buttonEditSpot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEditSpot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEditSpot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditSpot.FlatAppearance.BorderSize = 2;
            this.buttonEditSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditSpot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonEditSpot.ForeColor = System.Drawing.Color.White;
            this.buttonEditSpot.Location = new System.Drawing.Point(470, 494);
            this.buttonEditSpot.Name = "buttonEditSpot";
            this.buttonEditSpot.Size = new System.Drawing.Size(160, 38);
            this.buttonEditSpot.TabIndex = 12;
            this.buttonEditSpot.Text = "Edit Spot";
            this.buttonEditSpot.UseVisualStyleBackColor = false;
            this.buttonEditSpot.Click += new System.EventHandler(this.buttonEditSpot_Click);
            // 
            // buttonAddSpot
            // 
            this.buttonAddSpot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddSpot.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddSpot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddSpot.FlatAppearance.BorderSize = 2;
            this.buttonAddSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSpot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonAddSpot.ForeColor = System.Drawing.Color.White;
            this.buttonAddSpot.Location = new System.Drawing.Point(210, 494);
            this.buttonAddSpot.Name = "buttonAddSpot";
            this.buttonAddSpot.Size = new System.Drawing.Size(254, 38);
            this.buttonAddSpot.TabIndex = 11;
            this.buttonAddSpot.Text = "Add Spot";
            this.buttonAddSpot.UseVisualStyleBackColor = false;
            this.buttonAddSpot.Click += new System.EventHandler(this.buttonAddSpot_Click);
            // 
            // listBoxSpots
            // 
            this.listBoxSpots.BackColor = System.Drawing.Color.Silver;
            this.listBoxSpots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSpots.FormattingEnabled = true;
            this.listBoxSpots.ItemHeight = 25;
            this.listBoxSpots.Location = new System.Drawing.Point(18, 29);
            this.listBoxSpots.Name = "listBoxSpots";
            this.listBoxSpots.Size = new System.Drawing.Size(562, 350);
            this.listBoxSpots.TabIndex = 0;
            this.listBoxSpots.DoubleClick += new System.EventHandler(this.listBoxSpots_DoubleClick);
            // 
            // groupBoxSpots
            // 
            this.groupBoxSpots.Controls.Add(this.listBoxSpots);
            this.groupBoxSpots.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBoxSpots.ForeColor = System.Drawing.Color.White;
            this.groupBoxSpots.Location = new System.Drawing.Point(210, 97);
            this.groupBoxSpots.Name = "groupBoxSpots";
            this.groupBoxSpots.Size = new System.Drawing.Size(586, 391);
            this.groupBoxSpots.TabIndex = 8;
            this.groupBoxSpots.TabStop = false;
            this.groupBoxSpots.Text = "Spots:";
            // 
            // labelSpotsShowTip
            // 
            this.labelSpotsShowTip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelSpotsShowTip.ForeColor = System.Drawing.Color.DimGray;
            this.labelSpotsShowTip.Location = new System.Drawing.Point(804, 108);
            this.labelSpotsShowTip.Name = "labelSpotsShowTip";
            this.labelSpotsShowTip.Size = new System.Drawing.Size(149, 81);
            this.labelSpotsShowTip.TabIndex = 15;
            this.labelSpotsShowTip.Text = "Hint: \r\nDouble-click on a spot \r\nname to see/manage \r\nplants around it.";
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
            this.buttonLogOut.TabIndex = 17;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // MyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelSpotsShowTip);
            this.Controls.Add(this.labelRoomName);
            this.Controls.Add(this.buttonDeleteSpot);
            this.Controls.Add(this.buttonEditSpot);
            this.Controls.Add(this.buttonAddSpot);
            this.Controls.Add(this.groupBoxSpots);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(labelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantae Pickerus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyRoom_FormClosed);
            this.groupBoxSpots.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGoBack;
        internal System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Button buttonDeleteSpot;
        private System.Windows.Forms.Button buttonEditSpot;
        private System.Windows.Forms.Button buttonAddSpot;
        private System.Windows.Forms.ListBox listBoxSpots;
        private System.Windows.Forms.GroupBox groupBoxSpots;
        private System.Windows.Forms.Label labelSpotsShowTip;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
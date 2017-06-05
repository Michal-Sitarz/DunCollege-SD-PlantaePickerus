namespace PlantaePickerus_proto
{
    partial class MyHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyHouse));
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.groupBoxRooms = new System.Windows.Forms.GroupBox();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.labelRoomsShowTip = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            labelHeader = new System.Windows.Forms.Label();
            this.groupBoxRooms.SuspendLayout();
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
            labelHeader.Text = "My House";
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
            // groupBoxRooms
            // 
            this.groupBoxRooms.Controls.Add(this.listBoxRooms);
            this.groupBoxRooms.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBoxRooms.ForeColor = System.Drawing.Color.White;
            this.groupBoxRooms.Location = new System.Drawing.Point(210, 97);
            this.groupBoxRooms.Name = "groupBoxRooms";
            this.groupBoxRooms.Size = new System.Drawing.Size(586, 391);
            this.groupBoxRooms.TabIndex = 8;
            this.groupBoxRooms.TabStop = false;
            this.groupBoxRooms.Text = "Rooms:";
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.BackColor = System.Drawing.Color.Silver;
            this.listBoxRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.ItemHeight = 25;
            this.listBoxRooms.Location = new System.Drawing.Point(18, 29);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(562, 350);
            this.listBoxRooms.TabIndex = 0;
            this.listBoxRooms.DoubleClick += new System.EventHandler(this.listBoxRooms_DoubleClick);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddRoom.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddRoom.FlatAppearance.BorderSize = 2;
            this.buttonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonAddRoom.ForeColor = System.Drawing.Color.White;
            this.buttonAddRoom.Location = new System.Drawing.Point(210, 494);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(254, 38);
            this.buttonAddRoom.TabIndex = 11;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEditRoom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEditRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditRoom.FlatAppearance.BorderSize = 2;
            this.buttonEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonEditRoom.ForeColor = System.Drawing.Color.White;
            this.buttonEditRoom.Location = new System.Drawing.Point(470, 494);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(160, 38);
            this.buttonEditRoom.TabIndex = 12;
            this.buttonEditRoom.Text = "Edit Room";
            this.buttonEditRoom.UseVisualStyleBackColor = false;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeleteRoom.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDeleteRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteRoom.FlatAppearance.BorderSize = 2;
            this.buttonDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteRoom.Location = new System.Drawing.Point(636, 494);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(160, 38);
            this.buttonDeleteRoom.TabIndex = 13;
            this.buttonDeleteRoom.Text = "Delete Room";
            this.buttonDeleteRoom.UseVisualStyleBackColor = false;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // labelRoomsShowTip
            // 
            this.labelRoomsShowTip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelRoomsShowTip.ForeColor = System.Drawing.Color.DimGray;
            this.labelRoomsShowTip.Location = new System.Drawing.Point(804, 108);
            this.labelRoomsShowTip.Name = "labelRoomsShowTip";
            this.labelRoomsShowTip.Size = new System.Drawing.Size(149, 81);
            this.labelRoomsShowTip.TabIndex = 14;
            this.labelRoomsShowTip.Text = "Hint: \r\nDouble-click on a room \r\nname to see/manage \r\nplant spots around it.";
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
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // MyHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelRoomsShowTip);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.groupBoxRooms);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(labelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantae Pickerus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyHouse_FormClosed);
            this.groupBoxRooms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.GroupBox groupBoxRooms;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Label labelRoomsShowTip;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
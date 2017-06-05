namespace PlantaePickerus_proto
{
    partial class MySpot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySpot));
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.labelSpotName = new System.Windows.Forms.Label();
            this.buttonDeletePlant = new System.Windows.Forms.Button();
            this.buttonAddPlant = new System.Windows.Forms.Button();
            this.listBoxPlants = new System.Windows.Forms.ListBox();
            this.groupBoxPlants = new System.Windows.Forms.GroupBox();
            this.labelPlantsShowTip = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            labelHeader = new System.Windows.Forms.Label();
            this.groupBoxPlants.SuspendLayout();
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
            labelHeader.Text = "Spot:";
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
            // labelSpotName
            // 
            this.labelSpotName.AutoSize = true;
            this.labelSpotName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelSpotName.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.labelSpotName.ForeColor = System.Drawing.Color.White;
            this.labelSpotName.Location = new System.Drawing.Point(71, 14);
            this.labelSpotName.Name = "labelSpotName";
            this.labelSpotName.Size = new System.Drawing.Size(0, 32);
            this.labelSpotName.TabIndex = 15;
            this.labelSpotName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeletePlant
            // 
            this.buttonDeletePlant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDeletePlant.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDeletePlant.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeletePlant.FlatAppearance.BorderSize = 2;
            this.buttonDeletePlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePlant.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonDeletePlant.ForeColor = System.Drawing.Color.White;
            this.buttonDeletePlant.Location = new System.Drawing.Point(506, 494);
            this.buttonDeletePlant.Name = "buttonDeletePlant";
            this.buttonDeletePlant.Size = new System.Drawing.Size(230, 38);
            this.buttonDeletePlant.TabIndex = 13;
            this.buttonDeletePlant.Text = "Delete Plant";
            this.buttonDeletePlant.UseVisualStyleBackColor = false;
            this.buttonDeletePlant.Click += new System.EventHandler(this.buttonDeletePlant_Click);
            // 
            // buttonAddPlant
            // 
            this.buttonAddPlant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddPlant.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAddPlant.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddPlant.FlatAppearance.BorderSize = 2;
            this.buttonAddPlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlant.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonAddPlant.ForeColor = System.Drawing.Color.White;
            this.buttonAddPlant.Location = new System.Drawing.Point(270, 494);
            this.buttonAddPlant.Name = "buttonAddPlant";
            this.buttonAddPlant.Size = new System.Drawing.Size(230, 38);
            this.buttonAddPlant.TabIndex = 11;
            this.buttonAddPlant.Text = "Add Plant";
            this.buttonAddPlant.UseVisualStyleBackColor = false;
            this.buttonAddPlant.Click += new System.EventHandler(this.buttonAddPlant_Click);
            // 
            // listBoxPlants
            // 
            this.listBoxPlants.BackColor = System.Drawing.Color.Silver;
            this.listBoxPlants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlants.FormattingEnabled = true;
            this.listBoxPlants.ItemHeight = 25;
            this.listBoxPlants.Location = new System.Drawing.Point(18, 29);
            this.listBoxPlants.Name = "listBoxPlants";
            this.listBoxPlants.Size = new System.Drawing.Size(562, 350);
            this.listBoxPlants.TabIndex = 0;
            this.listBoxPlants.DoubleClick += new System.EventHandler(this.listBoxPlants_DoubleClick);
            // 
            // groupBoxPlants
            // 
            this.groupBoxPlants.Controls.Add(this.listBoxPlants);
            this.groupBoxPlants.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBoxPlants.ForeColor = System.Drawing.Color.White;
            this.groupBoxPlants.Location = new System.Drawing.Point(210, 97);
            this.groupBoxPlants.Name = "groupBoxPlants";
            this.groupBoxPlants.Size = new System.Drawing.Size(586, 391);
            this.groupBoxPlants.TabIndex = 8;
            this.groupBoxPlants.TabStop = false;
            this.groupBoxPlants.Text = "Plants:";
            // 
            // labelPlantsShowTip
            // 
            this.labelPlantsShowTip.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelPlantsShowTip.ForeColor = System.Drawing.Color.DimGray;
            this.labelPlantsShowTip.Location = new System.Drawing.Point(804, 108);
            this.labelPlantsShowTip.Name = "labelPlantsShowTip";
            this.labelPlantsShowTip.Size = new System.Drawing.Size(149, 81);
            this.labelPlantsShowTip.TabIndex = 15;
            this.labelPlantsShowTip.Text = "Hint: \r\nDouble-click on a plant \r\nto see more details.";
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
            this.buttonLogOut.TabIndex = 16;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // MySpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelPlantsShowTip);
            this.Controls.Add(this.labelSpotName);
            this.Controls.Add(this.buttonDeletePlant);
            this.Controls.Add(this.buttonAddPlant);
            this.Controls.Add(this.groupBoxPlants);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(labelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MySpot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantae Pickerus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MySpot_FormClosed);
            this.groupBoxPlants.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGoBack;
        internal System.Windows.Forms.Label labelSpotName;
        private System.Windows.Forms.Button buttonDeletePlant;
        private System.Windows.Forms.Button buttonAddPlant;
        private System.Windows.Forms.ListBox listBoxPlants;
        private System.Windows.Forms.GroupBox groupBoxPlants;
        private System.Windows.Forms.Label labelPlantsShowTip;
        private System.Windows.Forms.Button buttonLogOut;
    }
}
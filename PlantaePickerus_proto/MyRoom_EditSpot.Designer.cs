namespace PlantaePickerus_proto
{
    partial class MyRoom_EditSpot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRoom_EditSpot));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxSpotName = new System.Windows.Forms.TextBox();
            this.labelSpotName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxColdDrafts = new System.Windows.Forms.CheckBox();
            this.groupBoxSpotConditions = new System.Windows.Forms.GroupBox();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.comboBoxHumidity = new System.Windows.Forms.ComboBox();
            this.comboBoxSunlight = new System.Windows.Forms.ComboBox();
            labelHeader = new System.Windows.Forms.Label();
            this.groupBoxSpotConditions.SuspendLayout();
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
            labelHeader.Size = new System.Drawing.Size(344, 64);
            labelHeader.TabIndex = 4;
            labelHeader.Text = "Edit Spot";
            labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(97, 462);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(149, 33);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOK.FlatAppearance.BorderSize = 2;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(97, 414);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(149, 33);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxSpotName
            // 
            this.textBoxSpotName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxSpotName.Location = new System.Drawing.Point(41, 118);
            this.textBoxSpotName.Name = "textBoxSpotName";
            this.textBoxSpotName.Size = new System.Drawing.Size(260, 32);
            this.textBoxSpotName.TabIndex = 9;
            this.textBoxSpotName.TextChanged += new System.EventHandler(this.textBoxSpotName_TextChanged);
            this.textBoxSpotName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSpotName_KeyDown);
            // 
            // labelSpotName
            // 
            this.labelSpotName.AutoSize = true;
            this.labelSpotName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelSpotName.Location = new System.Drawing.Point(36, 84);
            this.labelSpotName.Name = "labelSpotName";
            this.labelSpotName.Size = new System.Drawing.Size(106, 25);
            this.labelSpotName.TabIndex = 10;
            this.labelSpotName.Text = "Spot name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "sunlight:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "humidity:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "sun direction:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "cold drafts:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxColdDrafts
            // 
            this.checkBoxColdDrafts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxColdDrafts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxColdDrafts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.checkBoxColdDrafts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBoxColdDrafts.Location = new System.Drawing.Point(129, 174);
            this.checkBoxColdDrafts.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxColdDrafts.Name = "checkBoxColdDrafts";
            this.checkBoxColdDrafts.Size = new System.Drawing.Size(44, 21);
            this.checkBoxColdDrafts.TabIndex = 16;
            this.checkBoxColdDrafts.UseVisualStyleBackColor = true;
            // 
            // groupBoxSpotConditions
            // 
            this.groupBoxSpotConditions.Controls.Add(this.comboBoxDirection);
            this.groupBoxSpotConditions.Controls.Add(this.comboBoxHumidity);
            this.groupBoxSpotConditions.Controls.Add(this.comboBoxSunlight);
            this.groupBoxSpotConditions.Controls.Add(this.checkBoxColdDrafts);
            this.groupBoxSpotConditions.Controls.Add(this.label4);
            this.groupBoxSpotConditions.Controls.Add(this.label3);
            this.groupBoxSpotConditions.Controls.Add(this.label2);
            this.groupBoxSpotConditions.Controls.Add(this.label1);
            this.groupBoxSpotConditions.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.groupBoxSpotConditions.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxSpotConditions.Location = new System.Drawing.Point(24, 171);
            this.groupBoxSpotConditions.Name = "groupBoxSpotConditions";
            this.groupBoxSpotConditions.Size = new System.Drawing.Size(300, 214);
            this.groupBoxSpotConditions.TabIndex = 17;
            this.groupBoxSpotConditions.TabStop = false;
            this.groupBoxSpotConditions.Text = "Spot conditions:";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDirection.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxDirection.ForeColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(129, 128);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(73, 29);
            this.comboBoxDirection.TabIndex = 19;
            // 
            // comboBoxHumidity
            // 
            this.comboBoxHumidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxHumidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxHumidity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxHumidity.FormattingEnabled = true;
            this.comboBoxHumidity.Location = new System.Drawing.Point(129, 34);
            this.comboBoxHumidity.Name = "comboBoxHumidity";
            this.comboBoxHumidity.Size = new System.Drawing.Size(141, 29);
            this.comboBoxHumidity.TabIndex = 18;
            // 
            // comboBoxSunlight
            // 
            this.comboBoxSunlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSunlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSunlight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxSunlight.ForeColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxSunlight.FormattingEnabled = true;
            this.comboBoxSunlight.Location = new System.Drawing.Point(129, 82);
            this.comboBoxSunlight.Name = "comboBoxSunlight";
            this.comboBoxSunlight.Size = new System.Drawing.Size(141, 29);
            this.comboBoxSunlight.TabIndex = 17;
            // 
            // MyRoom_EditSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(344, 514);
            this.Controls.Add(this.groupBoxSpotConditions);
            this.Controls.Add(this.labelSpotName);
            this.Controls.Add(this.textBoxSpotName);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(labelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyRoom_EditSpot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantae Pickerus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyRoom_EditSpot_FormClosed);
            this.groupBoxSpotConditions.ResumeLayout(false);
            this.groupBoxSpotConditions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxSpotName;
        private System.Windows.Forms.Label labelSpotName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxColdDrafts;
        private System.Windows.Forms.GroupBox groupBoxSpotConditions;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.ComboBox comboBoxHumidity;
        private System.Windows.Forms.ComboBox comboBoxSunlight;
    }
}
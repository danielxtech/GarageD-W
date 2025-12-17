namespace GarageD_W
{
    partial class ChangeTiresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTiresForm));
            this.lblNumberOfWheels = new System.Windows.Forms.Label();
            this.lblTireSize = new System.Windows.Forms.Label();
            this.lblLastChange = new System.Windows.Forms.Label();
            this.nudNumberOfWheels = new System.Windows.Forms.NumericUpDown();
            this.txtTireSize = new System.Windows.Forms.TextBox();
            this.dtpLastChange = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnchangetire = new System.Windows.Forms.Button();
            this.cmbTireType = new System.Windows.Forms.ComboBox();
            this.lblTireType = new System.Windows.Forms.Label();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfWheels)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfWheels
            // 
            this.lblNumberOfWheels.AutoSize = true;
            this.lblNumberOfWheels.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfWheels.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfWheels.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNumberOfWheels.Location = new System.Drawing.Point(106, 134);
            this.lblNumberOfWheels.Name = "lblNumberOfWheels";
            this.lblNumberOfWheels.Size = new System.Drawing.Size(176, 21);
            this.lblNumberOfWheels.TabIndex = 1;
            this.lblNumberOfWheels.Text = "Number of Wheels:";
            // 
            // lblTireSize
            // 
            this.lblTireSize.AutoSize = true;
            this.lblTireSize.BackColor = System.Drawing.Color.Transparent;
            this.lblTireSize.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTireSize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTireSize.Location = new System.Drawing.Point(106, 207);
            this.lblTireSize.Name = "lblTireSize";
            this.lblTireSize.Size = new System.Drawing.Size(94, 21);
            this.lblTireSize.TabIndex = 3;
            this.lblTireSize.Text = "Tire Size:";
            // 
            // lblLastChange
            // 
            this.lblLastChange.AutoSize = true;
            this.lblLastChange.BackColor = System.Drawing.Color.Transparent;
            this.lblLastChange.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLastChange.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLastChange.Location = new System.Drawing.Point(106, 249);
            this.lblLastChange.Name = "lblLastChange";
            this.lblLastChange.Size = new System.Drawing.Size(169, 21);
            this.lblLastChange.TabIndex = 4;
            this.lblLastChange.Text = "Last Change Date:";
            // 
            // nudNumberOfWheels
            // 
            this.nudNumberOfWheels.Location = new System.Drawing.Point(338, 134);
            this.nudNumberOfWheels.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudNumberOfWheels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfWheels.Name = "nudNumberOfWheels";
            this.nudNumberOfWheels.Size = new System.Drawing.Size(200, 20);
            this.nudNumberOfWheels.TabIndex = 6;
            this.nudNumberOfWheels.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtTireSize
            // 
            this.txtTireSize.Location = new System.Drawing.Point(338, 210);
            this.txtTireSize.Name = "txtTireSize";
            this.txtTireSize.Size = new System.Drawing.Size(200, 20);
            this.txtTireSize.TabIndex = 8;
            // 
            // dtpLastChange
            // 
            this.dtpLastChange.Location = new System.Drawing.Point(338, 250);
            this.dtpLastChange.Name = "dtpLastChange";
            this.dtpLastChange.Size = new System.Drawing.Size(200, 20);
            this.dtpLastChange.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 299);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 31);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnchangetire
            // 
            this.btnchangetire.BackColor = System.Drawing.Color.Lime;
            this.btnchangetire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangetire.Location = new System.Drawing.Point(504, 299);
            this.btnchangetire.Name = "btnchangetire";
            this.btnchangetire.Size = new System.Drawing.Size(123, 31);
            this.btnchangetire.TabIndex = 12;
            this.btnchangetire.Text = "Change Tires";
            this.btnchangetire.UseVisualStyleBackColor = false;
            this.btnchangetire.Click += new System.EventHandler(this.btnchangetire_Click);
            // 
            // cmbTireType
            // 
            this.cmbTireType.FormattingEnabled = true;
            this.cmbTireType.Items.AddRange(new object[] {
            "Michelin: $120",
            "Yokohama: $100",
            "Bridgestone: $110",
            "Goodyear: $90"});
            this.cmbTireType.Location = new System.Drawing.Point(338, 172);
            this.cmbTireType.Name = "cmbTireType";
            this.cmbTireType.Size = new System.Drawing.Size(200, 21);
            this.cmbTireType.TabIndex = 7;
            // 
            // lblTireType
            // 
            this.lblTireType.AutoSize = true;
            this.lblTireType.BackColor = System.Drawing.Color.Transparent;
            this.lblTireType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTireType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTireType.Location = new System.Drawing.Point(106, 172);
            this.lblTireType.Name = "lblTireType";
            this.lblTireType.Size = new System.Drawing.Size(100, 21);
            this.lblTireType.TabIndex = 2;
            this.lblTireType.Text = "Tire Type:";
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Location = new System.Drawing.Point(9, 115);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(35, 13);
            this.lblVehicleInfo.TabIndex = 15;
            this.lblVehicleInfo.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(316, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 43);
            this.label2.TabIndex = 17;
            this.label2.Text = "Store";
            // 
            // ChangeTiresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVehicleInfo);
            this.Controls.Add(this.btnchangetire);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpLastChange);
            this.Controls.Add(this.txtTireSize);
            this.Controls.Add(this.cmbTireType);
            this.Controls.Add(this.nudNumberOfWheels);
            this.Controls.Add(this.lblLastChange);
            this.Controls.Add(this.lblTireSize);
            this.Controls.Add(this.lblTireType);
            this.Controls.Add(this.lblNumberOfWheels);
            this.Location = new System.Drawing.Point(60, 90);
            this.Name = "ChangeTiresForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeTiresForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfWheels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfWheels;
        private System.Windows.Forms.Label lblTireSize;
        private System.Windows.Forms.Label lblLastChange;
        private System.Windows.Forms.NumericUpDown nudNumberOfWheels;
        private System.Windows.Forms.TextBox txtTireSize;
        private System.Windows.Forms.DateTimePicker dtpLastChange;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnchangetire;
        private System.Windows.Forms.ComboBox cmbTireType;
        private System.Windows.Forms.Label lblTireType;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace GarageD_W
{
    partial class OilChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OilChangeForm));
            this.lblOilType = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblLastOilChange = new System.Windows.Forms.Label();
            this.cmbOilType = new System.Windows.Forms.ComboBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.dtpLastOilChange = new System.Windows.Forms.DateTimePicker();
            this.chkOilFilter = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangeOil = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOilType
            // 
            this.lblOilType.AutoSize = true;
            this.lblOilType.BackColor = System.Drawing.Color.Transparent;
            this.lblOilType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblOilType.ForeColor = System.Drawing.Color.Lime;
            this.lblOilType.Location = new System.Drawing.Point(180, 139);
            this.lblOilType.Name = "lblOilType";
            this.lblOilType.Size = new System.Drawing.Size(90, 21);
            this.lblOilType.TabIndex = 1;
            this.lblOilType.Text = "Oil Type:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.BackColor = System.Drawing.Color.Transparent;
            this.lblMileage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMileage.ForeColor = System.Drawing.Color.Lime;
            this.lblMileage.Location = new System.Drawing.Point(180, 187);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(154, 21);
            this.lblMileage.TabIndex = 2;
            this.lblMileage.Text = "Current Mileage:";
            // 
            // lblLastOilChange
            // 
            this.lblLastOilChange.AutoSize = true;
            this.lblLastOilChange.BackColor = System.Drawing.Color.Transparent;
            this.lblLastOilChange.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLastOilChange.ForeColor = System.Drawing.Color.Lime;
            this.lblLastOilChange.Location = new System.Drawing.Point(179, 235);
            this.lblLastOilChange.Name = "lblLastOilChange";
            this.lblLastOilChange.Size = new System.Drawing.Size(155, 21);
            this.lblLastOilChange.TabIndex = 3;
            this.lblLastOilChange.Text = "Last Oil Change:";
            // 
            // cmbOilType
            // 
            this.cmbOilType.FormattingEnabled = true;
            this.cmbOilType.Items.AddRange(new object[] {
            "Synthetic: $75",
            "Semi-Synthetic: $50",
            "Conventional :$35"});
            this.cmbOilType.Location = new System.Drawing.Point(349, 142);
            this.cmbOilType.Name = "cmbOilType";
            this.cmbOilType.Size = new System.Drawing.Size(200, 21);
            this.cmbOilType.TabIndex = 5;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(349, 190);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(200, 20);
            this.txtMileage.TabIndex = 6;
            // 
            // dtpLastOilChange
            // 
            this.dtpLastOilChange.Location = new System.Drawing.Point(349, 236);
            this.dtpLastOilChange.Name = "dtpLastOilChange";
            this.dtpLastOilChange.Size = new System.Drawing.Size(200, 20);
            this.dtpLastOilChange.TabIndex = 7;
            // 
            // chkOilFilter
            // 
            this.chkOilFilter.AutoSize = true;
            this.chkOilFilter.BackColor = System.Drawing.Color.Transparent;
            this.chkOilFilter.Font = new System.Drawing.Font("Noto Serif KR", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOilFilter.ForeColor = System.Drawing.Color.Red;
            this.chkOilFilter.Location = new System.Drawing.Point(183, 278);
            this.chkOilFilter.Name = "chkOilFilter";
            this.chkOilFilter.Size = new System.Drawing.Size(375, 39);
            this.chkOilFilter.TabIndex = 8;
            this.chkOilFilter.Text = "Oil Filter Replacement - $15";
            this.chkOilFilter.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 357);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 33);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangeOil
            // 
            this.btnChangeOil.BackColor = System.Drawing.Color.Lime;
            this.btnChangeOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeOil.Location = new System.Drawing.Point(574, 357);
            this.btnChangeOil.Name = "btnChangeOil";
            this.btnChangeOil.Size = new System.Drawing.Size(105, 33);
            this.btnChangeOil.TabIndex = 11;
            this.btnChangeOil.Text = "Change Oil";
            this.btnChangeOil.UseVisualStyleBackColor = false;
            this.btnChangeOil.Click += new System.EventHandler(this.btnChangeOil_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTitle.Location = new System.Drawing.Point(69, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Oil Change";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(423, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Service";
            // 
            // OilChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnChangeOil);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkOilFilter);
            this.Controls.Add(this.dtpLastOilChange);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.cmbOilType);
            this.Controls.Add(this.lblLastOilChange);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblOilType);
            this.Name = "OilChangeForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOilType;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblLastOilChange;
        private System.Windows.Forms.ComboBox cmbOilType;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.DateTimePicker dtpLastOilChange;
        private System.Windows.Forms.CheckBox chkOilFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangeOil;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}
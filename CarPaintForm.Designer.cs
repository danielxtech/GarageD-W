namespace GarageD_W
{
    partial class CarPaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPaintForm));
            this.lblColor = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.grpServiceType = new System.Windows.Forms.GroupBox();
            this.radFullPaint = new System.Windows.Forms.RadioButton();
            this.radPartialPaint = new System.Windows.Forms.RadioButton();
            this.radTouchUp = new System.Windows.Forms.RadioButton();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.chkClearCoat = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpServiceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.Red;
            this.lblColor.Location = new System.Drawing.Point(12, 172);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(89, 31);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblArea.Location = new System.Drawing.Point(12, 226);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(195, 31);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area to Paint:";
            // 
            // grpServiceType
            // 
            this.grpServiceType.BackColor = System.Drawing.Color.Transparent;
            this.grpServiceType.Controls.Add(this.radFullPaint);
            this.grpServiceType.Controls.Add(this.radPartialPaint);
            this.grpServiceType.Controls.Add(this.radTouchUp);
            this.grpServiceType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpServiceType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpServiceType.Location = new System.Drawing.Point(392, 155);
            this.grpServiceType.Name = "grpServiceType";
            this.grpServiceType.Size = new System.Drawing.Size(212, 144);
            this.grpServiceType.TabIndex = 4;
            this.grpServiceType.TabStop = false;
            this.grpServiceType.Text = "Service Type";
            // 
            // radFullPaint
            // 
            this.radFullPaint.AutoSize = true;
            this.radFullPaint.BackColor = System.Drawing.Color.Transparent;
            this.radFullPaint.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFullPaint.ForeColor = System.Drawing.Color.Transparent;
            this.radFullPaint.Location = new System.Drawing.Point(12, 27);
            this.radFullPaint.Name = "radFullPaint";
            this.radFullPaint.Size = new System.Drawing.Size(181, 21);
            this.radFullPaint.TabIndex = 5;
            this.radFullPaint.TabStop = true;
            this.radFullPaint.Text = "Full Paint Job - $500";
            this.radFullPaint.UseVisualStyleBackColor = false;
            // 
            // radPartialPaint
            // 
            this.radPartialPaint.AutoSize = true;
            this.radPartialPaint.BackColor = System.Drawing.Color.Transparent;
            this.radPartialPaint.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPartialPaint.ForeColor = System.Drawing.Color.Transparent;
            this.radPartialPaint.Location = new System.Drawing.Point(12, 67);
            this.radPartialPaint.Name = "radPartialPaint";
            this.radPartialPaint.Size = new System.Drawing.Size(183, 21);
            this.radPartialPaint.TabIndex = 6;
            this.radPartialPaint.TabStop = true;
            this.radPartialPaint.Text = "Partial Paint -   $200";
            this.radPartialPaint.UseVisualStyleBackColor = false;
            // 
            // radTouchUp
            // 
            this.radTouchUp.AutoSize = true;
            this.radTouchUp.BackColor = System.Drawing.Color.Transparent;
            this.radTouchUp.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTouchUp.ForeColor = System.Drawing.Color.Transparent;
            this.radTouchUp.Location = new System.Drawing.Point(12, 104);
            this.radTouchUp.Name = "radTouchUp";
            this.radTouchUp.Size = new System.Drawing.Size(176, 21);
            this.radTouchUp.TabIndex = 7;
            this.radTouchUp.TabStop = true;
            this.radTouchUp.Text = "Touch Up -         $50";
            this.radTouchUp.UseVisualStyleBackColor = false;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black",
            "White",
            "Silver",
            "Gray",
            "Green",
            "Yellow"});
            this.cmbColor.Location = new System.Drawing.Point(227, 172);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(142, 21);
            this.cmbColor.TabIndex = 8;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(227, 233);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(142, 20);
            this.txtArea.TabIndex = 9;
            // 
            // chkClearCoat
            // 
            this.chkClearCoat.AutoSize = true;
            this.chkClearCoat.BackColor = System.Drawing.Color.Transparent;
            this.chkClearCoat.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClearCoat.ForeColor = System.Drawing.Color.Lime;
            this.chkClearCoat.Location = new System.Drawing.Point(12, 277);
            this.chkClearCoat.Name = "chkClearCoat";
            this.chkClearCoat.Size = new System.Drawing.Size(374, 33);
            this.chkClearCoat.TabIndex = 10;
            this.chkClearCoat.Text = "Clear Coat Protection - $100";
            this.chkClearCoat.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(12, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 31);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.Color.Lime;
            this.btnPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.ForeColor = System.Drawing.Color.Black;
            this.btnPaint.Location = new System.Drawing.Point(477, 362);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(127, 31);
            this.btnPaint.TabIndex = 13;
            this.btnPaint.Text = "Paint Car";
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Paint";
            // 
            // CarPaintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkClearCoat);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.grpServiceType);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblColor);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Name = "CarPaintForm";
            this.Text = "CarPaintForm";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.grpServiceType.ResumeLayout(false);
            this.grpServiceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.GroupBox grpServiceType;
        private System.Windows.Forms.RadioButton radFullPaint;
        private System.Windows.Forms.RadioButton radPartialPaint;
        private System.Windows.Forms.RadioButton radTouchUp;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.CheckBox chkClearCoat;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
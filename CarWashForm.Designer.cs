namespace GarageD_W
{
    partial class CarWashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarWashForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPriceList = new System.Windows.Forms.Label();
            this.chkStandard = new System.Windows.Forms.CheckBox();
            this.chkExterior = new System.Windows.Forms.CheckBox();
            this.chkInterior = new System.Windows.Forms.CheckBox();
            this.chkFullDetailing = new System.Windows.Forms.CheckBox();
            this.chkWaxPolish = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnWash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTitle.Location = new System.Drawing.Point(167, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car";
            // 
            // lblPriceList
            // 
            this.lblPriceList.AutoSize = true;
            this.lblPriceList.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceList.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceList.ForeColor = System.Drawing.Color.Red;
            this.lblPriceList.Location = new System.Drawing.Point(10, 115);
            this.lblPriceList.Name = "lblPriceList";
            this.lblPriceList.Size = new System.Drawing.Size(198, 31);
            this.lblPriceList.TabIndex = 1;
            this.lblPriceList.Text = "Service Prices:";
            // 
            // chkStandard
            // 
            this.chkStandard.AutoSize = true;
            this.chkStandard.BackColor = System.Drawing.Color.Transparent;
            this.chkStandard.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic);
            this.chkStandard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkStandard.Location = new System.Drawing.Point(175, 149);
            this.chkStandard.Name = "chkStandard";
            this.chkStandard.Size = new System.Drawing.Size(364, 40);
            this.chkStandard.TabIndex = 3;
            this.chkStandard.Text = "Standard Wash - $25";
            this.chkStandard.UseVisualStyleBackColor = false;
            // 
            // chkExterior
            // 
            this.chkExterior.AutoSize = true;
            this.chkExterior.BackColor = System.Drawing.Color.Transparent;
            this.chkExterior.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic);
            this.chkExterior.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkExterior.Location = new System.Drawing.Point(175, 195);
            this.chkExterior.Name = "chkExterior";
            this.chkExterior.Size = new System.Drawing.Size(362, 40);
            this.chkExterior.TabIndex = 4;
            this.chkExterior.Text = "Exterior Only -    $15";
            this.chkExterior.UseVisualStyleBackColor = false;
            // 
            // chkInterior
            // 
            this.chkInterior.AutoSize = true;
            this.chkInterior.BackColor = System.Drawing.Color.Transparent;
            this.chkInterior.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic);
            this.chkInterior.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkInterior.Location = new System.Drawing.Point(175, 241);
            this.chkInterior.Name = "chkInterior";
            this.chkInterior.Size = new System.Drawing.Size(355, 40);
            this.chkInterior.TabIndex = 5;
            this.chkInterior.Text = "Interior Only -    $20";
            this.chkInterior.UseVisualStyleBackColor = false;
            // 
            // chkFullDetailing
            // 
            this.chkFullDetailing.AutoSize = true;
            this.chkFullDetailing.BackColor = System.Drawing.Color.Transparent;
            this.chkFullDetailing.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic);
            this.chkFullDetailing.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkFullDetailing.Location = new System.Drawing.Point(175, 287);
            this.chkFullDetailing.Name = "chkFullDetailing";
            this.chkFullDetailing.Size = new System.Drawing.Size(354, 40);
            this.chkFullDetailing.TabIndex = 6;
            this.chkFullDetailing.Text = "Full Detailing -   $80";
            this.chkFullDetailing.UseVisualStyleBackColor = false;
            // 
            // chkWaxPolish
            // 
            this.chkWaxPolish.AutoSize = true;
            this.chkWaxPolish.BackColor = System.Drawing.Color.Transparent;
            this.chkWaxPolish.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWaxPolish.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkWaxPolish.Location = new System.Drawing.Point(175, 333);
            this.chkWaxPolish.Name = "chkWaxPolish";
            this.chkWaxPolish.Size = new System.Drawing.Size(350, 40);
            this.chkWaxPolish.TabIndex = 7;
            this.chkWaxPolish.Text = "Wax & Polish -       $40";
            this.chkWaxPolish.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(16, 391);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 26);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnWash
            // 
            this.btnWash.BackColor = System.Drawing.Color.Lime;
            this.btnWash.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWash.Location = new System.Drawing.Point(519, 391);
            this.btnWash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWash.Name = "btnWash";
            this.btnWash.Size = new System.Drawing.Size(105, 28);
            this.btnWash.TabIndex = 11;
            this.btnWash.Text = "Wash Car";
            this.btnWash.UseVisualStyleBackColor = false;
            this.btnWash.Click += new System.EventHandler(this.btnWash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wash";
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnWash);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkWaxPolish);
            this.Controls.Add(this.chkFullDetailing);
            this.Controls.Add(this.chkInterior);
            this.Controls.Add(this.chkExterior);
            this.Controls.Add(this.chkStandard);
            this.Controls.Add(this.lblPriceList);
            this.Name = "CarWashForm";
            this.Text = "CarWashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPriceList;
        private System.Windows.Forms.CheckBox chkStandard;
        private System.Windows.Forms.CheckBox chkExterior;
        private System.Windows.Forms.CheckBox chkInterior;
        private System.Windows.Forms.CheckBox chkFullDetailing;
        private System.Windows.Forms.CheckBox chkWaxPolish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWash;
        private System.Windows.Forms.Label label1;
    }
}
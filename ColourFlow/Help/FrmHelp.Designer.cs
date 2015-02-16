namespace ColourFlow
{
    partial class FrmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.TopPannel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblHTitle = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.lblHClose = new System.Windows.Forms.Label();
            this.TopPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPannel
            // 
            this.TopPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPannel.Controls.Add(this.lblTitle);
            this.TopPannel.Controls.Add(this.pbLogo);
            this.TopPannel.Controls.Add(this.lblClose);
            this.TopPannel.Location = new System.Drawing.Point(0, 1);
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.Size = new System.Drawing.Size(583, 129);
            this.TopPannel.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(382, 97);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Help";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Silver;
            this.pbLogo.Image = global::ColourFlow.Properties.Resources.Logo_DLL1;
            this.pbLogo.Location = new System.Drawing.Point(81, 14);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(352, 80);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(464, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(120, 17);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "Return to Menu (<)";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblHTitle
            // 
            this.lblHTitle.AutoSize = true;
            this.lblHTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTitle.ForeColor = System.Drawing.Color.White;
            this.lblHTitle.Location = new System.Drawing.Point(218, 133);
            this.lblHTitle.Name = "lblHTitle";
            this.lblHTitle.Size = new System.Drawing.Size(65, 32);
            this.lblHTitle.TabIndex = 6;
            this.lblHTitle.Text = "Help";
            // 
            // txtHelp
            // 
            this.txtHelp.BackColor = System.Drawing.Color.Gray;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.CausesValidation = false;
            this.txtHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.ForeColor = System.Drawing.Color.White;
            this.txtHelp.Location = new System.Drawing.Point(12, 168);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHelp.Size = new System.Drawing.Size(560, 266);
            this.txtHelp.TabIndex = 7;
            // 
            // lblHClose
            // 
            this.lblHClose.AutoSize = true;
            this.lblHClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHClose.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHClose.ForeColor = System.Drawing.Color.White;
            this.lblHClose.Location = new System.Drawing.Point(252, 437);
            this.lblHClose.Name = "lblHClose";
            this.lblHClose.Size = new System.Drawing.Size(67, 21);
            this.lblHClose.TabIndex = 6;
            this.lblHClose.Text = "Close (x)";
            this.lblHClose.Click += new System.EventHandler(this.lblHClose_Click);
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(584, 467);
            this.Controls.Add(this.lblHClose);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.lblHTitle);
            this.Controls.Add(this.TopPannel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColourFlow : Help";
            this.TopPannel.ResumeLayout(false);
            this.TopPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPannel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblHClose;
        public System.Windows.Forms.Label lblHTitle;
        public System.Windows.Forms.TextBox txtHelp;
    }
}
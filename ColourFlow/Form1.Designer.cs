namespace ColourFlow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPannel = new System.Windows.Forms.Panel();
            this.BottomPannel = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblPalette = new System.Windows.Forms.Label();
            this.lblHS = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.chkBoxSkin = new System.Windows.Forms.CheckBox();
            this.Pb4 = new System.Windows.Forms.PictureBox();
            this.Pb3 = new System.Windows.Forms.PictureBox();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.TopPannel.SuspendLayout();
            this.BottomPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPannel
            // 
            this.TopPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPannel.Controls.Add(this.pbLogo);
            this.TopPannel.Location = new System.Drawing.Point(0, 0);
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.Size = new System.Drawing.Size(800, 130);
            this.TopPannel.TabIndex = 0;
            // 
            // BottomPannel
            // 
            this.BottomPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPannel.Controls.Add(this.lblHelp);
            this.BottomPannel.Controls.Add(this.lblAuthor);
            this.BottomPannel.Location = new System.Drawing.Point(0, 570);
            this.BottomPannel.Name = "BottomPannel";
            this.BottomPannel.Size = new System.Drawing.Size(800, 100);
            this.BottomPannel.TabIndex = 1;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(749, 7);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(48, 15);
            this.lblHelp.TabIndex = 1;
            this.lblHelp.Text = "Help (?)";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(12, 7);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(96, 15);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Ewan McCartney";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(354, 243);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(51, 25);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            this.lblStart.MouseEnter += new System.EventHandler(this.lblStart_MEnter);
            this.lblStart.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // lblPalette
            // 
            this.lblPalette.AutoSize = true;
            this.lblPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPalette.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalette.ForeColor = System.Drawing.Color.White;
            this.lblPalette.Location = new System.Drawing.Point(354, 278);
            this.lblPalette.Name = "lblPalette";
            this.lblPalette.Size = new System.Drawing.Size(147, 25);
            this.lblPalette.TabIndex = 3;
            this.lblPalette.Text = "Palette Creation";
            this.lblPalette.Click += new System.EventHandler(this.lblPalette_Click);
            this.lblPalette.MouseEnter += new System.EventHandler(this.lblPalette_MEnter);
            this.lblPalette.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHS.ForeColor = System.Drawing.Color.White;
            this.lblHS.Location = new System.Drawing.Point(354, 313);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(112, 25);
            this.lblHS.TabIndex = 4;
            this.lblHS.Text = "High Scores";
            this.lblHS.Click += new System.EventHandler(this.lblHS_Click);
            this.lblHS.MouseEnter += new System.EventHandler(this.lblHS_MEnter);
            this.lblHS.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(354, 348);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(42, 25);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // chkBoxSkin
            // 
            this.chkBoxSkin.AutoSize = true;
            this.chkBoxSkin.Checked = true;
            this.chkBoxSkin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxSkin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSkin.ForeColor = System.Drawing.Color.White;
            this.chkBoxSkin.Location = new System.Drawing.Point(675, 543);
            this.chkBoxSkin.Name = "chkBoxSkin";
            this.chkBoxSkin.Size = new System.Drawing.Size(113, 21);
            this.chkBoxSkin.TabIndex = 10;
            this.chkBoxSkin.Text = "Use Dark Skin?";
            this.chkBoxSkin.UseVisualStyleBackColor = true;
            this.chkBoxSkin.CheckedChanged += new System.EventHandler(this.chkBoxSkin_CheckedChanged);
            // 
            // Pb4
            // 
            this.Pb4.BackColor = System.Drawing.Color.White;
            this.Pb4.Location = new System.Drawing.Point(332, 357);
            this.Pb4.Name = "Pb4";
            this.Pb4.Size = new System.Drawing.Size(16, 16);
            this.Pb4.TabIndex = 9;
            this.Pb4.TabStop = false;
            this.Pb4.Visible = false;
            // 
            // Pb3
            // 
            this.Pb3.BackColor = System.Drawing.Color.White;
            this.Pb3.Location = new System.Drawing.Point(332, 322);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(16, 16);
            this.Pb3.TabIndex = 8;
            this.Pb3.TabStop = false;
            this.Pb3.Visible = false;
            // 
            // Pb2
            // 
            this.Pb2.BackColor = System.Drawing.Color.White;
            this.Pb2.Location = new System.Drawing.Point(332, 287);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(16, 16);
            this.Pb2.TabIndex = 7;
            this.Pb2.TabStop = false;
            this.Pb2.Visible = false;
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.White;
            this.Pb1.Location = new System.Drawing.Point(332, 252);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(16, 16);
            this.Pb1.TabIndex = 6;
            this.Pb1.TabStop = false;
            this.Pb1.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ColourFlow.Properties.Resources.Logo__Dark;
            this.pbLogo.Location = new System.Drawing.Point(201, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(355, 96);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.chkBoxSkin);
            this.Controls.Add(this.Pb4);
            this.Controls.Add(this.Pb3);
            this.Controls.Add(this.Pb2);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHS);
            this.Controls.Add(this.lblPalette);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.BottomPannel);
            this.Controls.Add(this.TopPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColourFlow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPannel.ResumeLayout(false);
            this.BottomPannel.ResumeLayout(false);
            this.BottomPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPannel;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel BottomPannel;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblPalette;
        private System.Windows.Forms.Label lblHS;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.PictureBox Pb4;
        internal System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.CheckBox chkBoxSkin;
    }
}


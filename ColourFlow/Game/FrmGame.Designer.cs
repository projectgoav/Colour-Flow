namespace ColourFlow
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.TopPannel = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.BottomPannel = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.DPanel = new System.Windows.Forms.Panel();
            this.Draw = new System.Windows.Forms.Timer(this.components);
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.PB4 = new System.Windows.Forms.PictureBox();
            this.PB5 = new System.Windows.Forms.PictureBox();
            this.PB6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.BottomPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB6)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPannel
            // 
            this.TopPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPannel.Controls.Add(this.lblClose);
            this.TopPannel.Controls.Add(this.pbLogo);
            this.TopPannel.Location = new System.Drawing.Point(0, 0);
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.Size = new System.Drawing.Size(800, 93);
            this.TopPannel.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(678, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(120, 17);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "Return to Menu (<)";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ColourFlow.Properties.Resources.Logo__Dark;
            this.pbLogo.Location = new System.Drawing.Point(227, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(373, 80);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.ForeColor = System.Drawing.Color.White;
            this.lblSteps.Location = new System.Drawing.Point(38, 99);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(109, 25);
            this.lblSteps.TabIndex = 3;
            this.lblSteps.Text = "Steps 00/00";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(626, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Game : [Mode]";
            // 
            // BottomPannel
            // 
            this.BottomPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPannel.Controls.Add(this.lblHelp);
            this.BottomPannel.Controls.Add(this.lblAuthor);
            this.BottomPannel.Location = new System.Drawing.Point(0, 570);
            this.BottomPannel.Name = "BottomPannel";
            this.BottomPannel.Size = new System.Drawing.Size(800, 100);
            this.BottomPannel.TabIndex = 2;
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
            // DPanel
            // 
            this.DPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DPanel.CausesValidation = false;
            this.DPanel.Location = new System.Drawing.Point(205, 158);
            this.DPanel.Name = "DPanel";
            this.DPanel.Size = new System.Drawing.Size(400, 400);
            this.DPanel.TabIndex = 3;
            // 
            // Draw
            // 
            this.Draw.Interval = 50;
            this.Draw.Tick += new System.EventHandler(this.Draw_Tick);
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.Color.White;
            this.PB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB1.Location = new System.Drawing.Point(99, 238);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(48, 48);
            this.PB1.TabIndex = 4;
            this.PB1.TabStop = false;
            this.PB1.Click += new System.EventHandler(this.PB1_Click);
            // 
            // PB2
            // 
            this.PB2.BackColor = System.Drawing.Color.Red;
            this.PB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB2.Location = new System.Drawing.Point(99, 333);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(48, 48);
            this.PB2.TabIndex = 5;
            this.PB2.TabStop = false;
            this.PB2.Click += new System.EventHandler(this.PB2_Click);
            // 
            // PB3
            // 
            this.PB3.BackColor = System.Drawing.Color.Yellow;
            this.PB3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB3.Location = new System.Drawing.Point(99, 437);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(48, 48);
            this.PB3.TabIndex = 6;
            this.PB3.TabStop = false;
            this.PB3.Click += new System.EventHandler(this.PB3_Click);
            // 
            // PB4
            // 
            this.PB4.BackColor = System.Drawing.Color.Orange;
            this.PB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB4.Location = new System.Drawing.Point(672, 238);
            this.PB4.Name = "PB4";
            this.PB4.Size = new System.Drawing.Size(48, 48);
            this.PB4.TabIndex = 7;
            this.PB4.TabStop = false;
            this.PB4.Click += new System.EventHandler(this.PB4_Click);
            // 
            // PB5
            // 
            this.PB5.BackColor = System.Drawing.Color.Blue;
            this.PB5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB5.Location = new System.Drawing.Point(672, 333);
            this.PB5.Name = "PB5";
            this.PB5.Size = new System.Drawing.Size(48, 48);
            this.PB5.TabIndex = 8;
            this.PB5.TabStop = false;
            this.PB5.Click += new System.EventHandler(this.PB5_Click);
            // 
            // PB6
            // 
            this.PB6.BackColor = System.Drawing.Color.Green;
            this.PB6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB6.Location = new System.Drawing.Point(672, 437);
            this.PB6.Name = "PB6";
            this.PB6.Size = new System.Drawing.Size(48, 48);
            this.PB6.TabIndex = 9;
            this.PB6.TabStop = false;
            this.PB6.Click += new System.EventHandler(this.PB6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Click any of the 6 large squares to change the colour of the grid!";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB6);
            this.Controls.Add(this.PB5);
            this.Controls.Add(this.PB4);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.DPanel);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BottomPannel);
            this.Controls.Add(this.TopPannel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColourFlow : Playing...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.TopPannel.ResumeLayout(false);
            this.TopPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.BottomPannel.ResumeLayout(false);
            this.BottomPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPannel;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel BottomPannel;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblClose;
        public System.Windows.Forms.Panel DPanel;
        private System.Windows.Forms.Timer Draw;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.PictureBox PB4;
        private System.Windows.Forms.PictureBox PB5;
        private System.Windows.Forms.PictureBox PB6;
        private System.Windows.Forms.Label label1;
    }
}
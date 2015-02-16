namespace ColourFlow
{
    partial class FrmPalette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPalette));
            this.TopPannel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.BottomPannel = new System.Windows.Forms.Panel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lstPalette = new System.Windows.Forms.ListBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.PBox = new System.Windows.Forms.GroupBox();
            this.PB6 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.lblDefault = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblCC6 = new System.Windows.Forms.Label();
            this.lblCC5 = new System.Windows.Forms.Label();
            this.lblCC4 = new System.Windows.Forms.Label();
            this.lblCC3 = new System.Windows.Forms.Label();
            this.lblCC2 = new System.Windows.Forms.Label();
            this.lblCC1 = new System.Windows.Forms.Label();
            this.PBC6 = new System.Windows.Forms.PictureBox();
            this.PBC5 = new System.Windows.Forms.PictureBox();
            this.PBC4 = new System.Windows.Forms.PictureBox();
            this.PBC3 = new System.Windows.Forms.PictureBox();
            this.PBC2 = new System.Windows.Forms.PictureBox();
            this.PBC1 = new System.Windows.Forms.PictureBox();
            this.ColourDialog = new System.Windows.Forms.ColorDialog();
            this.TopPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.BottomPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.PBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPannel
            // 
            this.TopPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPannel.Controls.Add(this.lblTitle);
            this.TopPannel.Controls.Add(this.lblClose);
            this.TopPannel.Controls.Add(this.pbLogo);
            this.TopPannel.Location = new System.Drawing.Point(0, 0);
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.Size = new System.Drawing.Size(800, 130);
            this.TopPannel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(427, 94);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Palette Creation";
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
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "Return to Menu (<)";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ColourFlow.Properties.Resources.Logo__Dark;
            this.pbLogo.Location = new System.Drawing.Point(201, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(373, 80);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
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
            // lstPalette
            // 
            this.lstPalette.BackColor = System.Drawing.Color.Black;
            this.lstPalette.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPalette.ForeColor = System.Drawing.Color.White;
            this.lstPalette.FormattingEnabled = true;
            this.lstPalette.Location = new System.Drawing.Point(26, 170);
            this.lstPalette.Name = "lstPalette";
            this.lstPalette.Size = new System.Drawing.Size(190, 394);
            this.lstPalette.TabIndex = 3;
            this.lstPalette.SelectedIndexChanged += new System.EventHandler(this.lstPalette_SelectedIndexChanged);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.White;
            this.lblNew.Location = new System.Drawing.Point(42, 142);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(173, 25);
            this.lblNew.TabIndex = 4;
            this.lblNew.Text = "Create New Palette";
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            this.lblNew.MouseEnter += new System.EventHandler(this.lblNew_MouseEnter);
            this.lblNew.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.Color.White;
            this.Pb1.Location = new System.Drawing.Point(27, 148);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(16, 16);
            this.Pb1.TabIndex = 6;
            this.Pb1.TabStop = false;
            this.Pb1.Visible = false;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.White;
            this.lblDelete.Location = new System.Drawing.Point(358, 243);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(66, 25);
            this.lblDelete.TabIndex = 8;
            this.lblDelete.Text = "Delete";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            this.lblDelete.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblDelete.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.Location = new System.Drawing.Point(342, 249);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(16, 16);
            this.pb3.TabIndex = 9;
            this.pb3.TabStop = false;
            this.pb3.Visible = false;
            this.pb3.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // PBox
            // 
            this.PBox.Controls.Add(this.PB6);
            this.PBox.Controls.Add(this.pb3);
            this.PBox.Controls.Add(this.lblDelete);
            this.PBox.Controls.Add(this.pb4);
            this.PBox.Controls.Add(this.lblDefault);
            this.PBox.Controls.Add(this.lblSave);
            this.PBox.Controls.Add(this.lblCC6);
            this.PBox.Controls.Add(this.lblCC5);
            this.PBox.Controls.Add(this.lblCC4);
            this.PBox.Controls.Add(this.lblCC3);
            this.PBox.Controls.Add(this.lblCC2);
            this.PBox.Controls.Add(this.lblCC1);
            this.PBox.Controls.Add(this.PBC6);
            this.PBox.Controls.Add(this.PBC5);
            this.PBox.Controls.Add(this.PBC4);
            this.PBox.Controls.Add(this.PBC3);
            this.PBox.Controls.Add(this.PBC2);
            this.PBox.Controls.Add(this.PBC1);
            this.PBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBox.ForeColor = System.Drawing.Color.White;
            this.PBox.Location = new System.Drawing.Point(254, 147);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(534, 417);
            this.PBox.TabIndex = 10;
            this.PBox.TabStop = false;
            this.PBox.Text = "[Name]";
            // 
            // PB6
            // 
            this.PB6.BackColor = System.Drawing.Color.White;
            this.PB6.Location = new System.Drawing.Point(342, 159);
            this.PB6.Name = "PB6";
            this.PB6.Size = new System.Drawing.Size(16, 16);
            this.PB6.TabIndex = 16;
            this.PB6.TabStop = false;
            this.PB6.Visible = false;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.White;
            this.pb4.Location = new System.Drawing.Point(342, 203);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(16, 16);
            this.pb4.TabIndex = 11;
            this.pb4.TabStop = false;
            this.pb4.Visible = false;
            // 
            // lblDefault
            // 
            this.lblDefault.AutoSize = true;
            this.lblDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDefault.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDefault.Location = new System.Drawing.Point(358, 153);
            this.lblDefault.Name = "lblDefault";
            this.lblDefault.Size = new System.Drawing.Size(141, 25);
            this.lblDefault.TabIndex = 14;
            this.lblDefault.Text = "Use this Palette";
            this.lblDefault.Click += new System.EventHandler(this.lblDefault_Click);
            this.lblDefault.MouseEnter += new System.EventHandler(this.lblDefault_MouseEnter);
            this.lblDefault.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSave.Location = new System.Drawing.Point(358, 196);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(51, 25);
            this.lblSave.TabIndex = 12;
            this.lblSave.Text = "Save";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            this.lblSave.MouseEnter += new System.EventHandler(this.lblSave_MouseEnter);
            this.lblSave.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // lblCC6
            // 
            this.lblCC6.AutoSize = true;
            this.lblCC6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCC6.Location = new System.Drawing.Point(100, 360);
            this.lblCC6.Name = "lblCC6";
            this.lblCC6.Size = new System.Drawing.Size(63, 21);
            this.lblCC6.TabIndex = 11;
            this.lblCC6.Text = "Change";
            this.lblCC6.Click += new System.EventHandler(this.lblCC6_Click);
            // 
            // lblCC5
            // 
            this.lblCC5.AutoSize = true;
            this.lblCC5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCC5.Location = new System.Drawing.Point(100, 303);
            this.lblCC5.Name = "lblCC5";
            this.lblCC5.Size = new System.Drawing.Size(63, 21);
            this.lblCC5.TabIndex = 10;
            this.lblCC5.Text = "Change";
            this.lblCC5.Click += new System.EventHandler(this.lblCC5_Click);
            // 
            // lblCC4
            // 
            this.lblCC4.AutoSize = true;
            this.lblCC4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCC4.Location = new System.Drawing.Point(100, 249);
            this.lblCC4.Name = "lblCC4";
            this.lblCC4.Size = new System.Drawing.Size(63, 21);
            this.lblCC4.TabIndex = 9;
            this.lblCC4.Text = "Change";
            this.lblCC4.Click += new System.EventHandler(this.lblCC4_Click);
            // 
            // lblCC3
            // 
            this.lblCC3.AutoSize = true;
            this.lblCC3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCC3.Location = new System.Drawing.Point(100, 196);
            this.lblCC3.Name = "lblCC3";
            this.lblCC3.Size = new System.Drawing.Size(63, 21);
            this.lblCC3.TabIndex = 8;
            this.lblCC3.Text = "Change";
            this.lblCC3.Click += new System.EventHandler(this.lblCC3_Click);
            // 
            // lblCC2
            // 
            this.lblCC2.AutoSize = true;
            this.lblCC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCC2.Location = new System.Drawing.Point(100, 142);
            this.lblCC2.Name = "lblCC2";
            this.lblCC2.Size = new System.Drawing.Size(63, 21);
            this.lblCC2.TabIndex = 7;
            this.lblCC2.Text = "Change";
            this.lblCC2.Click += new System.EventHandler(this.lblCC2_Click);
            // 
            // lblCC1
            // 
            this.lblCC1.AutoSize = true;
            this.lblCC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCC1.Location = new System.Drawing.Point(100, 88);
            this.lblCC1.Name = "lblCC1";
            this.lblCC1.Size = new System.Drawing.Size(63, 21);
            this.lblCC1.TabIndex = 6;
            this.lblCC1.Text = "Change";
            this.lblCC1.Click += new System.EventHandler(this.lblCC1_Click);
            // 
            // PBC6
            // 
            this.PBC6.BackColor = System.Drawing.Color.White;
            this.PBC6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBC6.Location = new System.Drawing.Point(31, 345);
            this.PBC6.Name = "PBC6";
            this.PBC6.Size = new System.Drawing.Size(48, 48);
            this.PBC6.TabIndex = 5;
            this.PBC6.TabStop = false;
            // 
            // PBC5
            // 
            this.PBC5.BackColor = System.Drawing.Color.White;
            this.PBC5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBC5.Location = new System.Drawing.Point(31, 291);
            this.PBC5.Name = "PBC5";
            this.PBC5.Size = new System.Drawing.Size(48, 48);
            this.PBC5.TabIndex = 4;
            this.PBC5.TabStop = false;
            // 
            // PBC4
            // 
            this.PBC4.BackColor = System.Drawing.Color.White;
            this.PBC4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBC4.Location = new System.Drawing.Point(31, 237);
            this.PBC4.Name = "PBC4";
            this.PBC4.Size = new System.Drawing.Size(48, 48);
            this.PBC4.TabIndex = 3;
            this.PBC4.TabStop = false;
            // 
            // PBC3
            // 
            this.PBC3.BackColor = System.Drawing.Color.White;
            this.PBC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBC3.Location = new System.Drawing.Point(31, 183);
            this.PBC3.Name = "PBC3";
            this.PBC3.Size = new System.Drawing.Size(48, 48);
            this.PBC3.TabIndex = 2;
            this.PBC3.TabStop = false;
            // 
            // PBC2
            // 
            this.PBC2.BackColor = System.Drawing.Color.White;
            this.PBC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBC2.Location = new System.Drawing.Point(31, 129);
            this.PBC2.Name = "PBC2";
            this.PBC2.Size = new System.Drawing.Size(48, 48);
            this.PBC2.TabIndex = 1;
            this.PBC2.TabStop = false;
            // 
            // PBC1
            // 
            this.PBC1.BackColor = System.Drawing.Color.White;
            this.PBC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBC1.Location = new System.Drawing.Point(31, 75);
            this.PBC1.Name = "PBC1";
            this.PBC1.Size = new System.Drawing.Size(48, 48);
            this.PBC1.TabIndex = 0;
            this.PBC1.TabStop = false;
            // 
            // ColourDialog
            // 
            this.ColourDialog.AnyColor = true;
            this.ColourDialog.FullOpen = true;
            this.ColourDialog.ShowHelp = true;
            this.ColourDialog.SolidColorOnly = true;
            // 
            // FrmPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lstPalette);
            this.Controls.Add(this.BottomPannel);
            this.Controls.Add(this.TopPannel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPalette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColourFlow : Palette Creation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPalette_FormClosing);
            this.Load += new System.EventHandler(this.FrmPalette_Load);
            this.TopPannel.ResumeLayout(false);
            this.TopPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.BottomPannel.ResumeLayout(false);
            this.BottomPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.PBox.ResumeLayout(false);
            this.PBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBC1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPannel;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel BottomPannel;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstPalette;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.GroupBox PBox;
        private System.Windows.Forms.PictureBox PBC6;
        private System.Windows.Forms.PictureBox PBC5;
        private System.Windows.Forms.PictureBox PBC4;
        private System.Windows.Forms.PictureBox PBC3;
        private System.Windows.Forms.PictureBox PBC2;
        private System.Windows.Forms.PictureBox PBC1;
        private System.Windows.Forms.Label lblCC1;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblCC6;
        private System.Windows.Forms.Label lblCC5;
        private System.Windows.Forms.Label lblCC4;
        private System.Windows.Forms.Label lblCC3;
        private System.Windows.Forms.Label lblCC2;
        private System.Windows.Forms.PictureBox PB6;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Label lblDefault;
        private System.Windows.Forms.ColorDialog ColourDialog;
    }
}
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMode))
        Me.TopPannel = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.BottomPannel = New System.Windows.Forms.Panel()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.ChallengePannel = New System.Windows.Forms.Panel()
        Me.pb4 = New System.Windows.Forms.PictureBox()
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.lblVL = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.pbc = New System.Windows.Forms.PictureBox()
        Me.pbF = New System.Windows.Forms.PictureBox()
        Me.PBChallenge = New System.Windows.Forms.PictureBox()
        Me.pbFree = New System.Windows.Forms.PictureBox()
        Me.TopPannel.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomPannel.SuspendLayout()
        Me.ChallengePannel.SuspendLayout()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBChallenge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPannel
        '
        Me.TopPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TopPannel.Controls.Add(Me.lblTitle)
        Me.TopPannel.Controls.Add(Me.pbLogo)
        Me.TopPannel.Controls.Add(Me.lblClose)
        Me.TopPannel.Location = New System.Drawing.Point(-7, -3)
        Me.TopPannel.Name = "TopPannel"
        Me.TopPannel.Size = New System.Drawing.Size(521, 129)
        Me.TopPannel.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(325, 97)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(129, 25)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Choose Mode"
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Silver
        Me.pbLogo.Image = Global.Flow.My.Resources.Resources.Logo_DLL1
        Me.pbLogo.Location = New System.Drawing.Point(81, 17)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(352, 80)
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(399, 1)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(120, 17)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "Return to Menu (<)"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(207, 158)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(102, 25)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Free Mode"
        '
        'BottomPannel
        '
        Me.BottomPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomPannel.Controls.Add(Me.lblHelp)
        Me.BottomPannel.Controls.Add(Me.lblAuthor)
        Me.BottomPannel.Location = New System.Drawing.Point(-104, 390)
        Me.BottomPannel.Name = "BottomPannel"
        Me.BottomPannel.Size = New System.Drawing.Size(619, 100)
        Me.BottomPannel.TabIndex = 5
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHelp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.White
        Me.lblHelp.Location = New System.Drawing.Point(554, 0)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(48, 15)
        Me.lblHelp.TabIndex = 1
        Me.lblHelp.Text = "Help (?)"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.White
        Me.lblAuthor.Location = New System.Drawing.Point(116, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(96, 15)
        Me.lblAuthor.TabIndex = 0
        Me.lblAuthor.Text = "Ewan McCartney"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(181, 195)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(151, 25)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Challenge Mode"
        '
        'ChallengePannel
        '
        Me.ChallengePannel.Controls.Add(Me.pb4)
        Me.ChallengePannel.Controls.Add(Me.pb3)
        Me.ChallengePannel.Controls.Add(Me.pb2)
        Me.ChallengePannel.Controls.Add(Me.pb1)
        Me.ChallengePannel.Controls.Add(Me.lblVL)
        Me.ChallengePannel.Controls.Add(Me.lblL)
        Me.ChallengePannel.Controls.Add(Me.lblM)
        Me.ChallengePannel.Controls.Add(Me.lblE)
        Me.ChallengePannel.Location = New System.Drawing.Point(40, 237)
        Me.ChallengePannel.Name = "ChallengePannel"
        Me.ChallengePannel.Size = New System.Drawing.Size(430, 100)
        Me.ChallengePannel.TabIndex = 7
        Me.ChallengePannel.Visible = False
        '
        'pb4
        '
        Me.pb4.BackColor = System.Drawing.Color.White
        Me.pb4.Location = New System.Drawing.Point(308, 40)
        Me.pb4.Name = "pb4"
        Me.pb4.Size = New System.Drawing.Size(16, 16)
        Me.pb4.TabIndex = 17
        Me.pb4.TabStop = False
        Me.pb4.Visible = False
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.White
        Me.pb3.Location = New System.Drawing.Point(215, 40)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(16, 16)
        Me.pb3.TabIndex = 16
        Me.pb3.TabStop = False
        Me.pb3.Visible = False
        '
        'pb2
        '
        Me.pb2.BackColor = System.Drawing.Color.White
        Me.pb2.Location = New System.Drawing.Point(96, 40)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(16, 16)
        Me.pb2.TabIndex = 15
        Me.pb2.TabStop = False
        Me.pb2.Visible = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.White
        Me.pb1.Location = New System.Drawing.Point(5, 40)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(16, 16)
        Me.pb1.TabIndex = 10
        Me.pb1.TabStop = False
        Me.pb1.Visible = False
        '
        'lblVL
        '
        Me.lblVL.AutoSize = True
        Me.lblVL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblVL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVL.ForeColor = System.Drawing.Color.White
        Me.lblVL.Location = New System.Drawing.Point(325, 34)
        Me.lblVL.Name = "lblVL"
        Me.lblVL.Size = New System.Drawing.Size(102, 25)
        Me.lblVL.TabIndex = 14
        Me.lblVL.Text = "Very Large"
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL.ForeColor = System.Drawing.Color.White
        Me.lblL.Location = New System.Drawing.Point(232, 34)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(59, 25)
        Me.lblL.TabIndex = 13
        Me.lblL.Text = "Large"
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblM.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblM.ForeColor = System.Drawing.Color.White
        Me.lblM.Location = New System.Drawing.Point(111, 34)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(82, 25)
        Me.lblM.TabIndex = 12
        Me.lblM.Text = "Medium"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.ForeColor = System.Drawing.Color.White
        Me.lblE.Location = New System.Drawing.Point(18, 34)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(49, 25)
        Me.lblE.TabIndex = 11
        Me.lblE.Text = "Easy"
        '
        'pbc
        '
        Me.pbc.BackColor = System.Drawing.Color.White
        Me.pbc.Location = New System.Drawing.Point(156, 200)
        Me.pbc.Name = "pbc"
        Me.pbc.Size = New System.Drawing.Size(16, 16)
        Me.pbc.TabIndex = 9
        Me.pbc.TabStop = False
        Me.pbc.Visible = False
        '
        'pbF
        '
        Me.pbF.BackColor = System.Drawing.Color.White
        Me.pbF.Location = New System.Drawing.Point(156, 163)
        Me.pbF.Name = "pbF"
        Me.pbF.Size = New System.Drawing.Size(16, 16)
        Me.pbF.TabIndex = 8
        Me.pbF.TabStop = False
        Me.pbF.Visible = False
        '
        'PBChallenge
        '
        Me.PBChallenge.BackColor = System.Drawing.Color.White
        Me.PBChallenge.Location = New System.Drawing.Point(156, 200)
        Me.PBChallenge.Name = "PBChallenge"
        Me.PBChallenge.Size = New System.Drawing.Size(16, 16)
        Me.PBChallenge.TabIndex = 10
        Me.PBChallenge.TabStop = False
        Me.PBChallenge.Visible = False
        '
        'pbFree
        '
        Me.pbFree.BackColor = System.Drawing.Color.White
        Me.pbFree.Location = New System.Drawing.Point(156, 163)
        Me.pbFree.Name = "pbFree"
        Me.pbFree.Size = New System.Drawing.Size(16, 16)
        Me.pbFree.TabIndex = 11
        Me.pbFree.TabStop = False
        Me.pbFree.Visible = False
        '
        'FrmMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(510, 413)
        Me.Controls.Add(Me.pbFree)
        Me.Controls.Add(Me.PBChallenge)
        Me.Controls.Add(Me.pbc)
        Me.Controls.Add(Me.pbF)
        Me.Controls.Add(Me.ChallengePannel)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.BottomPannel)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.TopPannel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ColourFlow : Choose Mode"
        Me.TopPannel.ResumeLayout(False)
        Me.TopPannel.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomPannel.ResumeLayout(False)
        Me.BottomPannel.PerformLayout()
        Me.ChallengePannel.ResumeLayout(False)
        Me.ChallengePannel.PerformLayout()
        CType(Me.pb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBChallenge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TopPannel As System.Windows.Forms.Panel
    Private WithEvents pbLogo As System.Windows.Forms.PictureBox
    Private WithEvents lblClose As System.Windows.Forms.Label
    Private WithEvents lblTitle As System.Windows.Forms.Label
    Private WithEvents lbl1 As System.Windows.Forms.Label
    Private WithEvents BottomPannel As System.Windows.Forms.Panel
    Private WithEvents lblAuthor As System.Windows.Forms.Label
    Private WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents ChallengePannel As System.Windows.Forms.Panel
    Friend WithEvents pb4 As System.Windows.Forms.PictureBox
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Private WithEvents lblVL As System.Windows.Forms.Label
    Private WithEvents lblL As System.Windows.Forms.Label
    Private WithEvents lblM As System.Windows.Forms.Label
    Private WithEvents lblE As System.Windows.Forms.Label
    Friend WithEvents pbF As System.Windows.Forms.PictureBox
    Friend WithEvents pbc As System.Windows.Forms.PictureBox
    Friend WithEvents PBChallenge As System.Windows.Forms.PictureBox
    Friend WithEvents pbFree As System.Windows.Forms.PictureBox
    Private WithEvents lblHelp As System.Windows.Forms.Label
End Class

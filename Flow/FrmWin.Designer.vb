<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWin))
        Me.TopPannel = New System.Windows.Forms.Panel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblSteps = New System.Windows.Forms.Label()
        Me.lblShortest = New System.Windows.Forms.Label()
        Me.lblCloseWindow = New System.Windows.Forms.Label()
        Me.lblNewGame = New System.Windows.Forms.Label()
        Me.TopPannel.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPannel
        '
        Me.TopPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TopPannel.Controls.Add(Me.pbLogo)
        Me.TopPannel.Controls.Add(Me.lblClose)
        Me.TopPannel.Location = New System.Drawing.Point(-1, 0)
        Me.TopPannel.Name = "TopPannel"
        Me.TopPannel.Size = New System.Drawing.Size(521, 102)
        Me.TopPannel.TabIndex = 3
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Silver
        Me.pbLogo.Image = Global.Flow.My.Resources.Resources.Logo_DLL1
        Me.pbLogo.Location = New System.Drawing.Point(81, 16)
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
        Me.lblClose.Location = New System.Drawing.Point(401, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(120, 17)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "Return to Menu (<)"
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.ForeColor = System.Drawing.Color.White
        Me.lblWin.Location = New System.Drawing.Point(173, 117)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(171, 32)
        Me.lblWin.TabIndex = 6
        Me.lblWin.Text = "[You Win/lose]"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.White
        Me.lblMode.Location = New System.Drawing.Point(35, 174)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(154, 25)
        Me.lblMode.TabIndex = 7
        Me.lblMode.Text = "Mode: Very Hard"
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSteps.ForeColor = System.Drawing.Color.White
        Me.lblSteps.Location = New System.Drawing.Point(219, 174)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(106, 25)
        Me.lblSteps.TabIndex = 8
        Me.lblSteps.Text = "Steps: 1000"
        '
        'lblShortest
        '
        Me.lblShortest.AutoSize = True
        Me.lblShortest.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShortest.ForeColor = System.Drawing.Color.White
        Me.lblShortest.Location = New System.Drawing.Point(358, 174)
        Me.lblShortest.Name = "lblShortest"
        Me.lblShortest.Size = New System.Drawing.Size(85, 25)
        Me.lblShortest.TabIndex = 9
        Me.lblShortest.Text = "Shortest:"
        '
        'lblCloseWindow
        '
        Me.lblCloseWindow.AutoSize = True
        Me.lblCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCloseWindow.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseWindow.ForeColor = System.Drawing.Color.White
        Me.lblCloseWindow.Location = New System.Drawing.Point(321, 249)
        Me.lblCloseWindow.Name = "lblCloseWindow"
        Me.lblCloseWindow.Size = New System.Drawing.Size(174, 25)
        Me.lblCloseWindow.TabIndex = 10
        Me.lblCloseWindow.Text = "Return to Menu (<)"
        '
        'lblNewGame
        '
        Me.lblNewGame.AutoSize = True
        Me.lblNewGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNewGame.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewGame.ForeColor = System.Drawing.Color.White
        Me.lblNewGame.Location = New System.Drawing.Point(63, 249)
        Me.lblNewGame.Name = "lblNewGame"
        Me.lblNewGame.Size = New System.Drawing.Size(121, 25)
        Me.lblNewGame.TabIndex = 11
        Me.lblNewGame.Text = "New Game(!)"
        '
        'FrmWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(520, 283)
        Me.Controls.Add(Me.lblNewGame)
        Me.Controls.Add(Me.lblCloseWindow)
        Me.Controls.Add(Me.lblShortest)
        Me.Controls.Add(Me.lblSteps)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.TopPannel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmWin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ColourFlow "
        Me.TopPannel.ResumeLayout(False)
        Me.TopPannel.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TopPannel As System.Windows.Forms.Panel
    Private WithEvents pbLogo As System.Windows.Forms.PictureBox
    Private WithEvents lblClose As System.Windows.Forms.Label
    Private WithEvents lblWin As System.Windows.Forms.Label
    Private WithEvents lblMode As System.Windows.Forms.Label
    Private WithEvents lblSteps As System.Windows.Forms.Label
    Private WithEvents lblShortest As System.Windows.Forms.Label
    Private WithEvents lblCloseWindow As System.Windows.Forms.Label
    Private WithEvents lblNewGame As System.Windows.Forms.Label
End Class

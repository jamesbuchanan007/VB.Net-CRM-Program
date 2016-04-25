<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblEE = New System.Windows.Forms.Label()
        Me.btnCust = New System.Windows.Forms.Button()
        Me.btnMarketing = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnForum = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEE
        '
        Me.lblEE.AutoSize = True
        Me.lblEE.BackColor = System.Drawing.Color.Transparent
        Me.lblEE.Font = New System.Drawing.Font("Monotype Corsiva", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEE.Location = New System.Drawing.Point(21, 9)
        Me.lblEE.Name = "lblEE"
        Me.lblEE.Size = New System.Drawing.Size(674, 117)
        Me.lblEE.TabIndex = 0
        Me.lblEE.Text = "Essential Escapes"
        '
        'btnCust
        '
        Me.btnCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCust.Location = New System.Drawing.Point(77, 148)
        Me.btnCust.Name = "btnCust"
        Me.btnCust.Size = New System.Drawing.Size(124, 50)
        Me.btnCust.TabIndex = 1
        Me.btnCust.Text = "Cust Info"
        Me.btnCust.UseVisualStyleBackColor = False
        '
        'btnMarketing
        '
        Me.btnMarketing.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMarketing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarketing.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarketing.Location = New System.Drawing.Point(77, 238)
        Me.btnMarketing.Name = "btnMarketing"
        Me.btnMarketing.Size = New System.Drawing.Size(124, 50)
        Me.btnMarketing.TabIndex = 2
        Me.btnMarketing.Text = "Marketing"
        Me.btnMarketing.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.Location = New System.Drawing.Point(77, 328)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(124, 50)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'btnForum
        '
        Me.btnForum.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnForum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForum.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnForum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForum.Location = New System.Drawing.Point(77, 418)
        Me.btnForum.Name = "btnForum"
        Me.btnForum.Size = New System.Drawing.Size(124, 50)
        Me.btnForum.TabIndex = 4
        Me.btnForum.Text = "Forum"
        Me.btnForum.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(257, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 328)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnExitProgram
        '
        Me.btnExitProgram.BackColor = System.Drawing.Color.Yellow
        Me.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExitProgram.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitProgram.ForeColor = System.Drawing.Color.Red
        Me.btnExitProgram.Location = New System.Drawing.Point(599, 492)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(106, 23)
        Me.btnExitProgram.TabIndex = 5
        Me.btnExitProgram.Text = "Exit Program"
        Me.btnExitProgram.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 527)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnForum)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnMarketing)
        Me.Controls.Add(Me.btnCust)
        Me.Controls.Add(Me.lblEE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEE As System.Windows.Forms.Label
    Friend WithEvents btnCust As System.Windows.Forms.Button
    Friend WithEvents btnMarketing As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnForum As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExitProgram As System.Windows.Forms.Button

End Class

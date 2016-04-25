<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdbPropertyOwner = New System.Windows.Forms.RadioButton()
        Me.rdbRentalCustomer = New System.Windows.Forms.RadioButton()
        Me.txtSalesFirstName = New System.Windows.Forms.TextBox()
        Me.txtSalesLastName = New System.Windows.Forms.TextBox()
        Me.txtSalesEmail = New System.Windows.Forms.TextBox()
        Me.txtSalesPhone = New System.Windows.Forms.TextBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnNextLead = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EssentialEscapesDatabase11DataSet1 = New EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1()
        Me.ReferralTableAdapter1 = New EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1TableAdapters.ReferralTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EssentialEscapesDatabase11DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 57)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sales Leads"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Phone Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbPropertyOwner
        '
        Me.rdbPropertyOwner.AutoSize = True
        Me.rdbPropertyOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbPropertyOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPropertyOwner.Location = New System.Drawing.Point(184, 338)
        Me.rdbPropertyOwner.Name = "rdbPropertyOwner"
        Me.rdbPropertyOwner.Size = New System.Drawing.Size(136, 24)
        Me.rdbPropertyOwner.TabIndex = 5
        Me.rdbPropertyOwner.TabStop = True
        Me.rdbPropertyOwner.Text = "Property Owner"
        Me.rdbPropertyOwner.UseVisualStyleBackColor = False
        '
        'rdbRentalCustomer
        '
        Me.rdbRentalCustomer.AutoSize = True
        Me.rdbRentalCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdbRentalCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRentalCustomer.Location = New System.Drawing.Point(391, 338)
        Me.rdbRentalCustomer.Name = "rdbRentalCustomer"
        Me.rdbRentalCustomer.Size = New System.Drawing.Size(147, 24)
        Me.rdbRentalCustomer.TabIndex = 6
        Me.rdbRentalCustomer.TabStop = True
        Me.rdbRentalCustomer.Text = "Rental Customer"
        Me.rdbRentalCustomer.UseVisualStyleBackColor = False
        '
        'txtSalesFirstName
        '
        Me.txtSalesFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FirstNameReferral", True))
        Me.txtSalesFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesFirstName.Location = New System.Drawing.Point(184, 114)
        Me.txtSalesFirstName.Name = "txtSalesFirstName"
        Me.txtSalesFirstName.Size = New System.Drawing.Size(354, 26)
        Me.txtSalesFirstName.TabIndex = 1
        '
        'txtSalesLastName
        '
        Me.txtSalesLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "LastNameReferral", True))
        Me.txtSalesLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesLastName.Location = New System.Drawing.Point(184, 166)
        Me.txtSalesLastName.Name = "txtSalesLastName"
        Me.txtSalesLastName.Size = New System.Drawing.Size(354, 26)
        Me.txtSalesLastName.TabIndex = 2
        '
        'txtSalesEmail
        '
        Me.txtSalesEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalesEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "EmailReferral", True))
        Me.txtSalesEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesEmail.Location = New System.Drawing.Point(184, 229)
        Me.txtSalesEmail.Name = "txtSalesEmail"
        Me.txtSalesEmail.Size = New System.Drawing.Size(354, 26)
        Me.txtSalesEmail.TabIndex = 3
        '
        'txtSalesPhone
        '
        Me.txtSalesPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "PhoneReferral", True))
        Me.txtSalesPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPhone.Location = New System.Drawing.Point(184, 289)
        Me.txtSalesPhone.Name = "txtSalesPhone"
        Me.txtSalesPhone.Size = New System.Drawing.Size(354, 26)
        Me.txtSalesPhone.TabIndex = 4
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(305, 495)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(113, 28)
        Me.btnMainMenu.TabIndex = 9
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(452, 406)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(123, 36)
        Me.btnAddCustomer.TabIndex = 8
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'btnNextLead
        '
        Me.btnNextLead.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNextLead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextLead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextLead.Location = New System.Drawing.Point(147, 406)
        Me.btnNextLead.Name = "btnNextLead"
        Me.btnNextLead.Size = New System.Drawing.Size(113, 36)
        Me.btnNextLead.TabIndex = 7
        Me.btnNextLead.Text = "Next Lead"
        Me.btnNextLead.UseVisualStyleBackColor = False
        '
        'btnExitProgram
        '
        Me.btnExitProgram.BackColor = System.Drawing.Color.Yellow
        Me.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExitProgram.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitProgram.ForeColor = System.Drawing.Color.Red
        Me.btnExitProgram.Location = New System.Drawing.Point(605, 500)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(106, 23)
        Me.btnExitProgram.TabIndex = 10
        Me.btnExitProgram.Text = "Exit Program"
        Me.btnExitProgram.UseVisualStyleBackColor = False
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Referral"
        Me.BindingSource1.DataSource = Me.EssentialEscapesDatabase11DataSet1
        '
        'EssentialEscapesDatabase11DataSet1
        '
        Me.EssentialEscapesDatabase11DataSet1.DataSetName = "EssentialEscapesDatabase11DataSet1"
        Me.EssentialEscapesDatabase11DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReferralTableAdapter1
        '
        Me.ReferralTableAdapter1.ClearBeforeFill = True
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(723, 535)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.btnNextLead)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.txtSalesPhone)
        Me.Controls.Add(Me.txtSalesEmail)
        Me.Controls.Add(Me.txtSalesLastName)
        Me.Controls.Add(Me.txtSalesFirstName)
        Me.Controls.Add(Me.rdbRentalCustomer)
        Me.Controls.Add(Me.rdbPropertyOwner)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Form"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EssentialEscapesDatabase11DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdbPropertyOwner As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRentalCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents txtSalesFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents btnNextLead As System.Windows.Forms.Button
    Friend WithEvents btnExitProgram As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EssentialEscapesDatabase11DataSet1 As EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1
    Friend WithEvents ReferralTableAdapter1 As EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1TableAdapters.ReferralTableAdapter
End Class

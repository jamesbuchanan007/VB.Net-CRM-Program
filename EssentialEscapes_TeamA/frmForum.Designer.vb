<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForum))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtForumCustID = New System.Windows.Forms.TextBox()
        Me.forumBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EssentialEscapesDatabase11DataSet11 = New EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1()
        Me.txtForumProperty = New System.Windows.Forms.TextBox()
        Me.txtForumPropID = New System.Windows.Forms.TextBox()
        Me.txtForumFeedback = New System.Windows.Forms.TextBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNextReferral = New System.Windows.Forms.Button()
        Me.btnAddReferral = New System.Windows.Forms.Button()
        Me.txtForumPhone = New System.Windows.Forms.TextBox()
        Me.referralBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtForumEmail = New System.Windows.Forms.TextBox()
        Me.txtForumLastName = New System.Windows.Forms.TextBox()
        Me.txtForumFirstName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNextLead = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ForumTableAdapter = New EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1TableAdapters.ForumTableAdapter()
        Me.ReferralTableAdapter = New EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1TableAdapters.ReferralTableAdapter()
        Me.btnPreviousReferral = New System.Windows.Forms.Button()
        Me.propertyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EssentialEscapesDatabase11DataSet3 = New EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet3()
        Me.PropertyTableAdapter = New EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet3TableAdapters.PropertyTableAdapter()
        CType(Me.forumBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EssentialEscapesDatabase11DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.referralBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.propertyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EssentialEscapesDatabase11DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 57)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The Forum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Property"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Property ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Feedback"
        '
        'txtForumCustID
        '
        Me.txtForumCustID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.forumBindingSource1, "CustomerID", True))
        Me.txtForumCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumCustID.Location = New System.Drawing.Point(200, 94)
        Me.txtForumCustID.Name = "txtForumCustID"
        Me.txtForumCustID.ReadOnly = True
        Me.txtForumCustID.Size = New System.Drawing.Size(322, 26)
        Me.txtForumCustID.TabIndex = 1
        '
        'forumBindingSource1
        '
        Me.forumBindingSource1.DataMember = "Forum"
        Me.forumBindingSource1.DataSource = Me.EssentialEscapesDatabase11DataSet11
        '
        'EssentialEscapesDatabase11DataSet11
        '
        Me.EssentialEscapesDatabase11DataSet11.DataSetName = "EssentialEscapesDatabase11DataSet1"
        Me.EssentialEscapesDatabase11DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtForumProperty
        '
        Me.txtForumProperty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.propertyBindingSource1, "PropertyName", True))
        Me.txtForumProperty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumProperty.Location = New System.Drawing.Point(200, 137)
        Me.txtForumProperty.Name = "txtForumProperty"
        Me.txtForumProperty.ReadOnly = True
        Me.txtForumProperty.Size = New System.Drawing.Size(322, 26)
        Me.txtForumProperty.TabIndex = 2
        '
        'txtForumPropID
        '
        Me.txtForumPropID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.forumBindingSource1, "PropertyID", True))
        Me.txtForumPropID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumPropID.Location = New System.Drawing.Point(200, 180)
        Me.txtForumPropID.Name = "txtForumPropID"
        Me.txtForumPropID.ReadOnly = True
        Me.txtForumPropID.Size = New System.Drawing.Size(322, 26)
        Me.txtForumPropID.TabIndex = 3
        '
        'txtForumFeedback
        '
        Me.txtForumFeedback.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.forumBindingSource1, "Feedback", True))
        Me.txtForumFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumFeedback.Location = New System.Drawing.Point(200, 226)
        Me.txtForumFeedback.Multiline = True
        Me.txtForumFeedback.Name = "txtForumFeedback"
        Me.txtForumFeedback.ReadOnly = True
        Me.txtForumFeedback.Size = New System.Drawing.Size(322, 101)
        Me.txtForumFeedback.TabIndex = 11
        Me.txtForumFeedback.TabStop = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(309, 498)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(98, 27)
        Me.btnMainMenu.TabIndex = 4
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNextReferral)
        Me.GroupBox1.Controls.Add(Me.btnAddReferral)
        Me.GroupBox1.Controls.Add(Me.txtForumPhone)
        Me.GroupBox1.Controls.Add(Me.txtForumEmail)
        Me.GroupBox1.Controls.Add(Me.txtForumLastName)
        Me.GroupBox1.Controls.Add(Me.txtForumFirstName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(41, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 141)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referral Section"
        '
        'btnNextReferral
        '
        Me.btnNextReferral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextReferral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextReferral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextReferral.Location = New System.Drawing.Point(521, 65)
        Me.btnNextReferral.Name = "btnNextReferral"
        Me.btnNextReferral.Size = New System.Drawing.Size(108, 28)
        Me.btnNextReferral.TabIndex = 8
        Me.btnNextReferral.Text = "Next"
        Me.btnNextReferral.UseVisualStyleBackColor = True
        '
        'btnAddReferral
        '
        Me.btnAddReferral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddReferral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddReferral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddReferral.Location = New System.Drawing.Point(521, 31)
        Me.btnAddReferral.Name = "btnAddReferral"
        Me.btnAddReferral.Size = New System.Drawing.Size(108, 28)
        Me.btnAddReferral.TabIndex = 3
        Me.btnAddReferral.Text = "Add Referral"
        Me.btnAddReferral.UseVisualStyleBackColor = True
        '
        'txtForumPhone
        '
        Me.txtForumPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.referralBindingSource2, "PhoneReferral", True))
        Me.txtForumPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumPhone.Location = New System.Drawing.Point(289, 83)
        Me.txtForumPhone.MaxLength = 10
        Me.txtForumPhone.Name = "txtForumPhone"
        Me.txtForumPhone.Size = New System.Drawing.Size(196, 26)
        Me.txtForumPhone.TabIndex = 7
        '
        'referralBindingSource2
        '
        Me.referralBindingSource2.DataMember = "Referral"
        Me.referralBindingSource2.DataSource = Me.EssentialEscapesDatabase11DataSet11
        '
        'txtForumEmail
        '
        Me.txtForumEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.referralBindingSource2, "EmailReferral", True))
        Me.txtForumEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumEmail.Location = New System.Drawing.Point(10, 83)
        Me.txtForumEmail.Name = "txtForumEmail"
        Me.txtForumEmail.Size = New System.Drawing.Size(273, 26)
        Me.txtForumEmail.TabIndex = 6
        '
        'txtForumLastName
        '
        Me.txtForumLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.referralBindingSource2, "LastNameReferral", True))
        Me.txtForumLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumLastName.Location = New System.Drawing.Point(216, 28)
        Me.txtForumLastName.Name = "txtForumLastName"
        Me.txtForumLastName.Size = New System.Drawing.Size(196, 26)
        Me.txtForumLastName.TabIndex = 5
        '
        'txtForumFirstName
        '
        Me.txtForumFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.referralBindingSource2, "FirstNameReferral", True))
        Me.txtForumFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForumFirstName.Location = New System.Drawing.Point(10, 28)
        Me.txtForumFirstName.Name = "txtForumFirstName"
        Me.txtForumFirstName.Size = New System.Drawing.Size(196, 26)
        Me.txtForumFirstName.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(285, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "First Name"
        '
        'btnNextLead
        '
        Me.btnNextLead.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextLead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextLead.Location = New System.Drawing.Point(528, 94)
        Me.btnNextLead.Name = "btnNextLead"
        Me.btnNextLead.Size = New System.Drawing.Size(108, 28)
        Me.btnNextLead.TabIndex = 1
        Me.btnNextLead.Text = "Next"
        Me.btnNextLead.UseVisualStyleBackColor = True
        '
        'btnExitProgram
        '
        Me.btnExitProgram.BackColor = System.Drawing.Color.Yellow
        Me.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExitProgram.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitProgram.ForeColor = System.Drawing.Color.Red
        Me.btnExitProgram.Location = New System.Drawing.Point(599, 502)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(106, 23)
        Me.btnExitProgram.TabIndex = 5
        Me.btnExitProgram.Text = "Exit Program"
        Me.btnExitProgram.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(528, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Previous Lead"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ForumTableAdapter
        '
        Me.ForumTableAdapter.ClearBeforeFill = True
        '
        'ReferralTableAdapter
        '
        Me.ReferralTableAdapter.ClearBeforeFill = True
        '
        'btnPreviousReferral
        '
        Me.btnPreviousReferral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreviousReferral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreviousReferral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousReferral.Location = New System.Drawing.Point(562, 438)
        Me.btnPreviousReferral.Name = "btnPreviousReferral"
        Me.btnPreviousReferral.Size = New System.Drawing.Size(108, 28)
        Me.btnPreviousReferral.TabIndex = 9
        Me.btnPreviousReferral.Text = "Previous"
        Me.btnPreviousReferral.UseVisualStyleBackColor = True
        '
        'propertyBindingSource1
        '
        Me.propertyBindingSource1.DataMember = "Property"
        Me.propertyBindingSource1.DataSource = Me.EssentialEscapesDatabase11DataSet3
        '
        'EssentialEscapesDatabase11DataSet3
        '
        Me.EssentialEscapesDatabase11DataSet3.DataSetName = "EssentialEscapesDatabase11DataSet3"
        Me.EssentialEscapesDatabase11DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertyTableAdapter
        '
        Me.PropertyTableAdapter.ClearBeforeFill = True
        '
        'frmForum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 537)
        Me.Controls.Add(Me.btnPreviousReferral)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.btnNextLead)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.txtForumFeedback)
        Me.Controls.Add(Me.txtForumPropID)
        Me.Controls.Add(Me.txtForumProperty)
        Me.Controls.Add(Me.txtForumCustID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmForum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forum"
        CType(Me.forumBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EssentialEscapesDatabase11DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.referralBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.propertyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EssentialEscapesDatabase11DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtForumCustID As System.Windows.Forms.TextBox
    Friend WithEvents txtForumProperty As System.Windows.Forms.TextBox
    Friend WithEvents txtForumPropID As System.Windows.Forms.TextBox
    Friend WithEvents txtForumFeedback As System.Windows.Forms.TextBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddReferral As System.Windows.Forms.Button
    Friend WithEvents txtForumPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtForumEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtForumLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtForumFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNextLead As System.Windows.Forms.Button
    Friend WithEvents btnExitProgram As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents forumBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EssentialEscapesDatabase11DataSet11 As EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1
    Friend WithEvents ForumTableAdapter As EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1TableAdapters.ForumTableAdapter
    Friend WithEvents referralBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ReferralTableAdapter As EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet1TableAdapters.ReferralTableAdapter
    Friend WithEvents btnNextReferral As System.Windows.Forms.Button
    Friend WithEvents btnPreviousReferral As System.Windows.Forms.Button
    Friend WithEvents propertyBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EssentialEscapesDatabase11DataSet3 As EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet3
    Friend WithEvents PropertyTableAdapter As EssentialEscapes_TeamA.EssentialEscapesDatabase11DataSet3TableAdapters.PropertyTableAdapter
End Class

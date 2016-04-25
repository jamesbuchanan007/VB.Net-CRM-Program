Public Class frmSales

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click

        'Ensures Customer database is saved in case user did not save
        frmCustomerInformation.CustomerTableAdapter.Update(frmCustomerInformation.EssentialEscapesDatabase11DataSet.Customer)
        frmCustomerInformation.Close()
        frmMain.Close()
        frmMarketing.Close()
        Me.Close()
        frmForum.Close()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click

        'Adds new row in customer form and brings user to that screen
        Me.Hide()
        frmCustomerInformation.Show()
        frmCustomerInformation.CustomerBindingSource.AddNew()
        frmCustomerInformation.txtCustInfoFirstName.Text = txtSalesFirstName.Text
        frmCustomerInformation.txtCustInfoLastName.Text = txtSalesLastName.Text
        frmCustomerInformation.txtCustInfoPhone.Text = txtSalesPhone.Text
        frmCustomerInformation.txtCustInfoEmail.Text = txtSalesEmail.Text
    End Sub

    'Private Sub txtSalesPhone_Leave(sender As Object, e As EventArgs) Handles txtSalesPhone.Leave

    '    'Checks and formats phone number
    '    'Dim dblPhoneConverter As Double

    '    'Try
    '    '    dblPhoneConverter = CDbl(txtSalesPhone.Text)
    '    '    txtSalesPhone.Text = (dblPhoneConverter.ToString("(###) ###-####"))

    '    'Catch ex As Exception
    '    '    MsgBox("Must be a numeric")
    '    '    txtSalesPhone.Focus()
    '    '    txtSalesPhone.Clear()
    '    'End Try

    'End Sub

    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EssentialEscapesDatabase11DataSet1.Referral' table. You can move, or remove it, as needed.
        Me.ReferralTableAdapter1.Fill(Me.EssentialEscapesDatabase11DataSet1.Referral)
    End Sub

    Private Sub btnNextLead_Click(sender As Object, e As EventArgs) Handles btnNextLead.Click
        Me.BindingSource1.MoveNext()

    End Sub
End Class
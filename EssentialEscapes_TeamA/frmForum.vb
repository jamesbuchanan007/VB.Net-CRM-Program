Public Class frmForum

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
        frmSales.Close()
        Me.Close()
    End Sub

    Private Sub btnAddReferral_Click(sender As Object, e As EventArgs) Handles btnAddReferral.Click
        frmCustomerInformation.Show()
        Me.Hide()
        frmCustomerInformation.CustomerBindingSource.AddNew()
        frmCustomerInformation.txtCustInfoFirstName.Text = txtForumFirstName.Text
        frmCustomerInformation.txtCustInfoLastName.Text = txtForumLastName.Text
        frmCustomerInformation.txtCustInfoEmail.Text = txtForumEmail.Text
        frmCustomerInformation.txtCustInfoPhone.Text = txtForumPhone.Text
    End Sub
    Private Sub txtForumPhone_Leave(sender As Object, e As EventArgs) Handles txtForumPhone.Leave

        Dim dblPhoneConverter As Double
        Try
            dblPhoneConverter = CDbl(txtForumPhone.Text)
            txtForumPhone.Text = (dblPhoneConverter.ToString("(###) ###-####"))
        Catch ex As Exception
            MsgBox("Must be a numeric")
            txtForumPhone.Focus()
            txtForumPhone.Clear()
        End Try
    End Sub

    Private Sub frmForum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EssentialEscapesDatabase11DataSet3._Property' table. You can move, or remove it, as needed.
        Me.PropertyTableAdapter.Fill(Me.EssentialEscapesDatabase11DataSet3._Property)
        'TODO: This line of code loads data into the 'EssentialEscapesDatabase11DataSet11.Referral' table. You can move, or remove it, as needed.
        Me.ReferralTableAdapter.Fill(Me.EssentialEscapesDatabase11DataSet11.Referral)
        'TODO: This line of code loads data into the 'EssentialEscapesDatabase11DataSet11.Forum' table. You can move, or remove it, as needed.
        Me.ForumTableAdapter.Fill(Me.EssentialEscapesDatabase11DataSet11.Forum)

    End Sub

    Private Sub btnNextLead_Click(sender As Object, e As EventArgs) Handles btnNextLead.Click
        'Goes to next feedback item
        forumBindingSource1.MoveNext()
        propertyBindingSource1.MoveNext()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Goes to previous feedback item
        forumBindingSource1.MovePrevious()
        propertyBindingSource1.MovePrevious()
    End Sub

    Private Sub btnNextReferral_Click(sender As Object, e As EventArgs) Handles btnNextReferral.Click
        referralBindingSource2.MoveNext()
    End Sub

    Private Sub btnPreviousReferral_Click(sender As Object, e As EventArgs) Handles btnPreviousReferral.Click
        'Goes to previous feedback item
        referralBindingSource2.MovePrevious()

    End Sub
End Class
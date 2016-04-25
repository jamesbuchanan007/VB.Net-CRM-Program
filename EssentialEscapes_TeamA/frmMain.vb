Public Class frmMain

    Private Sub btnCust_Click(sender As Object, e As EventArgs) Handles btnCust.Click
        Me.Hide()
        frmCustomerInformation.Show()
    End Sub

    Private Sub btnMarketing_Click(sender As Object, e As EventArgs) Handles btnMarketing.Click
        Me.Hide()
        frmMarketing.Show()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Me.Hide()
        frmSales.Show()
    End Sub

    Private Sub btnForum_Click(sender As Object, e As EventArgs) Handles btnForum.Click
        Me.Hide()
        frmForum.Show()
    End Sub

    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click

        'Ensures Customer database is saved in case user did not save
        frmCustomerInformation.CustomerTableAdapter.Update(frmCustomerInformation.EssentialEscapesDatabase11DataSet.Customer)
        frmCustomerInformation.Close()
        Me.Close()
        frmMarketing.Close()
        frmSales.Close()
        frmForum.Close()
    End Sub
End Class

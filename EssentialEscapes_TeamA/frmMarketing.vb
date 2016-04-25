Public Class frmMarketing

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click

        'Ensures Customer database is saved in case user did not save
        frmCustomerInformation.CustomerTableAdapter.Update(frmCustomerInformation.EssentialEscapesDatabase11DataSet.Customer)

        frmCustomerInformation.Close()
        frmMain.Close()
        Me.Close()
        frmSales.Close()
        frmForum.Close()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click


       
        Dim theStringBuilder As New System.Text.StringBuilder
        theStringBuilder.Append("mailto:" & txtContactInfo.Text)
        theStringBuilder.Append("&From=Essential Escapes")
        theStringBuilder.Append("&cc=Mr. Obama")
        theStringBuilder.Append("&subject=Vacation!!!   " & txtSiteAddress.Text & "  " & "$" & txtSpecialRate.Text & " per Night " & "!! Just for you!!")
        theStringBuilder.Append("&body=" & txtMessage.Text & "   Valid until " & DateTimePicker1.Value & "... :)")
        'theStringBuilder.Append("&body=" & )

        System.Diagnostics.Process.Start(theStringBuilder.ToString())


        BindingSource1.AddNew()
        MarketingTableAdapter.Update(EssentialEscapesDatabase11DataSet2.Marketing)



    End Sub

    Private Sub frmMarketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EssentialEscapesDatabase11DataSet2.Marketing' table. You can move, or remove it, as needed.
        Me.MarketingTableAdapter.Fill(Me.EssentialEscapesDatabase11DataSet2.Marketing)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingSource1.MoveNext()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BindingSource1.MovePrevious()
    End Sub
End Class
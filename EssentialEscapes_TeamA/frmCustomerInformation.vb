Imports System.Text.RegularExpressions

Public Class frmCustomerInformation


    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click

        'Exits entire program and automatically updates database in case user forgot to save
        Me.CustomerTableAdapter.Update(Me.EssentialEscapesDatabase11DataSet.Customer)
        Me.Close()
        frmMain.Close()
        frmMarketing.Close()
        frmSales.Close()
        frmForum.Close()
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click

        'Cancels current action
        CustomerBindingSource.CancelEdit()
        Me.CustomerTableAdapter.Fill(Me.EssentialEscapesDatabase11DataSet.Customer)
    End Sub
    Private Sub txtCustInfoPhone_Leave(sender As Object, e As EventArgs) Handles txtCustInfoPhone.Leave

        'Checks and formats phone number
        Dim dblPhoneConverter As Double

        If txtCustInfoPhone.Text = "" Then
            txtCustInfoFirstName.Focus()
        End If

        Try
            dblPhoneConverter = CDbl(txtCustInfoPhone.Text)
            txtCustInfoPhone.Text = (dblPhoneConverter.ToString("(###) ###-####"))
        Catch ex As Exception
            MsgBox("Must be a numeric")
            txtCustInfoPhone.Focus()
            txtCustInfoPhone.Clear()
        End Try

    End Sub
    Private Sub txtCustInfoState_Leave(sender As Object, e As EventArgs) Handles txtCustInfoState.Leave

        'Checks if valid state format and no symbols
        If Not Regex.Match(txtCustInfoState.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Please Enter Alphabetic Characters Only!", MsgBoxStyle.Exclamation, "User Message")
            txtCustInfoState.Focus()
            txtCustInfoState.Clear()
        End If
    End Sub

    Private Sub frmCustomerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EssentialEscapesDatabase11DataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.EssentialEscapesDatabase11DataSet.Customer)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Updates and saves new database
        CustomerBindingSource.AddNew()
        Me.CustomerTableAdapter.Update(Me.EssentialEscapesDatabase11DataSet.Customer)
        Me.CustomerTableAdapter.Fill(Me.EssentialEscapesDatabase11DataSet.Customer)
        MsgBox("Database Updated", MsgBoxStyle.Information, "User Information")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Adds new row to dataset
        CustomerBindingSource.AddNew()
        txtCustInfoFirstName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Deletes row and confirms with user first
        MsgBox("Delete - Are you sure?", MsgBoxStyle.YesNo, "User Message")

        If MsgBoxResult.Yes Then
            CustomerBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'Prompts a search query box
        Dim question As String = InputBox("Enter First Name or Last Name", "Quick Search")

        CustomerBindingSource.Filter = "CustomerFirstName LIKE '*" & question & "*' or CustomerLastName LIKE '*" & question & "*'"
        'CustomerBindingSource.Filter = "CustomerLastName LIKE '*" & question & "*'"
       

    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click

        'Removes filter and displays entire database
        CustomerBindingSource.RemoveFilter()

    End Sub

End Class

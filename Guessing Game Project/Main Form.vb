' Name: Guessing Game Project
' Purpose:  To guess a random number between 1 and 30!
' Programmer: Andrew Kuykendall on 10/8/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private intAnswer As Integer
    Private intNum_of_Guesses As Integer = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Variables and Constants
        Dim randGen As New Random
        intAnswer = randGen.Next(1, 31)
        intNum_of_Guesses = 0

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' Variables and Constants
        Dim randGen As New Random
        Dim intGuess As Integer

        ' Assigns number user inputs to intGuess
        Integer.TryParse(txtGuess.Text, intGuess)

        'Determine If integer user guesses matches the randomly generated number
        Select Case intGuess
            Case = intAnswer
                intNum_of_Guesses = intNum_of_Guesses + 1
                lblAnswer.Text = "Correct! " & ControlChars.NewLine &
                    " Number of Guesses: " & intNum_of_Guesses.ToString
            Case > intAnswer
                intNum_of_Guesses = intNum_of_Guesses + 1
                lblAnswer.Text = "Too high! " & ControlChars.NewLine &
                    " Number of Guesses: " & intNum_of_Guesses.ToString
            Case < intAnswer
                intNum_of_Guesses = intNum_of_Guesses + 1
                lblAnswer.Text = "Too low! " & ControlChars.NewLine &
                    " Number of Guesses: " & intNum_of_Guesses.ToString
        End Select



    End Sub

    Private Sub txtGuess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuess.KeyPress
        'Backspace and Whole Numbers only
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtGuess_Enter(sender As Object, e As EventArgs) Handles txtGuess.Enter
        txtGuess.SelectAll()
    End Sub
End Class

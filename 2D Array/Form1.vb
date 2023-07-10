'Program: Lab 1 ---2D Array
'Purpose: Comp 9 Lab 1
'Name:Mason Merritt
'Date: Feb 1, 2023

Option Strict On
Option Infer Off
Option Explicit On
Public Class Form1

    'Array Decleration

    Dim strRecordArray(49, 2) As String
    Dim intLogicSize As Integer = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Input Boxes to Add Record Information

        Dim strName As String = InputBox("Please Enter Your Name:", "Name")
        Dim strPosition As String = InputBox("Please Enter Staff or Student:", "Position at School")
        Dim strLaptime As String = InputBox("Please Enter Laptime in Seconds:", "Laptime")

        'Adds Item Name to Listbox

        lstRecords.Items.Add(strName.ToUpper)

        'Add Items to Array
        strRecordArray(intLogicSize, 0) = strName
        strRecordArray(intLogicSize, 1) = strPosition
        strRecordArray(intLogicSize, 2) = strLaptime
        intLogicSize += 1

    End Sub

    Private Sub btnChk_Click(sender As Object, e As EventArgs) Handles btnChk.Click

        'Check Selected Record

        MessageBox.Show(strRecordArray(lstRecords.SelectedIndex, 0) &
                        " is a " & strRecordArray(lstRecords.SelectedIndex, 1) &
                        " they ran a " & strRecordArray(lstRecords.SelectedIndex, 2) & " second laptime")

    End Sub

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click

        'Find Average Laptime`

        Dim dblAverage As Double
        Dim dblLaptime As Double

        For aver As Integer = 0 To intLogicSize
            dblLaptime += Val(strRecordArray(aver, 2))
        Next
        dblAverage = dblLaptime / intLogicSize
        MessageBox.Show("The average laptime is " & dblAverage.ToString)



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Array
        lstRecords.Items.Clear()
        Array.Clear(strRecordArray)

    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click

        'Choose Random Record

        Dim myRandom As New Random
        Dim i As Integer = lstRecords.Items.Count
        MessageBox.Show("The computer has chosen " & lstRecords.Items.Item(myRandom.Next(i)).ToString)
    End Sub

End Class

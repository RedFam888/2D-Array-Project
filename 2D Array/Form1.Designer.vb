<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstRecords = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnChk = New System.Windows.Forms.Button()
        Me.btnAvg = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRecords
        '
        Me.lstRecords.ColumnWidth = 100
        Me.lstRecords.FormattingEnabled = True
        Me.lstRecords.ItemHeight = 15
        Me.lstRecords.Location = New System.Drawing.Point(12, 12)
        Me.lstRecords.MultiColumn = True
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(294, 289)
        Me.lstRecords.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(312, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnChk
        '
        Me.btnChk.Location = New System.Drawing.Point(312, 79)
        Me.btnChk.Name = "btnChk"
        Me.btnChk.Size = New System.Drawing.Size(128, 23)
        Me.btnChk.TabIndex = 2
        Me.btnChk.Text = "Check Record"
        Me.btnChk.UseVisualStyleBackColor = True
        '
        'btnAvg
        '
        Me.btnAvg.Location = New System.Drawing.Point(312, 146)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Size = New System.Drawing.Size(128, 23)
        Me.btnAvg.TabIndex = 3
        Me.btnAvg.Text = "Check Average Time"
        Me.btnAvg.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(312, 278)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Records"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(312, 215)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(128, 23)
        Me.btnRandom.TabIndex = 5
        Me.btnRandom.Text = "Random Record"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAvg)
        Me.Controls.Add(Me.btnChk)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstRecords)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstRecords As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnChk As Button
    Friend WithEvents btnAvg As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRandom As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Form2 = New System.Windows.Forms.Button()
        Me.Form4 = New System.Windows.Forms.Button()
        Me.Form1 = New System.Windows.Forms.Button()
        Me.Form3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Form 5"
        '
        'Form2
        '
        Me.Form2.Location = New System.Drawing.Point(173, 81)
        Me.Form2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Form2.Name = "Form2"
        Me.Form2.Size = New System.Drawing.Size(67, 38)
        Me.Form2.TabIndex = 19
        Me.Form2.Text = "Form 2"
        Me.Form2.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.Form4.Location = New System.Drawing.Point(173, 157)
        Me.Form4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Form4.Name = "Form4"
        Me.Form4.Size = New System.Drawing.Size(67, 38)
        Me.Form4.TabIndex = 17
        Me.Form4.Text = "Form 4"
        Me.Form4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.Form1.Location = New System.Drawing.Point(173, 38)
        Me.Form1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Form1.Name = "Form1"
        Me.Form1.Size = New System.Drawing.Size(67, 38)
        Me.Form1.TabIndex = 16
        Me.Form1.Text = "Form 1"
        Me.Form1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.Form3.Location = New System.Drawing.Point(173, 114)
        Me.Form3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Form3.Name = "Form3"
        Me.Form3.Size = New System.Drawing.Size(67, 38)
        Me.Form3.TabIndex = 21
        Me.Form3.Text = "Form 3"
        Me.Form3.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(251, 225)
        Me.Controls.Add(Me.Form3)
        Me.Controls.Add(Me.Form2)
        Me.Controls.Add(Me.Form4)
        Me.Controls.Add(Me.Form1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Form2 As Button
    Friend WithEvents Form4 As Button
    Friend WithEvents Form1 As Button
    Friend WithEvents Form3 As Button
End Class

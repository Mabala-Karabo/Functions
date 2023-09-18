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
        Button1 = New Button()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(317, 160)
        Button1.Name = "Button1"
        Button1.Size = New Size(218, 88)
        Button1.TabIndex = 0
        Button1.Text = "Execute functions"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(79, 2)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(150, 31)
        txtNum1.TabIndex = 1
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(420, 14)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(150, 31)
        txtNum2.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
End Class

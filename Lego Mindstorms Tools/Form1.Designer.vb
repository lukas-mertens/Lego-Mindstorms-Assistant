<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btMenu_EntfernungMotorbewegung = New System.Windows.Forms.Button()
        Me.btMenu_RotationMotorbewegung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btMenu_EntfernungMotorbewegung
        '
        Me.btMenu_EntfernungMotorbewegung.Location = New System.Drawing.Point(12, 12)
        Me.btMenu_EntfernungMotorbewegung.Name = "btMenu_EntfernungMotorbewegung"
        Me.btMenu_EntfernungMotorbewegung.Size = New System.Drawing.Size(260, 23)
        Me.btMenu_EntfernungMotorbewegung.TabIndex = 0
        Me.btMenu_EntfernungMotorbewegung.Text = "Entfernung -> Motorbewegung"
        Me.btMenu_EntfernungMotorbewegung.UseVisualStyleBackColor = True
        '
        'btMenu_RotationMotorbewegung
        '
        Me.btMenu_RotationMotorbewegung.Location = New System.Drawing.Point(12, 41)
        Me.btMenu_RotationMotorbewegung.Name = "btMenu_RotationMotorbewegung"
        Me.btMenu_RotationMotorbewegung.Size = New System.Drawing.Size(260, 23)
        Me.btMenu_RotationMotorbewegung.TabIndex = 1
        Me.btMenu_RotationMotorbewegung.Text = "Rotation -> Motorbewegung"
        Me.btMenu_RotationMotorbewegung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btMenu_RotationMotorbewegung)
        Me.Controls.Add(Me.btMenu_EntfernungMotorbewegung)
        Me.Name = "Form1"
        Me.Text = "Hauptmenü"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btMenu_EntfernungMotorbewegung As Button
    Friend WithEvents btMenu_RotationMotorbewegung As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntfernungMotorbewegung
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntfernungMotorbewegung))
        Me.cb_S_SelectWheel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar_S_Korrektur = New System.Windows.Forms.TrackBar()
        Me.pb_S_Preview = New System.Windows.Forms.PictureBox()
        Me.nud_EE_Input = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl_EE_Output = New System.Windows.Forms.TabControl()
        Me.Tab_EE_Umd = New System.Windows.Forms.TabPage()
        Me.lb_EE_OutputUmd = New System.Windows.Forms.Label()
        Me.Tab_EE_Grad = New System.Windows.Forms.TabPage()
        Me.lb_EE_OutputGrad = New System.Windows.Forms.Label()
        Me.ImageList_Reifen = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bt_ME_AddItem = New System.Windows.Forms.Button()
        Me.nud_ME_Input = New System.Windows.Forms.NumericUpDown()
        Me.lv_ME_Output = New System.Windows.Forms.ListView()
        Me.lv_ME_Ergebnis_Input = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_ME_Ergebnis_Umd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_ME_Ergebnis_Grad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar_S_Korrektur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_S_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_EE_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl_EE_Output.SuspendLayout()
        Me.Tab_EE_Umd.SuspendLayout()
        Me.Tab_EE_Grad.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nud_ME_Input, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_S_SelectWheel
        '
        Me.cb_S_SelectWheel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_S_SelectWheel.FormattingEnabled = True
        Me.cb_S_SelectWheel.Items.AddRange(New Object() {"43.2*22", "große weiße Reifen", "56*26"})
        Me.cb_S_SelectWheel.Location = New System.Drawing.Point(6, 217)
        Me.cb_S_SelectWheel.Name = "cb_S_SelectWheel"
        Me.cb_S_SelectWheel.Size = New System.Drawing.Size(202, 21)
        Me.cb_S_SelectWheel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TrackBar_S_Korrektur)
        Me.GroupBox1.Controls.Add(Me.cb_S_SelectWheel)
        Me.GroupBox1.Controls.Add(Me.pb_S_Preview)
        Me.GroupBox1.Location = New System.Drawing.Point(560, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 423)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reifen-Auswahl"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Korrektur-Wert"
        '
        'TrackBar_S_Korrektur
        '
        Me.TrackBar_S_Korrektur.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar_S_Korrektur.Location = New System.Drawing.Point(6, 372)
        Me.TrackBar_S_Korrektur.Minimum = -10
        Me.TrackBar_S_Korrektur.Name = "TrackBar_S_Korrektur"
        Me.TrackBar_S_Korrektur.Size = New System.Drawing.Size(202, 45)
        Me.TrackBar_S_Korrektur.TabIndex = 2
        '
        'pb_S_Preview
        '
        Me.pb_S_Preview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_S_Preview.Location = New System.Drawing.Point(6, 19)
        Me.pb_S_Preview.Name = "pb_S_Preview"
        Me.pb_S_Preview.Size = New System.Drawing.Size(202, 192)
        Me.pb_S_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_S_Preview.TabIndex = 0
        Me.pb_S_Preview.TabStop = False
        '
        'nud_EE_Input
        '
        Me.nud_EE_Input.Location = New System.Drawing.Point(6, 19)
        Me.nud_EE_Input.Name = "nud_EE_Input"
        Me.nud_EE_Input.Size = New System.Drawing.Size(526, 20)
        Me.nud_EE_Input.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl_EE_Output)
        Me.GroupBox2.Controls.Add(Me.nud_EE_Input)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 98)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Einzeleingabe"
        '
        'TabControl_EE_Output
        '
        Me.TabControl_EE_Output.Controls.Add(Me.Tab_EE_Umd)
        Me.TabControl_EE_Output.Controls.Add(Me.Tab_EE_Grad)
        Me.TabControl_EE_Output.Location = New System.Drawing.Point(6, 45)
        Me.TabControl_EE_Output.Name = "TabControl_EE_Output"
        Me.TabControl_EE_Output.SelectedIndex = 0
        Me.TabControl_EE_Output.Size = New System.Drawing.Size(530, 46)
        Me.TabControl_EE_Output.TabIndex = 5
        '
        'Tab_EE_Umd
        '
        Me.Tab_EE_Umd.Controls.Add(Me.lb_EE_OutputUmd)
        Me.Tab_EE_Umd.Location = New System.Drawing.Point(4, 22)
        Me.Tab_EE_Umd.Name = "Tab_EE_Umd"
        Me.Tab_EE_Umd.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_EE_Umd.Size = New System.Drawing.Size(522, 20)
        Me.Tab_EE_Umd.TabIndex = 0
        Me.Tab_EE_Umd.Text = "Umdrehungen"
        Me.Tab_EE_Umd.UseVisualStyleBackColor = True
        '
        'lb_EE_OutputUmd
        '
        Me.lb_EE_OutputUmd.AutoSize = True
        Me.lb_EE_OutputUmd.Location = New System.Drawing.Point(6, 3)
        Me.lb_EE_OutputUmd.Name = "lb_EE_OutputUmd"
        Me.lb_EE_OutputUmd.Size = New System.Drawing.Size(13, 13)
        Me.lb_EE_OutputUmd.TabIndex = 4
        Me.lb_EE_OutputUmd.Text = "0"
        '
        'Tab_EE_Grad
        '
        Me.Tab_EE_Grad.Controls.Add(Me.lb_EE_OutputGrad)
        Me.Tab_EE_Grad.Location = New System.Drawing.Point(4, 22)
        Me.Tab_EE_Grad.Name = "Tab_EE_Grad"
        Me.Tab_EE_Grad.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_EE_Grad.Size = New System.Drawing.Size(522, 20)
        Me.Tab_EE_Grad.TabIndex = 1
        Me.Tab_EE_Grad.Text = "Grad"
        Me.Tab_EE_Grad.UseVisualStyleBackColor = True
        '
        'lb_EE_OutputGrad
        '
        Me.lb_EE_OutputGrad.AutoSize = True
        Me.lb_EE_OutputGrad.Location = New System.Drawing.Point(6, 3)
        Me.lb_EE_OutputGrad.Name = "lb_EE_OutputGrad"
        Me.lb_EE_OutputGrad.Size = New System.Drawing.Size(13, 13)
        Me.lb_EE_OutputGrad.TabIndex = 0
        Me.lb_EE_OutputGrad.Text = "0"
        '
        'ImageList_Reifen
        '
        Me.ImageList_Reifen.ImageStream = CType(resources.GetObject("ImageList_Reifen.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Reifen.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Reifen.Images.SetKeyName(0, "1.jpg")
        Me.ImageList_Reifen.Images.SetKeyName(1, "2.jpg")
        Me.ImageList_Reifen.Images.SetKeyName(2, "3.jpg")
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.bt_ME_AddItem)
        Me.GroupBox3.Controls.Add(Me.nud_ME_Input)
        Me.GroupBox3.Controls.Add(Me.lv_ME_Output)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(542, 318)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mehrfacheingabe"
        '
        'bt_ME_AddItem
        '
        Me.bt_ME_AddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_ME_AddItem.Location = New System.Drawing.Point(6, 289)
        Me.bt_ME_AddItem.Name = "bt_ME_AddItem"
        Me.bt_ME_AddItem.Size = New System.Drawing.Size(530, 23)
        Me.bt_ME_AddItem.TabIndex = 7
        Me.bt_ME_AddItem.Text = "Hinzufügen"
        Me.bt_ME_AddItem.UseVisualStyleBackColor = True
        '
        'nud_ME_Input
        '
        Me.nud_ME_Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nud_ME_Input.Location = New System.Drawing.Point(6, 263)
        Me.nud_ME_Input.Name = "nud_ME_Input"
        Me.nud_ME_Input.Size = New System.Drawing.Size(530, 20)
        Me.nud_ME_Input.TabIndex = 6
        '
        'lv_ME_Output
        '
        Me.lv_ME_Output.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lv_ME_Output.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lv_ME_Ergebnis_Input, Me.lv_ME_Ergebnis_Umd, Me.lv_ME_Ergebnis_Grad})
        Me.lv_ME_Output.Location = New System.Drawing.Point(6, 19)
        Me.lv_ME_Output.Name = "lv_ME_Output"
        Me.lv_ME_Output.Size = New System.Drawing.Size(530, 238)
        Me.lv_ME_Output.TabIndex = 0
        Me.lv_ME_Output.UseCompatibleStateImageBehavior = False
        Me.lv_ME_Output.View = System.Windows.Forms.View.Details
        '
        'lv_ME_Ergebnis_Input
        '
        Me.lv_ME_Ergebnis_Input.Text = "Eingabe"
        '
        'lv_ME_Ergebnis_Umd
        '
        Me.lv_ME_Ergebnis_Umd.Text = "Umdrehungen"
        Me.lv_ME_Ergebnis_Umd.Width = 103
        '
        'lv_ME_Ergebnis_Grad
        '
        Me.lv_ME_Ergebnis_Grad.Text = "Grad"
        '
        'EntfernungMotorbewegung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 447)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EntfernungMotorbewegung"
        Me.Text = "Entfernung zu Motorbewegung"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar_S_Korrektur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_S_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_EE_Input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl_EE_Output.ResumeLayout(False)
        Me.Tab_EE_Umd.ResumeLayout(False)
        Me.Tab_EE_Umd.PerformLayout()
        Me.Tab_EE_Grad.ResumeLayout(False)
        Me.Tab_EE_Grad.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.nud_ME_Input, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_S_Preview As PictureBox
    Friend WithEvents cb_S_SelectWheel As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nud_EE_Input As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl_EE_Output As TabControl
    Friend WithEvents Tab_EE_Umd As TabPage
    Friend WithEvents lb_EE_OutputUmd As Label
    Friend WithEvents Tab_EE_Grad As TabPage
    Friend WithEvents lb_EE_OutputGrad As Label
    Friend WithEvents ImageList_Reifen As ImageList
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bt_ME_AddItem As Button
    Friend WithEvents nud_ME_Input As NumericUpDown
    Friend WithEvents lv_ME_Output As ListView
    Friend WithEvents lv_ME_Ergebnis_Input As ColumnHeader
    Friend WithEvents lv_ME_Ergebnis_Umd As ColumnHeader
    Friend WithEvents lv_ME_Ergebnis_Grad As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar_S_Korrektur As TrackBar
End Class

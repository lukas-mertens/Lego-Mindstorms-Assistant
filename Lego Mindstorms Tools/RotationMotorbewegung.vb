Public Class RotationMotorbewegung
    Dim Pi As Double = 3.14159265
    Dim KorrekturWert As Double

    ''' <summary>
    ''' Führt Berechnungen der Einzeleingabe durch
    ''' </summary>
    Sub RefreshEE()
        If nud_EE_Input.Value <> 0 Then
            lb_EE_OutputUmd.Text = ((nud_S_Spurbreite.Value * Pi) / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi)) / (360 / nud_EE_Input.Value) * KorrekturWert
            lb_EE_OutputGrad.Text = ((nud_S_Spurbreite.Value * Pi) / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi)) / (360 / nud_EE_Input.Value) * 360 * KorrekturWert
        Else
            lb_EE_OutputUmd.Text = 0
            lb_EE_OutputGrad.Text = 0
        End If
    End Sub

    ''' <summary>
    ''' Führt Berechnungen der Mehrfacheingabe durch
    ''' </summary>
    Sub RefreshME()
        For i = 0 To lv_ME_Output.Items.Count - 1
            If Double.Parse(lv_ME_Output.Items.Item(i).Text) <> 0 Then
                lv_ME_Output.Items.Item(i).SubItems.Item(1).Text = ((nud_S_Spurbreite.Value * Pi) / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi)) / (360 / Double.Parse(lv_ME_Output.Items.Item(i).Text)) * KorrekturWert
                lv_ME_Output.Items.Item(i).SubItems.Item(2).Text = ((nud_S_Spurbreite.Value * Pi) / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi)) / (360 / Double.Parse(lv_ME_Output.Items.Item(i).Text)) * 360 * KorrekturWert
            Else
                lv_ME_Output.Items.Item(i).SubItems.Item(1).Text = 0
                lv_ME_Output.Items.Item(i).SubItems.Item(2).Text = 0
            End If
        Next
    End Sub

    ''' <summary>
    ''' Berechnet den Korrekturwert
    ''' </summary>
    Sub RefreshKorrekturWert()
        Label_S_Korrekturwert.Text = "Korrektur-Wert: " & (TrackBar_S_Korrektur_Grob.Value + (TrackBar_S_Korrektur_Fein.Value / 10)) * 10 & "%" 'Änderung des Labels, für die Anzeige des Korrekturwertes
        KorrekturWert = ((TrackBar_S_Korrektur_Grob.Value + (TrackBar_S_Korrektur_Fein.Value / 10)) / 10) + 1 'Festlegen des Korrekturwertes
        RefreshEE() 'Alle Werte mit neuem Korrekturwert neu berechnen
        RefreshME()
    End Sub

    ''' <summary>
    ''' Ausgelöst durch: nud_EE_Input.ValueChanged
    ''' </summary>
    Private Sub nud_EE_Input_ValueChanged(sender As Object, e As EventArgs) Handles nud_EE_Input.ValueChanged
        RefreshKorrekturWert()
    End Sub

    ''' <summary>
    ''' Ausgelöst durch: cb_S_SelectWheel.SelectedIndexChanged
    ''' </summary>
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_S_SelectWheel.SelectedIndexChanged
        pb_S_Preview.Image = My.Resources.ResourceManager.GetObject("Reifen_" & cb_S_SelectWheel.SelectedIndex + 1)
        RefreshKorrekturWert()
    End Sub

    ''' <summary>
    ''' Ausgelöst durch Button zum hinzufügen eines Wertes in der Mehrfacheingabe
    ''' </summary>
    Private Sub bt_ME_AddItem_Click(sender As Object, e As EventArgs) Handles bt_ME_AddItem.Click
        With lv_ME_Output.Items.Add(nud_ME_Input.Value)
            .SubItems.Add("")
            .SubItems.Add("")
        End With
        nud_ME_Input.Value = 0
        RefreshKorrekturWert()
    End Sub

    ''' <summary>
    ''' Ausgelöst durch Veränderung des groben Sliders zum verändern des Korrekturwertes in der Selektion
    ''' </summary>
    Private Sub TrackBar_S_Korrektur_Scroll(sender As Object, e As EventArgs) Handles TrackBar_S_Korrektur_Grob.Scroll
        RefreshKorrekturWert()
    End Sub


    ''' <summary>
    ''' Ausgelöst durch Veränderung des feinen Sliders zum verändern des Korrekturwertes in der Selektion
    ''' </summary>
    Private Sub TrackBar_S_Korrektur_Fein_Scroll(sender As Object, e As EventArgs) Handles TrackBar_S_Korrektur_Fein.Scroll
        RefreshKorrekturWert()
    End Sub

    Private Sub nud_S_Spurbreite_ValueChanged(sender As Object, e As EventArgs) Handles nud_S_Spurbreite.ValueChanged
        RefreshKorrekturWert()
    End Sub
End Class
Public Class EntfernungMotorbewegung
    Dim Pi As Double = 3.14159265

    ''' <summary>
    ''' Führt Berechnungen der Einzeleingabe durch
    ''' </summary>
    Sub RefreshEE()
        lb_EE_OutputUmd.Text = nud_EE_Input.Value / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi)
        lb_EE_OutputGrad.Text = nud_EE_Input.Value / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi) * 360
    End Sub

    ''' <summary>
    ''' Führt Berechnungen der Mehrfacheingabe durch
    ''' </summary>
    Sub RefreshME()
        For i = 0 To lv_ME_Output.Items.Count - 1
            lv_ME_Output.Items.Item(i).SubItems.Item(1).Text = Integer.Parse(lv_ME_Output.Items.Item(i).Text) / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi)
            lv_ME_Output.Items.Item(i).SubItems.Item(2).Text = Integer.Parse(lv_ME_Output.Items.Item(i).Text) / (ReifenEigenschaften.GetValue("Durchmesser", cb_S_SelectWheel.SelectedIndex) * Pi) * 360
        Next
    End Sub

    ''' <summary>
    ''' Ausgelöst durch: nud_EE_Input.ValueChanged
    ''' </summary>
    Private Sub nud_EE_Input_ValueChanged(sender As Object, e As EventArgs) Handles nud_EE_Input.ValueChanged
        RefreshEE()
    End Sub

    ''' <summary>
    ''' Ausgelöst durch: cb_S_SelectWheel.SelectedIndexChanged
    ''' </summary>
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_S_SelectWheel.SelectedIndexChanged
        pb_S_Preview.Image = My.Resources.ResourceManager.GetObject("Reifen_" & cb_S_SelectWheel.SelectedIndex + 1)
        RefreshEE()
        RefreshME()
    End Sub

    Private Sub bt_ME_AddItem_Click(sender As Object, e As EventArgs) Handles bt_ME_AddItem.Click
        With lv_ME_Output.Items.Add(nud_ME_Input.Value)
            .SubItems.Add("")
            .SubItems.Add("")
        End With
        nud_ME_Input.Value = 0
        RefreshME()
    End Sub
End Class
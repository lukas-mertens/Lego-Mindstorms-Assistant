Public Class ReifenEigenschaften
    ''' <summary>
    ''' Gibt Eigenschaft eines Reifens zurück
    ''' </summary>
    ''' <param name="Eigenschaft">Name der Eigenschaft</param>
    ''' <param name="Reifen">ID des Reifens</param>
    Public Shared Function GetValue(Eigenschaft As String, Reifen As Integer) As Double
        Select Case (Eigenschaft)

            'Durchmesser des Reifens in cm.
            Case "Durchmesser"
                Select Case (Reifen) 'Auswahl des richtigen Reifens
                    Case 0
                        Return 4.32
                    Case 1
                        Return 8.3
                    Case 2
                        Return 5.6

                    Case Else
                        Return 0
                End Select

            'Breite des Reifens in cm
            Case "Breite"
                Select Case (Reifen)
                    Case 0
                        Return 2.2
                    Case 1
                        Return 1.3
                    Case 2
                        Return 2.6

                    Case Else
                        Return 0
                End Select
            Case Else
                Return -999
        End Select
    End Function

End Class

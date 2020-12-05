Public Class Form1

    'This program finds e in e=mc^2 given mass. 
    '**EXTRA This program finds kiloton bomb equivalent to the determined energy with the given mass.**    
    ' @author Michias Shiferaw
    ' @Version 2.0
    ' @since 2020-02-18.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Declare all public variables
        Dim mass As Double
        Dim energy As Double
        Dim kilotonE As Double

        'place the user's input in a specified variable
        mass = InputBox("Please enter a mass (kg).")


        If IsNumeric(mass) Then
            If (mass >= 0) Then
                'Recognize a constant of light
                Dim speedOfLight As Double = 299792458

                'process of calculating the energy used and also converting into Kiloton bombs
                energy = (mass * speedOfLight ^ 2)

                'EXTRA: determine energy in terms of kiloton bombs
                kilotonE = (energy * 0.00000000000023901)

                'output
                Dim mass1 As String = mass
                Dim energy1 As String = energy
                Dim kilotonE1 As String = kilotonE
                MsgBox("This mass releases " + energy1 + "J of energy and with the mass of " + mass1 + " kg it can also be equivalent to " + kilotonE1 + "kt bombs.")
            Else
                MsgBox("Not valid input. Mass can only be negative if it is being repelled by gravity.")
            End If
        End If

        'Close Class
        MsgBox("Bye Bye!")

    End Sub
End Class

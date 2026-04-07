Namespace ClassZoo
    Public Class Owl 
        Inherits Animal
        Sub New(InputName As String, InputID As Integer, InputWeight As Single, InputHeight As Single)
            MyBase.New(InputName, InputID, InputWeight, InputHeight)
        End Sub

        Public Overrides Sub PrintSpecies()
            Console.WriteLine("Animal Species: Owl")
        End Sub 
        Public Overrides Sub AnimalSound()
            Console.WriteLine(Me.GetName() + " hoots")
        End Sub
    End Class
End Namespace
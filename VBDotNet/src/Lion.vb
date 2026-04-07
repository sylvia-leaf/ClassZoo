Namespace ClassZoo
    Public Class Lion 
        Inherits Animal
        Sub New(InputName As String, InputID As Integer, InputWeight As Single, InputHeight As Single)
            MyBase.New(InputName, InputID, InputWeight, InputHeight)
        End Sub

        Public Overrides Sub PrintSpecies()
            Console.WriteLine("Animal Species: Lion")
        End Sub 
        Public Overrides Sub AnimalSound()
            Console.WriteLine(Me.GetName() + " roars")
        End Sub
    End Class
End Namespace
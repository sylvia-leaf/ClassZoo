Namespace ClassZoo
    Public Class Bear 
        Inherits Animal
        Sub New(InputName As String, InputID As Integer, InputWeight As Single, InputHeight As Single)
            MyBase.New(InputName, InputID, InputWeight, InputHeight)
        End Sub

        Public Overrides Sub PrintSpecies()
            Console.WriteLine("Animal Species: Bear")
        End Sub 
        Public Overrides Sub AnimalSound()
            Console.WriteLine(Me.GetName() + " growls")
        End Sub
    End Class
End Namespace
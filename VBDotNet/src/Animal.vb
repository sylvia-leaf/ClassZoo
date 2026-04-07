Namespace ClassZoo
    Public Class Animal
        Private Name As String
        Private ID As Integer
        Private Weight As Single
        Private Height As Single

        Sub New(InputName As String, InputID As Integer, InputWeight As Single, InputHeight As Single)
            Name = InputName
            ID = InputID
            Weight = InputWeight
            Height = InputHeight
        End Sub
        ' Getters
        Public Function GetName() As String
            Return Name
        End Function
        Public Function GetID() As Integer
            Return ID
        End Function
        Public Function GetWeight() As Single
            Return Weight
        End Function
        Public Function GetHeight() As Single
            Return Height
        End Function
        ' Setters
        Public Sub SetName(NewName As String)
            Name = NewName
        End Sub
        Public Sub SetID(NewID As Integer)
            ID = NewID
        End Sub
        Public Sub SetWeight(NewWeight As String)
            Weight = NewWeight
        End Sub
        Public Sub SetHeight(NewHeight As String)
            Height = NewHeight
        End Sub
        ' Print information
        Public Sub PrintInfo()
            Console.WriteLine("Animal Name: " + name + vbCrLf + "Animal ID:" + Str(id) + vbCrLf + "Animal Weight:" + Str(Math.Round(weight * 1000) / 1000) + vbCrLf + "Animal Height:" + Str(Math.Round(weight * 100) / 100))
        End Sub
        Public Overridable Sub PrintSpecies()
            Console.WriteLine("Animal Species: Not Specified")
        End Sub
        Public Overridable Sub AnimalSound()
            Console.WriteLine(name + " makes a sound")  
        End Sub
    End Class
End Namespace
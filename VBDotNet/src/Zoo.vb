Namespace ClassZoo
    Public Class Zoo
        Private Animals As List(Of Animal)
        Private ZooSize As Integer
        Private ZooName As String

        Sub New(InputZooSize As Integer, InputZooName As String)
            Animals = New List(Of Animal)
            ZooSize = InputZooSize
            ZooName = InputZooName
        End Sub

        Sub New(InputZooSize As Integer, InputZooName As String, InputAnimal As Animal)
            Animals = New List(Of Animal)
            Animals.Add(InputAnimal)
            ZooSize = InputZooSize
            ZooName = InputZooName
        End Sub

        Sub New(InputZooSize As Integer, InputZooName As String, InputAnimals As List(Of Animal))
            Animals = New List(Of Animal)
            ZooSize = InputZooSize
            ZooName = InputZooName
        End Sub

        Public Sub AddAnimal(InputAnimal As Animal)
            If Animals.Count() >= ZooSize
                Throw New Exception(ZooName + " cannot have more than" + Str(ZooSize) + "animals")
            End If
            For a As Integer = 0 To Animals.Count() - 1
                If (Animals(a).GetID() = InputAnimal.GetID())
                    Throw New Exception("ID collision in " + ZooName + " : " + InputAnimal.GetID())
                End If
            Next
            Animals.Add(InputAnimal)
        End Sub

        Public Function GetAnimal(InputID As Integer) As Animal
            If Animals.Count() >= ZooSize
                Throw New Exception(ZooName + " cannot have more than" + Str(ZooSize) + "animals")
            Else
                For a As Integer = 0 To Animals.Count() - 1
                    If (Animals(a).GetID() = InputID)
                        Return Animals(a)
                    End If
                Next
            End If 
            Throw New Exception("Animal ID not found in " + ZooName + ":" + Str(InputID))
        End Function

        Public Sub FreeAnimal(InputID As Integer)
            Dim Deleted As Boolean = False
            If Animals.Count() = 0
                Throw New Exception("Empty zoo:" + zooName)
            Else 
                For a As Integer = 0 To Animals.Count() - 1
                    If ((Animals(a).GetID() = InputID) And (Deleted = False))
                        Animals.RemoveAt(a)
                        Deleted = True
                        Exit For
                    End If
                Next
            End If
            If Deleted = False
                Throw New Exception("Animal ID not found in " + ZooName + ":" + Str(InputID))
            End If
        End Sub

        Public Sub AnimalInfo(InputID As Integer)
            Dim Found As Boolean = False
            If Animals.Count() = 0
                Throw New Exception("Empty zoo:" + zooName)
            Else 
                For a As Integer = 0 To Animals.Count() - 1
                    If Animals(a).GetID() = InputID
                        Animals(a).PrintInfo()
                        Animals(a).PrintSpecies()
                        Found = True
                        Exit For
                    End If
                Next
            End If
            If Found = False
                Throw New Exception("Animal ID not found in " + ZooName + ":" + Str(InputID))
            End If
        End Sub

        Public Sub ListAnimals()
            Console.WriteLine("=== Information for zoo " + zooName + "===")
            If Animals.Count() = 0
                Console.WriteLine("No animals in zoo.")
            Else
                For a As Integer = 0 To Animals.Count() - 1
                    Console.WriteLine("=== Animal Information ===")
                    Animals(a).PrintInfo()
                    Animals(a).PrintSpecies()
                Next
                Console.WriteLine("=== Information end ===")
            End If
        End Sub

        Public Function GetAllAnimals() As List(Of Animal)
            Return Animals
        End Function

    End Class
End Namespace
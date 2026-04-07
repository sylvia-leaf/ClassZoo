Imports System

Namespace ClassZoo
    Module ClassZoo
        Sub Main(args As String())
            Dim MyZoo As New Zoo(10, "My Zoo")
            MyZoo.AddAnimal(New Lion("Amy",1,240.5f,2.8f))
            MyZoo.AddAnimal(New Bear("Bella",2,310.8f,4.5f))
            MyZoo.AddAnimal(New Animal("Undefined",3,0.0f,0.0f))
            MyZoo.AddAnimal(New Owl("Caitlyn",4,4.2f,0.48f))
            MyZoo.FreeAnimal(3)
            MyZoo.GetAnimal(4).SetID(3)
            MyZoo.ListAnimals()
            MyZoo.GetAnimal(1).AnimalSound()
            MyZoo.GetAnimal(2).AnimalSound()
            MyZoo.GetAnimal(3).AnimalSound()
        End Sub
    End Module
End Namespace
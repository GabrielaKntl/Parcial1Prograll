Imports System

Module Program
    Sub Main()
        Console.WriteLine("Consulta de Gentilicios y Tipos de Animales")

        ' Definir datos de Humanos y Animales
        Dim paises() As String = {"El Salvador", "M�xico", "Argentina", "Alemania", "Rusia"}
        Dim gentilicios() As String = {"salvadore�o", "mexicano", "argentino", "Alem�n", "Rusos"}
        Dim animales() As String = {"Lobo", "Le�n", "�guila", "Tigre", "Caballo"}
        Dim especies() As String = {"Canina", "Felina", "Ave", "Felina", "Equina"}

        ' Mostrar un men� de opciones
        Console.WriteLine("Seleccione una opci�n:")
        Console.WriteLine("1. Consultar Gentilicio")
        Console.WriteLine("2. Consultar Tipo de Animal")
        Dim opcion As Integer = Integer.Parse(Console.ReadLine())

        If opcion = 1 Then
            ' Consulta de Gentilicio
            Console.WriteLine("Ingrese un pa�s:")
            Dim paisBuscado As String = Console.ReadLine()

            ' Buscar el pa�s ingresado y mostrar el gentilicio
            Dim encontrado As Boolean = False
            For i As Integer = 0 To paises.Length - 1
                If paises(i) = paisBuscado Then
                    Console.WriteLine("El gentilicio de " & paisBuscado & " es " & gentilicios(i))
                    encontrado = True
                    Exit For
                End If
            Next

            If Not encontrado Then
                Console.WriteLine("Pa�s no encontrado.")
            End If
        ElseIf opcion = 2 Then
            ' Consulta de Tipo de Animal
            Console.WriteLine("Ingrese una especie:")
            Dim especieBuscada As String = Console.ReadLine()

            ' Buscar la especie ingresada y mostrar el tipo de animal
            Dim encontrado As Boolean = False
            For i As Integer = 0 To especies.Length - 1
                If especies(i) = especieBuscada Then
                    Console.WriteLine("El tipo de animal de la especie " & especieBuscada & " es " & animales(i))
                    encontrado = True
                    Exit For
                End If
            Next

            If Not encontrado Then
                Console.WriteLine("Especie no encontrada.")
            End If
        Else
            Console.WriteLine("Opci�n no v�lida.")
        End If

        Console.WriteLine("Ejecuci�n del programa terminada.")
    End Sub
End Module

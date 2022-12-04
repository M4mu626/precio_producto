Module Module1

    Sub Main()
        Dim Cantidad, Credito As Integer
        Dim precio, abono, cuota1, cuota2 As Single
        Console.WriteLine("Que cantidad desea llevar: ")
        Cantidad = Console.ReadLine()
        Console.WriteLine("Que precio tiene el producto: ")
        precio = Console.ReadLine()
        abono = Cantidad * precio
        Console.WriteLine("El precio total a pagar es: ")
        Console.WriteLine(abono)
        Console.WriteLine("cuanto desea abonar ")
        Credito = Console.ReadLine()
        cuota1 = abono - Credito
        If Credito < abono Then
            Console.WriteLine("El total que queda debiendo es:")
            Console.WriteLine(cuota1)
        Else
            cuota2 = abono - Credito
            Console.WriteLine("El total que queda debiendo es:")
            Console.WriteLine(cuota2)

        End If
        Console.ReadKey()
    End Sub

End Module
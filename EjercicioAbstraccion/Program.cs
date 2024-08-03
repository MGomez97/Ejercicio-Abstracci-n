using System;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraMatematica calculadora = new CalculadoraMatematica();

        Console.WriteLine("Ingrese el primer número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        calculadora.AsignarNumeros(num1, num2);

        Console.WriteLine("Seleccione la operación a realizar:");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        int opcion = int.Parse(Console.ReadLine());

        calculadora.RealizarOperacion(opcion);

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }
}

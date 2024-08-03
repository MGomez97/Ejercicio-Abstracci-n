using System;

abstract class Matematicas
{
    // Métodos abstractos
    public abstract double Operacion1(double num1, double num2);
    public abstract double Operacion2(double num1, double num2);
    public abstract double Operacion3(double num1, double num2);
    public abstract double Operacion4(double num1, double num2);

    // Método concreto para imprimir
    public void Imprimir(double resultado)
    {
        Console.WriteLine("El resultado es: " + resultado);
    }
}

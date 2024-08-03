using System;

class CalculadoraMatematica : Matematicas
{
    private double numero1;
    private double numero2;

    // Implementación de los métodos abstractos
    public override double Operacion1(double num1, double num2)
    {
        return num1 + num2;
    }

    public override double Operacion2(double num1, double num2)
    {
        return num1 - num2;
    }

    public override double Operacion3(double num1, double num2)
    {
        return num1 * num2;
    }

    public override double Operacion4(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            throw new ArgumentException("No se puede dividir por cero.");
    }

    // Método para asignar números ingresados por el usuario
    public void AsignarNumeros(double num1, double num2)
    {
        numero1 = num1;
        numero2 = num2;
    }

    // Método para realizar la operación seleccionada
    public void RealizarOperacion(int opcion)
    {
        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = Operacion1(numero1, numero2);
                break;
            case 2:
                resultado = Operacion2(numero1, numero2);
                break;
            case 3:
                resultado = Operacion3(numero1, numero2);
                break;
            case 4:
                resultado = Operacion4(numero1, numero2);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        Imprimir(resultado);
    }
}

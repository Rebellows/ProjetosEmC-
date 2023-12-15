using System.Collections;
using ProjetosEmC_.Models;

Calculadora calc = new Calculadora();

int var1, var2;

Console.WriteLine("===========================");
Console.WriteLine("Qual operação deseja fazer?");
Console.WriteLine("[1] Soma");
Console.WriteLine("[2] Subtração");
Console.WriteLine("[3] Divisão");
Console.WriteLine("[4] Multiplicação");
Console.WriteLine("[5] Par ou ímpar");
Console.WriteLine("[6] Potenciação");
Console.WriteLine("Digite aqui: ");
string valor = Console.ReadLine();
Console.WriteLine("===========================");

Console.WriteLine("Primeiro valor: ");
var1 = Convert.ToInt16(Console.ReadLine());
calc.getX(var1);
Console.WriteLine("Segundo valor (se aplicável, ou zero): ");
var2 = Convert.ToInt16(Console.ReadLine());
calc.getY(var2);

switch(valor) {
    case "1":
        Console.WriteLine(calc.somar(var1, var2));
        break;
    case "2":
        Console.WriteLine(calc.subtrair(var1, var2));
        break;
    case "3":
        Console.WriteLine(calc.dividir(var1, var2));
        break;
    case "4":
        Console.WriteLine(calc.multiplicar(var1, var2));
        break;
    case "5":
        Console.WriteLine(calc.parOuImpar(var1));
        break;
    case "6":
        Console.WriteLine(calc.potencia(var1, var2));
        break;
    default:
        Console.WriteLine("Valor inválido");
        break;
}
Console.WriteLine("===========================");

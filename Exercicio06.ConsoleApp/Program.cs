// Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
// que C.

Console.Write("Digite o valor de A: ");
double valorA = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de B: ");
double valorB = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de C: ");
double valorC = Convert.ToDouble(Console.ReadLine());

if (valorA + valorB < valorC)
{
    Console.WriteLine($"\nA soma de A + B ({valorA + valorB}) é MENOR que C ({valorC}).");
}

Console.ReadLine();
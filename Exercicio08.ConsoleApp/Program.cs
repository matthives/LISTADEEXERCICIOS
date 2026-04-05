// Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

bool deveContinuar = true;

while (deveContinuar == true)
{

    Console.Clear();
    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("O número é PAR.");
    }
    else
    {
        Console.WriteLine("o NÚMERO É ÍMPAR.");
    }

    Console.WriteLine();
    Console.Write("Deseja consultar outro número?  ");
    string opcaoContinuar = Console.ReadLine()!;

    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        deveContinuar = false;
    }
}
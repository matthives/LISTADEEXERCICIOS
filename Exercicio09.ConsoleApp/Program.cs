// Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo
// de A! e o seu resultado.
// a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
// b. Pesquise sobre “fatorial”

bool deveContinuar = true;

while (deveContinuar == true)
{
    Console.Clear();
    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine())!;
    int resultado = 1;
    string sequencia = "";

    for (int indice = numero; indice >= 1; indice--)
    {
        resultado *= indice;

        sequencia += indice;

        if (indice > 1)
        {
            sequencia += " x ";
        }
    }

    Console.WriteLine($"{numero}! = {sequencia} = {resultado}");

    Console.WriteLine();
    Console.WriteLine("Deseja consultar outro número? (s/n) ");
    string opcaoContinuar = Console.ReadLine()!;

    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        deveContinuar = false;
    }

}
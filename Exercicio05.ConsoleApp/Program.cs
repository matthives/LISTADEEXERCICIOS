// Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

Console.Write("Digite a nota da primeira prova: ");
double primeiraNota = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota da segunda prova: ");
double segundaNota = Convert.ToDouble(Console.ReadLine());

double media = (primeiraNota + segundaNota) / 2;

Console.WriteLine($"A média das duas provas é: {media:F2}");

Console.ReadLine();
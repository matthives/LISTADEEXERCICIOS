// 1. Crie um programa para calcular o volume de uma caixa retangular
// multiplique o comprimento, a largura e a altura
// (Fórmula: V = C . L . A) 50 cm (Comprimento) x 30 cm (largura) x 20 cm (altura).

Console.Write("Digite o comprimento da caixa retangular: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o altura da caixa retangular: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o largura da caixa retangular: ");
double largura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa é: {volume:F2}");

Console.ReadLine();
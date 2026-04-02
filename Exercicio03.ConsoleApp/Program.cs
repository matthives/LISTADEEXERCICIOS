// Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit


Console.Write("Digite a temperatua em celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine($"A escala em fahrenheit é: {celsius}ºc equivale a {fahrenheit:F2} ºF");

Console.ReadLine();
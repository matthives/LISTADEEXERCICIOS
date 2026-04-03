// A fórmula é IMC = peso /
// (altura) 2. Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição
// de acordo com a listagem abaixo:
// a. IMC em adultos Condição
// b. Abaixo de 18,5
// c. Abaixo do peso
// d. Entre 18,5 e 25 Peso normal
// e. Entre 25 e 30
// f. Acima do peso
// g. Acima de 30 obeso

Console.Write("Digite seu peso (Kg): ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura (m): ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / Math.Pow(altura, 2);

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Peso normal");
}
else if (imc >= 25 && imc <= 30)
{
    Console.WriteLine("Condição: Acima do peso");
}
else
{
    Console.WriteLine("Condição: Obeso");
}

Console.ReadLine();
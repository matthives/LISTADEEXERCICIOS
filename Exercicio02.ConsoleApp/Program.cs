// Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
// viagem.
//          O programa deve solicitar ao usuário:
//              a. A quilometragem inicial do veículo no início da viagem.
//              b. A quilometragem final ao término da viagem.
//              c. A quantidade de combustível consumida durante a viagem (em litros).

Console.Write("Digite a quilometragem inicial do veículo: ");
double quilometragemInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quilometragem final do veículo: ");
double quilometragemFinal = Convert.ToDouble(Console.ReadLine());

Console.Write("quantidade de combustível consumida durante a viagem: ");
double combustivel = Convert.ToDouble(Console.ReadLine());

double distanciaPercorrida = quilometragemFinal - quilometragemInicial;

double consumo = distanciaPercorrida / combustivel;

Console.WriteLine($"o consumo de combustível por quilômetro percorrido em uma viagem é: {consumo:F2} Km/l");

Console.ReadLine();

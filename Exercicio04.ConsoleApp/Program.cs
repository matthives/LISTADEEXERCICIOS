// Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário
// base e o total de vendas. A comissão é calculada com um percentual (informado pelo
// usuário) sobre o total de vendas.

Console.Write("Informe o salário base: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o total de vendas: ");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o percentual da comissão: ");
double percentualComissao = Convert.ToDouble(Console.ReadLine());

double comissao = totalVendas * (percentualComissao / 100);
double salarioTotal = salarioBase + comissao;

Console.WriteLine($"O salário total: {salarioTotal:F2} reais");

Console.ReadLine();
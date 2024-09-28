// See https://aka.ms/new-console-template for more information
Console.Write("Qual a distância percorrida pelo automóvel em km? ");
double distancia = double.Parse(Console.ReadLine());
Console.Write("Qual o volume de combustível em litros? ");
int volume = int.Parse(Console.ReadLine());
double consumo = distancia/ volume;
Console.WriteLine("O consumo médio do automóvel é " + consumo.ToString("F2") + " km/l");


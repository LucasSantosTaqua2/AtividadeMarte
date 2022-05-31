Console.Write("Digite a corrente: ");
double I = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a resistencia: ");
double R = Convert.ToDouble(Console.ReadLine());

double V = R * I;

Console.WriteLine($"A voltagem é {V}");
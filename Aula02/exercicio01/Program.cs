using System.Diagnostics;

const float pi = 3.14159f;
float raio, area;

string entrada = Console.ReadLine()!;
float.TryParse(entrada, out raio);

area = pi * raio * raio;

Console.WriteLine($"A = {area:F4}");
Console.WriteLine("Введите координату X первой точки: ");
double x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
double y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
double z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
double x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
double y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
double z2 = int.Parse(Console.ReadLine());
double A = x2 - x1;
double B = y2 - y1;
double C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length:f3}");

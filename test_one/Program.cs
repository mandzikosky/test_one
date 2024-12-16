// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int one = Convert.ToInt32(Console.ReadLine());
int two = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Rezultatot od odzemanjeto e:" + Odzemanje(one, two));
Console.WriteLine("Rezultatot od mnozenjeto e:" + Mnozenje(one, two));
Console.WriteLine("Zbirot na dvata br e:" + Zbir(one, two));
Console.WriteLine("Kolicnikot na broevite e: " + Delenje(one, two));
static double Delenje(double p, double l)
{
    double kolicnik = p / l;
    return kolicnik;
}
static int Zbir(int x, int y)
{
    int zbir = x + y;
    return zbir;
}
static int Mnozenje(int o, int k)
{
    int mnozenje = o * k;
    return mnozenje;
}
static int Odzemanje(int u, int j)
{
    int odzemanje = u - j;
    return odzemanje;
}
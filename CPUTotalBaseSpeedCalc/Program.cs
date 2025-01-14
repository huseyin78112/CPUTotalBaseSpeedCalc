using System.Globalization;

NumberFormatInfo nfi = new NumberFormatInfo();
nfi.NumberDecimalSeparator = ".";
bool is12OrHigher = false;
string line = "";
while (line.ToLower() is not ("y" or "n"))
{
    Console.Write("Is the CPU Intel Core 12th gen (Alder Lake) or higher? (Y/N) ");
    line = Console.ReadLine();
}
if (line.ToLower() is "y")
{
    is12OrHigher = true;
}
else
{
    is12OrHigher = false;
}
if (is12OrHigher)
{
    line = "";
    float EcoreBaseFreq = 0;
    float PcoreBaseFreq = 0;
    int ecores = 0;
    int pcores = 0;
    int threads = 0;
    while (!float.TryParse(line, nfi, out EcoreBaseFreq))
    {
        Console.Write("Enter efficiency core base frequency: ");
        line = Console.ReadLine();
    }
    line = "";
    while (!float.TryParse(line, nfi, out PcoreBaseFreq))
    {
        Console.Write("Enter performance core base frequency: ");
        line = Console.ReadLine();
    }
    line = "";
    while (!int.TryParse(line, nfi, out ecores))
    {
        Console.Write("Enter efficient cores: ");
        line = Console.ReadLine();
    }
    line = "";
    while (!int.TryParse(line, out pcores))
    {
        Console.Write("Enter performance cores: ");
        line = Console.ReadLine();
    }
    line = "";
    while (!int.TryParse(line, out threads))
    {
        Console.Write("Enter threads (logical processors): ");
        line = Console.ReadLine();
    }
    Console.WriteLine("Total CPU base speed is: {0}", (ecores * EcoreBaseFreq + pcores * PcoreBaseFreq) * threads);
}
else
{
    line = "";
    float baseFreq = 0;
    int cores = 0;
    int threads = 0;
    while (!float.TryParse(line, nfi, out baseFreq))
    {
        Console.Write("Enter base frequency: ");
        line = Console.ReadLine();
    }
    line = "";
    while (!int.TryParse(line, nfi, out cores))
    {
        Console.Write("Enter cores: ");
        line = Console.ReadLine();
    }
    line = "";
    while (!int.TryParse(line, nfi, out threads))
    {
        Console.Write("Enter threads (logical processors): ");
        line = Console.ReadLine();
    }
    Console.WriteLine("Total CPU base speed is: {0}", cores * baseFreq * threads);
}
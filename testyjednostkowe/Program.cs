using System;

public class KalkulatorDelty
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0");

        Console.Write("Podaj wartość a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wartość c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;
        string wynik = ObliczPierwiastki(delta, a, b);

        Console.WriteLine($"Delta jest równa: {delta}");
        Console.WriteLine(wynik);

        Console.ReadLine();
    }

    public static string ObliczPierwiastki(double delta, double a, double b)
    {
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return $"Pierwiastki równania kwadratowego to: x1 = {x1}, x2 = {x2}";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);

            return $"Równanie kwadratowe ma jeden pierwiastek: x = {x}";
        }
        else
        {
            return "Równanie nie ma pierwiastków rzeczywistych.";
        }
    }
}

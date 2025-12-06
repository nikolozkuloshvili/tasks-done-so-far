namespace CodeName06122025
{
    internal class Program
    {
        static void Main()
        {
            Discriminant disc = new Discriminant();

            disc.A = disc.GetNumA("a = ");

            disc.B = disc.GetNumbers("b = ");

            disc.C = disc.GetNumbers("c = ");

            disc.CalculateDisc();
            Console.WriteLine($"D = {disc.D}");

            if (disc.GetRoots() == true)
            {
                if (disc.D > 0)
                {
                    Console.WriteLine($"This Equation has two roots:\n X1 = {disc.X1} \n X2 = {disc.X2}");
                }
                else
                {
                    Console.WriteLine($"This Equation has only one root: X = {disc.X1}");
                }
            }
            else
            {
                {
                    Console.WriteLine("This Equation has no roots");
                }
            }
        }
    }
}
class Discriminant
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double D { get; set; }
    public double? X1 { get; set; }
    public double? X2 { get; set; }

    public double GetNumbers(string text)
    {
        double number;
        while (true)
        {
            Console.Write(text);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
    public double GetNumA(string text)
    {
        double number;
        while (true)
        {
            Console.Write(text);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                if (number == 0)
                {
                    Console.WriteLine("If you put 0 the equation won't be quadratic anymore. Please try again with a non-zero number.");
                }
                else
                {
                    return number;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    public double CalculateDisc()
    {
        D = Math.Pow(B, 2) - (4 * A * C);
        return D;
    }

    public bool GetRoots()
    {

        if (D > 0)
        {
            X1 = (-B - Math.Sqrt(D)) / (2 * A);
            X2 = (-B + Math.Sqrt(D)) / (2 * A);
            return true;
        }
        else if (D == 0)
        {
            X1 = X2 = -B / (2 * A);
            return true;
        }
        else
        {
            X1 = X2 = null;
            return false;
        }
    }
}

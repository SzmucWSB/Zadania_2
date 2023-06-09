using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double liczbaPi;

        liczbaPi = Math.PI;
        double p;

        p = inputValue();
        double r;

        r = Math.Sqrt(p / liczbaPi);
        Console.WriteLine(r);
        double o;

        o = 2 * liczbaPi * r;
        Console.WriteLine(o);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());   
        Console.WriteLine(f1.GetDecimalValue());     

        Console.WriteLine();

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());   
        Console.WriteLine(f2.GetDecimalValue());     

        Console.WriteLine();

       
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());   
        Console.WriteLine(f3.GetDecimalValue());   

        Console.WriteLine();

        Fraction f4 = new Fraction(); 
        f4.SetTop(3);
        f4.SetBottom(4);
        Console.WriteLine(f4.GetFractionString());   
        Console.WriteLine(f4.GetDecimalValue());     

        Console.WriteLine();

        Fraction f5 = new Fraction(5, 0); 
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        
        Console.WriteLine();
        Console.WriteLine("Press Enter to finish...");
        Console.ReadLine();
    }
}

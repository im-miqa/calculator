using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
	    static void Main(string[] args)
	    {
		
		Console.Write("Input nilai a = ");
		int a = int.Parse(Console.Readline());
		
		Console.Write("Input nilai b = ");
		int b = Convert.ToInt32(Console.Readline());
		
		Console.WriteLine();
		
		Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penjumlahan(a, b));
		Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
		Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));
		
		Console.WriteLine("\nTekan sembarang ben metu");
		Console.ReadKey();
	    }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
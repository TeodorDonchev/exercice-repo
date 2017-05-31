using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the year you made the photo: ");
            var year = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the month you made the photo: ");
            var month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the day you made the photo: ");
            var day = int.Parse(Console.ReadLine());
            Console.Write("Please enter the width of the photo: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Please enter the height of the photo: ");
            var height = double.Parse(Console.ReadLine());

            double megapixels = width * height / 1000000;
            Console.WriteLine($"Photo made on: {day}/{month}/{year}");
            Console.WriteLine($"{width}x{height} => {Math.Round(megapixels, 1 )}MP");


        }
    }
}

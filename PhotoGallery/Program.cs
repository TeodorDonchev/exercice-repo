using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var sizeKV = photoSize / 1000;
            var sizeMB = photoSize / 1000000.0;


            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:D2}");
            if (photoSize < 1024)
            {
                Console.WriteLine($"Size: {photoSize}B");

            }
            else if (photoSize > 1024 && photoSize < 1048576)
            {
                Console.WriteLine($"Size: {sizeKV}KB");
            }
             else if (photoSize > 1048576)
            {
                Console.WriteLine($"Size: {sizeMB}MB");
            }

              if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
            else if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (height > width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            Console.WriteLine("Succesfully made the transformation");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
Я ХОЧУ УДАЛИТЬ ЄТОТ ФАИЛ 
namespace ConsoleApplication4
{
    class Program
    {
        public struct POINT //characteristic of point enclosed in the structure POINT
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            
          
          
        Console.WriteLine("Введите колво точек:");
        int koll = Convert.ToInt32(Console.ReadLine()); // amount of points

            POINT[] mass = new POINT[koll];
            int i;
            for (i = 0; i < koll; i++)
            { Console.WriteLine("Введите x " + (i + 1) + "-й точки: "); // coordinate Х
                mass[i].x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y " + (i + 1) + "-й точки: ");// coordinate У
                mass[i].y = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            int min_x = mass[0].x; int max_x = mass[0].x; // minimum and maximum coordinates X
            int min_y = mass[0].y; int max_y = mass[0].y; // minimum and maximum coordinates Y


            for (i = 0; i < koll; i++) // view coordinates of out points and initialization min and max values of coordinates
            {
                Console.WriteLine("Точка[" + (i + 1) + "]--->(" + mass[i].x + "," + mass[i].y +")");
                if (mass[i].x < min_x) min_x = mass[i].x;
                if (mass[i].y < min_y) min_y = mass[i].y;
                if (mass[i].x > max_x) max_x = mass[i].x;
                if (mass[i].y > max_y) max_y = mass[i].y;
            }
            POINT[] reworkMass = new POINT[koll]; // rework array of POINTS in the correct sequence
            i = 0;  int j; int c;
            for (int min2 = min_y; min2 <= max_y; min2++) // rework by Y
            {
                for (c = 0; c < koll; c++)
                    if (mass[c].y == min2) { reworkMass[i] = mass[c]; i++; }

            }
            i = 0;
            for (int min = min_x; min <= max_x; min++) // rework by X
            {
                for ( j = 0; j < koll; j++)
                    if (mass[j].x == min) { reworkMass[i] = mass[j]; i++; }
         
                
            }
            Console.WriteLine("Порядок точек для соединения :");
            for (i = 0; i < koll; i++)
            {
                Console.WriteLine("Точка[" + (i + 1) + "]--->(" + reworkMass[i].x + "," + reworkMass[i].y + ")"); // View the correct sequrnce of points
            }
                Console.ReadKey();
        }
    }
}
           
         
        
      





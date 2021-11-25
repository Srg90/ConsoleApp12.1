using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12._1
{
    internal class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Выберете необходимое действие");
            Console.WriteLine();
            Console.WriteLine("     1. Рассчитать длину окружности по заданному радиусу");
            Console.WriteLine("     2. Рассчитать площадь круга по заданному радиусу");
            Console.WriteLine("     3. Определить принадлежность точки с координатами (x, y) кругу с заданным радиусом и координатами центра x0, y0");
            Console.WriteLine();
            Start:
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();
           

            switch (choice)
            {
                case "1":
                    
                    Console.WriteLine();
                    Console.Write("Задайте значение радиуса: ");
                    Task12.Circumference();
                    break;

                case "2":
                    
                    Console.WriteLine();
                    Console.Write("Задайте значение радиуса: ");
                    Task12.Area();
                    break;

                case "3":
                    
                    Console.WriteLine();
                    Task12.PointCircle();
                    break;

                default:
                    
                    Console.WriteLine("Такого параметра не существует!");
                    Console.WriteLine();
                    goto Start;
            }

            Console.ReadKey();

        }
    }

       
   

   static class Task12
   {
        
       
        public static void Circumference()
        {
            Start1:
            try
            {

                double r1 = double.Parse(Console.ReadLine());
                double p = 2 * Math.PI * r1;
                Console.WriteLine();
                Console.WriteLine("Длина окружности = {0}", Math.Round(p, 2));
                Task12.ReturnMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.Write("Задайте значение радиуса: ");
                goto Start1;
            }
        }

        public static void Area()
        {
            Start2:
            try
            {
                double r2 = double.Parse(Console.ReadLine());
                double s = Math.PI * Math.Pow(r2, 2);
                Console.WriteLine();
                Console.WriteLine("Площадь круга = {0}", Math.Round(s, 2));
                Task12.ReturnMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.Write("Задайте значение радиуса: ");
                goto Start2;
            }
        }

        public static void PointCircle()
        {
            Start3:
            try
            {
                Console.Write("Задайте значение радиуса: ");
                double r3 = double.Parse(Console.ReadLine());
                Console.Write("Задайте значение координаты x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Задайте значение координаты y: ");
                double y = double.Parse(Console.ReadLine());
                double h = (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
                if (h > r3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Расстояние до точки от начала координат = {0}", Math.Round(h, 2));
                    Console.WriteLine("Точка не принадлежит кругу");
                    Task12.ReturnMenu();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Расстояние до точки от начала координат = {0}", Math.Round(h, 2));
                    Console.WriteLine("Точка принадлежит кругу");
                    Task12.ReturnMenu();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                goto Start3;
            }
            
        }

        public static void ReturnMenu()
        {
            
            Console.WriteLine();
            Console.WriteLine("     1. Для возврата к главному меню");
            Console.WriteLine("     2. Для выхода из программы");
            Console.WriteLine();
            Start4:
            Console.Write("Ваш выбор: ");

            string choice1 = Console.ReadLine();

            switch (choice1)
            {
                case "1":

                    Console.WriteLine();
                    Program.Main();
                    break;

                case "2":

                    Console.WriteLine();
                    Console.WriteLine("Для завершения нажмите любую клавишу");
                    break;

                default:
                    
                    Console.WriteLine("Такого параметра не существует!");
                    Console.WriteLine();
                    goto Start4;


            }

        }


    }
    


}


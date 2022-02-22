using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork8.Figures;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            int key;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(table);
                Console.WriteLine("");
                Console.Write("Введите номер фигуры (Выход -1): ");
                key = int.Parse(Console.ReadLine());

                Figure figure = table.figures[key];
                Console.WriteLine($"Выбрана фигура: {figure}");

                int x, y;
                Console.Write("Введите x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                y = int.Parse(Console.ReadLine());

                figure.Step(x, y);

                if (key == -1)
                {
                    break;
                }
            }

            }
    }
}

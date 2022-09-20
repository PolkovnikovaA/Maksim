using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz
{
    /// <summary>
    /// Основной класс приложения
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Стартовый метод приложения
        /// </summary>
        /// <param name="args">
        /// Аргументы, передаваемые в качестве параметров
        /// </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите один из видов трубы:\n1. PN10\n2. PN16\n3. PN20\n4. PN25");
            Console.Write("Ваш выбор: ");
            int truba = int.Parse(Console.ReadLine());

            Console.Write("Введите толщину стенки: ");
            double stena = Double.Parse(Console.ReadLine());

            Console.Write("Введите длину: ");   
            double dlina = Double.Parse(Console.ReadLine());    //3960-4040

            Console.Write("Введите внешний диаметр (мм): "); 
            int diametr = int.Parse(Console.ReadLine());    //20, 25, 32, 40, 50, 63

            Truba tr = new Truba();
            tr.Trubb(dlina, truba, diametr, stena);
            Console.ReadKey();
        }      
    }

    /// <summary>
    /// Класс диаметр, для массива минимальных и максимальных процентов
    /// </summary>
    public class Diametr
    {
        public double[] min = new double[] { 10, 13.5, 16.5 };  //Массив для минимальных процентов
        public double[] max = new double[] { 11, 14, 17 };  //Массив для максимальных процентов
    }

    public class Truba
    {
        public void Crav(double crav1, double crav2, double diam, double thi_wal)
        {
            Diametr diametr = new Diametr();

            crav1 = diam / 100 * diametr.min[0];
            crav2 = diam / 100 * diametr.max[0];
            if (thi_wal >= crav1 && thi_wal <= crav2)
            {
                Console.WriteLine("Результат: соответствует");

                TextWriterTraceListener[] listeners = new TextWriterTraceListener[]
                {
                    /*new TextWriterTraceListener(@"D:\1.txt"),*/  //Путь к файлу
                    //new TextWriterTraceListener(Console.Out)
                    new TextWriterTraceListener("C.txt")
                };
                Debug.Listeners.AddRange(listeners);
                Debug.WriteLine("Программа завершена без ошибок"); //Вывод в файл и консоль
                Debug.Flush();
            }
            else
            {
                Console.WriteLine("Результат: не соответствует!");

                TextWriterTraceListener[] listeners = new TextWriterTraceListener[]
                {
                    /*new TextWriterTraceListener(@"D:\1.txt"),*/  //Путь к файлу
                    //new TextWriterTraceListener(Console.Out)
                    new TextWriterTraceListener("C.txt")
                };
                Debug.Listeners.AddRange(listeners);
                Debug.WriteLine("Программа завершена с ошибками!");
                Debug.Flush();
            }
            return;
        }

        public void Trubb(double lengh, double trubes, double diam, double thi_wal)
        {
            double min_lengh = 3960;    //Минимальная длина трубы
            double max_lengh = 4040;    //Максимальная длина трубы

            if (lengh >= min_lengh && max_lengh >= lengh)
            {
                switch (trubes)
                {
                    case 1:
                        Console.WriteLine("PN10");
                        if (diam == 20)
                        {
                            Crav(0,0,0,0);
                        }
                        else if (diam == 25)
                        {
                            Crav(0, 0, 0, 0);
                        }
                        else if (diam == 32)
                        {
                            Crav(0, 0, 0, 0);
                        }
                        else if (diam == 40)
                        {
                            Crav(0, 0, 0, 0);
                        }
                        else if (diam == 50)
                        {
                            Crav(0, 0, 0, 0);
                        }
                        else if (diam == 63)
                        {
                            Crav(0, 0, 0, 0);
                        }
                        break;

                    case 2:

                        Console.WriteLine("PN16");

                        break;

                    case 3:
                        Console.WriteLine("PN20");
                        break;

                    case 4:
                        Console.WriteLine("PN25");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Длина не соответствует!");
            }
        }
    }
}

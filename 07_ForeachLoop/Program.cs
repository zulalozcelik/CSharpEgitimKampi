using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü
            //string[] cities = { "milano", "roma", "istanbul" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //-----------------------------------------------------
            //int[] numbers = { 45, 65, 62, 32, 8, 2, 8754, 88, 51, 58, 98, 49 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //----------------------------------------------------
            //int[] numbers = { 45, 65, 62, 32, 8, 2, 8754, 88, 51, 58, 98, 49 };
            //int total = 0;
            //foreach (int i in numbers) {total += i;}
            //Console.WriteLine(total);
            //------------------------------------------------------

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,8
            //};
            //foreach (int number in numbers) {Console.WriteLine(number); }
            //#endregion
            //Console.Read();
            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("********** C# Eğitim Kampı Sınav Uygulaması ************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            
            string[] studentNames=new string[studentCount];
            double [] studentExamAvg=new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+ 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                for (int j = 0; j <=2; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}.sınav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamAvg[i] = totalExamResult / 3;
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("-------------------------------------------------");
            }
            
            #endregion
            Console.Read();

        }
    }
}

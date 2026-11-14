using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prevozi
{
    internal class Prevozi
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Колко превоза ще въвеждаш -> ");
                int n = int.Parse(Console.ReadLine());
                List<Info> prevozi = new List<Info>();
                for(int i = 0; i < n; i++)
                {
                    
                    Console.WriteLine($"---Превоз {i + 1}---");
                    Console.Write("Име на шофьор -> ");
                    string name = Console.ReadLine();
                    Console.Write("Начало гр./с. -> ");
                    string nachalo = Console.ReadLine();
                    Console.Write("Край гр./с. -> ");
                    string krai = Console.ReadLine();
                    Console.Write("Разстояние в (КМ) -> ");
                    double km = double.Parse(Console.ReadLine());
                    Console.Write("Марка -> ");
                    string marka = Console.ReadLine();
                    Console.Write("Регистрационен номер -> ");
                    string registracionenNomer = Console.ReadLine();
                    Console.Write("Дата на пробег (дни) -> ");
                    int dataProbeg = int.Parse(Console.ReadLine());
                    Info prevoz = new Info(name, nachalo, krai, km, marka, registracionenNomer, dataProbeg);
                    prevozi.Add(prevoz);            
                }

                Console.WriteLine();
                Console.WriteLine("---Всички превози---");
                prevozi.ForEach(x => x.Print());
                Console.WriteLine();

                Console.Write("Въведи име на шофьор -> ");
                string ime = Console.ReadLine();
                var namereniImena = prevozi.Where(x => x.Name.Contains(ime)).ToList();
                Console.WriteLine($"---Намерени по зададено име---");
                namereniImena.ForEach(x => x.Print());
                Console.WriteLine();

                Console.WriteLine("---Сумарен пробег на превозите въведени в системата---");
                double obshtoKilometri = prevozi.Sum(x => x.Km);
                Console.WriteLine(obshtoKilometri);
                Console.WriteLine();

                Console.WriteLine("---Най-дълъг превоз---");
                var naiDulugPrevoz = prevozi.Where(x => x.Km == prevozi.Max(p => p.Km)).ToList();
                naiDulugPrevoz.ForEach(x => x.Print());
                Console.WriteLine();

                Console.WriteLine("---Сортиране по име или по (км) /при еднакви стойности/---");
                var sortirane = prevozi.OrderBy(x => x.Name).ThenBy(x => x.Km).ToList();
                sortirane.ForEach(x => x.Print());
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"ГРЕШКА!!! -> {ex.Message}");
            }
           
        }
    }
}

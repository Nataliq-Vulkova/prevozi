using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Prevozi
{
    public class Info
    {
        private string name;
        private string nachalo;
        private string krai;
        private double km;
        private string marka;
        private string registracionenNomer;
        private int dataProbeg;

        public string Name
        {
            get { return name; }
            set 
            { 
                if(value.Length <= 2)
                {
                    throw new ArgumentException("Въведи ПОВЕЧЕ от 2 букви за ИМЕТО.");
                }
                else
                {
                    name = value; 
                }
                
            }
        }
        public string Nachalo
        {
            get { return nachalo; }
            set { nachalo = value; }
        }
        public string Krai
        {
            get { return krai; }
            set { krai = value; }
        }
        public double Km
        {
            get { return km; }
            set 
            { 
                if(value == 0)
                {
                    throw new Exception("Километрите НЕ МОЖЕ да са НУЛА.");
                }
                else
                {
                    km = value; 
                }
            }
        }
        public string Marka
        {
            get { return marka; }
            set 
            { 
                if(value.Length <= 2)
                {
                    throw new FormatException("МАРКАТА на автомобила трябва да е с ПОВЕЧЕ от 2 букви.");
                }
                else
                {
                    marka = value;
                } 
            }
        }
        public string RegisracionenNomer
        {
            get { return registracionenNomer; }
            set 
            { 
                if(value.Length != 8)
                {
                    throw new ArgumentOutOfRangeException("Въведи ТОЧНО 8 символа за регисрационния номер.");
                }
                else
                {
                    registracionenNomer = value; 
                }
                
            }
        }
        public int DataProbeg
        {
            get { return dataProbeg; }
            set 
            { 
                if(value == 0)
                {
                    throw new ArgumentNullException("Пробега на колата НЕ МОЖЕ да е НУЛА.");
                }
                else
                {
                    dataProbeg = value;
                }
            }
        }
        public Info(string name, string nachalo, string krai, double km, string marka, string registracionenNomer, int dataProbeg)
        {
            this.Name = name;
            this.Nachalo = nachalo;
            this.Krai = krai;
            this.Km = km;
            this.Marka = marka;
            this.RegisracionenNomer = registracionenNomer;
            this.DataProbeg = dataProbeg;
        }
        public Info(string name, string marka)
        {
            this.Name = name;
            this.Marka = marka;
        }
        public void Print()
        {
            Console.WriteLine($"Име: {name} // Курс: {nachalo} - {krai} ({km} km) // Марка: {marka} // Регистрационен номер: {registracionenNomer} // Дата на пробег: {dataProbeg}");
        }
    }
}

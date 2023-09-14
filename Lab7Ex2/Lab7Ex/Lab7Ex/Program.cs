using System;

namespace Lab7Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor Tdi = new Motor(2000, 144, "Motorina");
            Usa usi = new Usa(5);
            Autoturism Golf6 = new Autoturism("VW", 2012, "Golf6", usi, Tdi);
            Console.WriteLine(Golf6.GetDescription());
            Golf6.PornesteMasina();
            Golf6.OpresteMasina();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Ex
{
    class Autoturism
    {
        private readonly string marca;
        private readonly int anDeFabricatie;
        private readonly string model;
        private Usa usi;
        private Motor motor;

        public Autoturism(string marca, int anDeFabricatie, string model,Usa usi,Motor motor)
        {
            this.marca = marca;
            this.anDeFabricatie = anDeFabricatie;
            this.model = model;
            this.usi = usi;
            this.motor = motor;

        }

        public void PornesteMasina()
        {
            Console.WriteLine("Masina Porneste");
            usi.InchideUsa();
            motor.PornesteMotor();

        }

        public void OpresteMasina()
        {
            Console.WriteLine("Masina se opreste");
            motor.OpresteMotor();
            usi.DeschideUsa();
           

        }


        public string GetDescription()
        {
            return $"Autoturismul este fabricat de catre :{marca}, modelul: {model},are o capacicate cilindrica de {motor.CapaticateC},este fabricat in anul {anDeFabricatie},functioneaza cu {motor.TipCombustibil}, are o putere de {motor.Putere}Cai putere, are {usi.NumarUsi} usi";
        }


    }
}

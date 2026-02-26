using System;

namespace DigitalisNyomozas
{
    internal class DecisionEngine
    {
        public void Ertekeles(Suspect gyanusitott, Case ugy)
        {
            int osszeg = 0;

            foreach (var b in ugy.Bizonyitekok)
            {
                osszeg += b.Megbizhatosag * 10;
            }

            gyanusitott.Gyanuszint = osszeg;

            if (osszeg >= 70)
            {
                Console.WriteLine("FIGYELMEZTETÉS: Kritikus gyanúsítottsági szint!");
                gyanusitott.Statusz = "Őrizetben";
            }
        }
    }
}
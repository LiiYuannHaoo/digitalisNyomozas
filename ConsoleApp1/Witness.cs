using System;

namespace DigitalisNyomozas
{
    internal class Witness
    {
        Person? szemely = null;
        string vallomas = string.Empty;
        DateTime datum;

        public Witness(Person szemely, string vallomas)
        {
            this.Szemely = szemely;
            this.Vallomas = vallomas;
            this.Datum = DateTime.Now;
        }

        internal Person? Szemely { get => szemely; set => szemely = value; }
        public string Vallomas { get => vallomas; set => vallomas = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }
}
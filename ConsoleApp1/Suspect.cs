namespace DigitalisNyomozas
{
    internal class Suspect
    {
        Person? szemely = null;
        int gyanuszint = 0;
        string statusz = string.Empty;

        public Suspect(Person szemely)
        {
            this.Szemely = szemely;
            this.Gyanuszint = 0;
            this.Statusz = "Szabad";
        }

        internal Person? Szemely { get => szemely; set => szemely = value; }
        public int Gyanuszint { get => gyanuszint; set => gyanuszint = value; }
        public string Statusz { get => statusz; set => statusz = value; }

        public override string ToString()
        {
            return $"{szemely?.Nev ?? "Ismeretlen"} - Szint: {gyanuszint} - {statusz}";
        }
    }
}
namespace DigitalisNyomozas
{
    internal class User
    {
        string nev = string.Empty;
        string azonosito = string.Empty;
        string szerepkor = string.Empty;

        public User(string nev, string azonosito, string szerepkor)
        {
            this.Nev = nev;
            this.Azonosito = azonosito;
            this.Szerepkor = szerepkor;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Szerepkor { get => szerepkor; set => szerepkor = value; }

        public override string ToString()
        {
            return $"{nev} ({szerepkor})";
        }
    }
}
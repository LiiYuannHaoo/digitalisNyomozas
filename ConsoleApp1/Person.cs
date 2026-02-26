namespace DigitalisNyomozas
{
    internal class Person
    {
        string nev = string.Empty;
        int eletkor;
        string megjegyzes = string.Empty;

        public Person(string nev, int eletkor, string megjegyzes)
        {
            this.Nev = nev;
            this.Eletkor = eletkor;
            this.Megjegyzes = megjegyzes;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }

        public override string ToString()
        {
            return $"{nev} ({eletkor} év)";
        }
    }
}
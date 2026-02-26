namespace DigitalisNyomozas
{
    internal class Evidence
    {
        string azonosito = string.Empty;
        string tipus = string.Empty;
        string leiras = string.Empty;
        int megbizhatosag;

        public Evidence(string azonosito, string tipus, string leiras, int megbizhatosag)
        {
            this.Azonosito = azonosito;
            this.Tipus = tipus;
            this.Leiras = leiras;
            this.Megbizhatosag = megbizhatosag;
        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Megbizhatosag { get => megbizhatosag; set => megbizhatosag = value; }

        public override string ToString()
        {
            return $"{azonosito} - {tipus} (Megbízhatóság: {megbizhatosag})";
        }
    }
}
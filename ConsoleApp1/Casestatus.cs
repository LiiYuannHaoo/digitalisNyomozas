namespace DigitalisNyomozas
{
    internal class CaseStatus
    {
        string aktualisStatusz = string.Empty;

        public CaseStatus() 
        {
            this.AktualisStatusz = "Nyitott";
        }

        public string AktualisStatusz { get => aktualisStatusz; set => aktualisStatusz = value; }

        public void AllapotValtas(string ujStatusz)
        {
            this.aktualisStatusz = ujStatusz;
        }
    }
}
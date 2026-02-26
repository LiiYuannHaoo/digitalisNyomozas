using System;

namespace DigitalisNyomozas
{
    internal class TimelineEvent
    {
        DateTime datum = DateTime.Now;
        string leiras = string.Empty;

        public TimelineEvent(string leiras)
        {
            this.Leiras = leiras;
        }

        public DateTime Datum { get => datum; set => datum = value; }
        public string Leiras { get => leiras; set => leiras = value; }

        public override string ToString()
        {
            return $"{datum} - {leiras}";
        }
    }
}
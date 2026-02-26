using System.Collections.Generic;

namespace DigitalisNyomozas
{
    internal class Case
    {
        string ugyAzonosito = string.Empty;
        string cim = string.Empty;
        string leiras = string.Empty;
        CaseStatus statusz = new CaseStatus();

        List<Person> szemelyek = new List<Person>();
        List<Evidence> bizonyitekok = new List<Evidence>();
        List<TimelineEvent> idovonal = new List<TimelineEvent>();

        public Case(string ugyAzonosito, string cim, string leiras)
        {
            this.UgyAzonosito = ugyAzonosito;
            this.Cim = cim;
            this.Leiras = leiras;
            this.Statusz = new CaseStatus();
            this.Szemelyek = new List<Person>();
            this.Bizonyitekok = new List<Evidence>();
            this.Idovonal = new List<TimelineEvent>();
        }

        public string UgyAzonosito { get => ugyAzonosito; set => ugyAzonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        internal CaseStatus Statusz { get => statusz; set => statusz = value; }
        internal List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
        internal List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
        internal List<TimelineEvent> Idovonal { get => idovonal; set => idovonal = value; }

        public void SzemelyHozzaadas(Person szemely)
        {
            this.szemelyek.Add(szemely);
        }

        public void BizonyitekHozzaadas(Evidence evidence)
        {
            this.bizonyitekok.Add(evidence);
        }

        public void IdovonalHozzaadas(string leiras)
        {
            this.idovonal.Add(new TimelineEvent(leiras));
        }

        public override string ToString()
        {
            return $"{ugyAzonosito} - {cim} ({statusz.AktualisStatusz})";
        }
    }
}
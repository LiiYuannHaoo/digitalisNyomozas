using System.Collections.Generic;

namespace DigitalisNyomozas
{
    internal class DataStore
    {
        List<Case> ugyek;

        public DataStore()
        {
            ugyek = new List<Case>();
        }

        public List<Case> Ugyek { get => ugyek; }
    }
}
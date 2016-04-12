using System;
using System.Collections.Generic;

namespace Version_3_C
{
    public sealed class clsDateComparer : IComparer<clsWork>
    {   //Singleton
        public static readonly clsDateComparer Instance = new clsDateComparer();

        private clsDateComparer() { }

        public int Compare(clsWork x, clsWork y)
        {
            clsWork lcWorkX = x;
            clsWork lcWorkY = y;
            DateTime lcDateX = lcWorkX.Date.Date;
            DateTime lcDateY = lcWorkY.Date.Date;

            return lcDateX.CompareTo(lcDateY);
        }
    }
}

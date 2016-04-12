using System;
using System.Collections.Generic;

namespace Version_3_C
{
    sealed class clsNameComparer : IComparer<clsWork>
    {   //Singleton
        public static readonly clsNameComparer Instance = new clsNameComparer();

        private clsNameComparer() { }

        public int Compare(clsWork x, clsWork y)
        {
            clsWork workClassX = x;
            clsWork workClassY = y;
            string lcNameX = workClassX.Name;
            string lcNameY = workClassY.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}

using System;

namespace Version_3_C
{
    [Serializable()]
    public abstract class clsWork
    {
        private string _Name;
        private DateTime _Date = DateTime.Now;
        private decimal _Value;

        public clsWork()
        {
            EditDetails();
        }

        public static readonly string FACTORY_PROMPT = "Enter P for Painting, S for Sculpture and H for Photograph";

        public static clsWork NewWork(char prChoice)
        {
            switch (char.ToUpper(prChoice))
            {
                case 'P': return new clsPainting();
                case 'S': return new clsSculpture();
                case 'H': return new clsPhotograph();
                default: return null;
            }
        }

        public abstract void EditDetails();

        public override string ToString()
        {
            return _Name + "\t" + _Date.ToShortDateString();
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public decimal Value
        {
            get { return _Value; }
            set { _Value = value; }
        }


    }
}

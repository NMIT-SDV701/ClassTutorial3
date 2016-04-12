using System;

namespace Version_3_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        public delegate void LoadSculptureFormDelegate(clsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;

        public override void EditDetails()
        {
            LoadSculptureForm(this);
        }

        public Single Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Material
        {
            get { return _Material; }
            set { _Material = value; }
        }
    }
}

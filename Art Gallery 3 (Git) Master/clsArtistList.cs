using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Version_3_C
{
    [Serializable()]
    public class clsArtistList : SortedDictionary<string, clsArtist>
    {
        private const string _FileName = "gallery.dat";
        private string _GalleryName;

        public void NewArtist(clsArtist prArtist)
        {
            if (!string.IsNullOrEmpty(prArtist.Name))
            {
                Add(prArtist.Name, prArtist);
            }
            else
                throw new Exception("No artist name entered");
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }

        public string GalleryName
        {
            get { return _GalleryName; }
            set { _GalleryName = value; }
        }
 
        public static clsArtistList RetrieveArtistList()
        {
            clsArtistList lcArtistList;
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            }
            catch (Exception ex)
            {
                lcArtistList = new clsArtistList();
                throw new Exception("File Retrieve Error: " + ex.Message);
            }
            return lcArtistList;
        }

        public void Save()
        {
            System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
            BinaryFormatter lcFormatter = new BinaryFormatter();
            lcFormatter.Serialize(lcFileStream, this);
            lcFileStream.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class Tour
    {
        private string name;
        private string dateAndTime;
        private List<string> gallery;
        //private List<Review> reviews;
        private double price;
        private string tourID;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }//TODO: add validation
        }
        public List<string> Gallery
        {
            get { return gallery; }
            //set not needed as the edit/append methods of List are used
            //aka the List's contained items can be deleted but the List itself should not be replaced
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string TourID
        {
            get { return tourID; }
            set { tourID = value; }//TODO: add validation
        }
        public string getDetails()
        {
            return string.Format("{0}\t{1}\t{2}",
                Name,
                DateAndTime,
                Price);
        }

        //override generic Object method Equals
        public bool Equals(Tour tour)
        {
            return tour.TourID.Equals(this.TourID);
        }
    }
}

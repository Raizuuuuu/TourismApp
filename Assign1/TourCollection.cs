using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    class TourCollection : ICollection<Tour> //built in class, declare contain type in the <tour>
    {
        private ArrayList data;
        private bool locked;
        public TourCollection()
        {
            data = new ArrayList();
            locked = false; //if lockState is not given assume editable
        }
        public TourCollection(bool lockState) //overloaded constructor
        {
            data = new ArrayList();
            locked = lockState;
        }
        public ArrayList TourList
        {
            get { return data; }
        }
        public string getTour(string name)
        {
            Tour currentTour;
            for (int i = 0; i < data.Count; i++) //iterate through tours
            {
                currentTour = (Tour)data[i];// cast -> same as (int)double 
                //data[i] is treated a generic object

                if (currentTour.Name.Equals(name))
                    return currentTour.getDetails();
            }
            return "Not Found";
        }

        public virtual Tour this[int index] //TourCollection[1] = (tour)data[1]
        {
            get { return (Tour)data[index]; }
            set { data[index] = value; }
        }

        //compulsory interface implementations
        public virtual void Add(Tour newTour)
        {
            if (this.Contains(newTour))
                throw new InvalidOperationException("Duplicate TourID present");
            else
            {
                data.Add(newTour);
            }
        }
        public virtual bool Remove(Tour tour)
        {
            if (!this.Contains(tour))//doesnt contain
                return false; //return false if failed to remove
            else
            {
                foreach (Tour t in this) //current TourCollection Object
                {
                    if (t.Equals(tour))
                    {
                        data.Remove(t);
                        return true;
                    }
                    //"Remove" method built into ArrayList only handles if object is perfectly identical
                    //Thus an if statement is required to use the manually defined Equals method in Tour
                }
                return false;
            }
        }
        public virtual bool Contains(Tour tour)
        {
            foreach (Tour t in this)
            {
                if (t.Equals(tour))
                    return true;
            }
            return false;
        }
        public virtual void Clear()
        {
            data = new ArrayList();//reset arraylist
        }
        public virtual void CopyTo(Tour[] newTourArray, int index)
        {
            if (Count > newTourArray.Length - index)
                throw new ArgumentException("The number of elements in this collection is greater than" +
                    " the available space in the destination array.");
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    newTourArray[index++] = this[i];
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Tour> GetEnumerator() //IEnumerator<Tour> is the return type
        {
            foreach (Tour t in this)
                yield return t; //return values grouped together
        }
        public virtual int Count
        {
            get { return data.Count; }
        }
        public virtual bool IsReadOnly
        {
            get { return locked; }
            set
            {
                if (locked) //prevent changing back to editable after payment completed
                    throw new InvalidOperationException("This Collection is Read Only"); //Crash and out pops the error message
                else
                    locked = value;
            }
        }
    }
}

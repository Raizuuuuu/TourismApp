using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assign1
{
    class FileIO
    {
        //class for file read/write.
        //If functionality is already present in other classes, feel free to delete
        private static string[][] split(string path)
        {
            string line;
            List<string> entry = new List<string>();
            List<string[]> entryList = new List<string[]>();
            bool openBracket = false;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if ((openBracket && line.Equals("{")) || (!openBracket && line.Equals("}")))
                        throw new InvalidDataException("Invalid file data: unexpected entry open or close");
                    else
                    {
                        if (line.Equals("{"))
                            openBracket = true;
                        else if (line.Equals("}"))
                        {
                            openBracket = false;
                            entryList.Add(entry.ToArray());
                            entry = new List<string>();
                        }
                        else
                        {
                            entry.Add(line);
                        }
                    }
                }
            }

            return entryList.ToArray();
        }

        /*
         * EXAMPLE CODE
         * public static readTour(string path){
         *      string[][] tourList = split(path);
         *      TourCollection shitzu = new TourCollection();
         *      foreach(string[] t in tourList) {
         *          shitzu.Add(new Tour(
         *              t[0], //title
         *              t[1], //price
         *              t[2] //whatever shit property
         *          ));
         *      }
         * }
         */
    }
}

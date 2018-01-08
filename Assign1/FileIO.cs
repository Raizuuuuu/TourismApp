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
                        else if (line.Trim(new char[2] { '\n',' ' }).Equals(string.Empty))
                        {
                            continue; //skip empty lines
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
         *      string[][] tourList = split(path); //use the private method internally here
         *      TourCollection shitzu = new TourCollection();
         *      foreach(string[] t in tourList) {
         *          shitzu.Add(new Tour(
         *              t[0], //title
         *              t[1], //price
         *              t[2] //whatever property
         *          ));
         *      }
         * }
         */

        private static bool save(string[] data, string path)
        {
            //NOTICE: this method handles only one entry (containing a group of fields) at a time
            string[] output = new string[data.Length + 2];
            output[0] = "{"; //opening character
            if (data.Length > 0)
            {
                for(int i = 0; i < data.Length; i++)
                {
                    if (data[i].Contains("\n"))
                        return false;
                    //reject fields containing newlines as they interfere with file formatting
                    else
                        output[i+1] = data[i];
                }
                output[data.Length + 1] = "}"; //closing character

                using (var writer = new StreamWriter(path, true)) //append mode active
                {
                    foreach (string line in output)
                        writer.WriteLine(line);
                }
                return true; //successful write
            }
            else
                return false; //reject empty 
        }
    }
}

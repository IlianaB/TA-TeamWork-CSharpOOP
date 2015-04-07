namespace Library
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class DataManager
    {
        public List<string> ReadProfiles()
        {
            using (StreamReader reader = new StreamReader(@"..\Database\Users\Profiles.txt"))
            {
                string line = reader.ReadLine();
                List<string> allLines = new List<string>();

                StringBuilder result = new StringBuilder();

                while (line != null)
                {
                    allLines.Add(line);
                }

                return allLines;
            }
        }

        public List<string> ReadReadables()
        {
            using (StreamReader reader = new StreamReader(@"..\Database\Books\Readables.txt"))
            {
                string line = reader.ReadLine();
                List<string> allLines = new List<string>();

                StringBuilder result = new StringBuilder();

                while (line != null)
                {
                    allLines.Add(line);
                }

                return allLines;
            }
        }

    }
}

using System;


namespace ContactsSync.wwwroot.lib
{
    public class ReadFromCSV
    {
        //IMPORT list of contacts from CSV file
        private static void GetDataFromFile()
        {
            //there are issues currently with the CSV file, that a few of the fields have hard returns in them, causing a new line in the sr.ReadLine() method. I have removed them from the sample data for ease of use in development, will need to work around that in the future.
            FileStream fs = new FileStream("C:/Users/Kcils/Desktop/ContactsSync/ContactsSync/ContactsSync/wwwroot/dataFile.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            var temp = sr.ReadLine();

            while (sr.Peek() >= 0)
            {
            }
        }

        private static void processHeaderValues(string st)
        {
            var split = st.Split(",");
        }
    }
}

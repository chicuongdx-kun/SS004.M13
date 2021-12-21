using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Newtonsoft.Json;
using System.IO;


namespace SnakeGame
{
    class DataScore
    {
        public static int score;
        public static int HighScore;

        public static string curName;

        public static DataTable DataSet;

        public static DataTable CreateData()
        {
            DataTable result = new DataTable();
            result.Columns.Add("Name", typeof(string));
            result.Columns.Add("Score", typeof(int));

            string pathFile = Application.StartupPath + "\\Data.txt";

            foreach (string str in File.ReadAllLines(pathFile))
            {
                JsonReader user = JsonConvert.DeserializeObject<JsonReader>(str);
                result.Rows.Add(user.name, user.score);
            }

            return result;
        }

        public static void Save()
        {
            string pathFile = Application.StartupPath + "\\Data.txt";

            using (StreamWriter sr = new StreamWriter(pathFile))
            {
                foreach (DataRow row in DataSet.Rows)
                {
                    string data = "{\"name\": \"" + row["Name"].ToString() + "\", \"score\": \"" + Convert.ToInt32(row["Score"]) + "\"}";
                    sr.WriteLine(data);
                }
            }
        }
    }
}

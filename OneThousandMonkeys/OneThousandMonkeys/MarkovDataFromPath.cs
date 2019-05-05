using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OneThousandMonkeys
{
    class MarkovDataFromPath
    {
        private List<string> lines = new List<string>();
        private Random readit = new Random();
        private bool firstread = true;
        private Random linernd = new Random();
        public MarkovDataFromPath(string ThePath)
        {

            string[] filePaths = Directory.GetFiles(ThePath, "*.txt");

            Random rand = new Random();

            // For each spot in the array, pick
            // a random item to swap into that spot.
            for (int i = 0; i < filePaths.Length - 1; i++)
            {
                int j = rand.Next(i, filePaths.Length);
                string temp = filePaths[i];
                filePaths[i] = filePaths[j];
                filePaths[j] = temp;
            }
        

            for (int i = 0; i < filePaths.Length; i++)
            {
                int r = readit.Next(1, 5);
                if (r > 2 || firstread)
                {
                    firstread = false;
                    string[] file_lines = File.ReadAllLines(filePaths[i], Encoding.UTF8);
                    for (int k = 0; k < file_lines.Length; k++)
                    {
                        int maxLines = 5;
                        
                        if (lines.Count < 25) maxLines = 0;
                        if (lines.Count > 50) maxLines = 2;
                        if (lines.Count > 200) maxLines = 6;
                        if (lines.Count > 600) maxLines = 8;
                        if (lines.Count > 800) maxLines = 9;
                        if (lines.Count > 1000) maxLines = 10;
                        if (i > 1) maxLines = 9;
                        if (i > 2) maxLines = 8;
                        if (i == 3) maxLines = 7;
                        int p = linernd.Next(1, 10);
                        if (p > maxLines || lines.Count < 25) lines.Add(file_lines[k].Trim());
                  
                    }
                }
            }
        }
        public string[] GetLines()
        {
            return lines.ToArray();
        }
    }
}

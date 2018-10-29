using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPEdit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
            StreamReader reader = new StreamReader(@"C:\Users\John G Settineri\Documents\MVPedit\database\attrib.dat");
            string strAllFile = reader.ReadToEnd().Replace("\r\n", "\n").Replace("\n\r", "\n");
            string[] arrLines = strAllFile.Split(new char[] { '\n' });
            List<String> lines = new List<String>();
            int i = 0;
            foreach(var line in arrLines)
            {
                i++;
                try
                {
                    var split = line.Split(',');
                    lines.Add(split.);
                }
                catch(IndexOutOfRangeException ie)
                {

                }
            }
            
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}

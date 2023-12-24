using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class Info
    {
        public static void Log(string log)
        {
            string l = "Log_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".txt";
            string h = DateTime.Now.ToShortTimeString() + " - " + log + "\n";
            try
            {
                using (System.IO.StreamWriter write = new System.IO.StreamWriter(l, true))
                {
                    write.WriteLine(h);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! No se pudo crear el log: " + ex.Message);
            }
        }
    }
}

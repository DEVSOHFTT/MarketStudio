using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class MacAddress
    {
        public MacAddress()
        {

        }
        public string GetMacAddress()
        {
            string adress = string.Empty;
            ArrayList macAdress = new ArrayList();
            NetworkInterface[] adapter = null;
            try
            {
                adapter = NetworkInterface.GetAllNetworkInterfaces();
                if (adapter != null && adapter.Length > 0)
                {
                    foreach (NetworkInterface a in adapter)
                    {
                        var direction = a.GetPhysicalAddress();
                        byte[] bytes = direction.GetAddressBytes();
                        string mac = string.Empty;
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            mac += bytes[i].ToString("x2");
                            if (i != bytes.Length - 1)
                                mac += "-";
                        }

                        macAdress.Add( mac != "" ? "[" + mac + "]" : "");
                    }
                }
            }
            catch
            {
                adress = "S/D";
            }

            foreach (var m in macAdress)
                adress += m;

            return adress;
        }
    }
}

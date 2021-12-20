using ServiceReservasi_039;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server_Reservasi_039
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Service1));
                hostObj.Open();
                Console.WriteLine("Server is Readyyyyy!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}

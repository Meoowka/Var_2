using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Var_2_sp_ServiceHost
{
    internal class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Var_2_sp.Var_2_sp)))
            {
                host.Open();
                Console.WriteLine("Host Started @" + DateTime.Now.ToString());
                Console.ReadLine();
                host.Close();
            }

        }
    }
}

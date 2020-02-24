using System;
using System.Linq;

namespace FacturaCSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FacturaTestService.ServerService fs = new FacturaCSharpClient.FacturaTestService.ServerService();
            var response = fs.login("******", "************");
            fs.setKunde(null, true);
        }
    }
}
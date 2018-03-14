using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02.Sample01
{
    class ClientResponseNoFormat : IClientResponse
    {
        public IClientResponse ChainClientResponse { get; set; }

        public string ProcessResponse(ClientRequestFormat clientRequestFormat)
        {
            return "NOFORMAT DEFINED";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02.Sample01
{
    public class ClientResponseXML : IClientResponse
    {
        public IClientResponse ChainClientResponse{ get; set; }

        public string ProcessResponse(ClientRequestFormat clientRequestFormat)
        {
            if (clientRequestFormat == ClientRequestFormat.XML)
            {
                return "XML";
            }

            return ChainClientResponse.ProcessResponse(clientRequestFormat);
        }
    }
}

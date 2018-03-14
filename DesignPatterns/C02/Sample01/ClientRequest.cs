using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02.Sample01
{
    public class ClientRequest
    {
        public ClientRequestFormat ClientRequestFormat { get; private set; }

        public ClientRequest(ClientRequestFormat clientRequestFormat)
        {
            ClientRequestFormat = clientRequestFormat;
        }

        public string ProcessRequest(BankAccount bankAccount)
        {
            var clientResponseCSV = new ClientResponseCSV();
            var clientResponseXML = new ClientResponseXML();
            var clientResponsePercent = new ClientResponsePercent();
            var clientResponseNoFormat = new ClientResponseNoFormat();

            clientResponseCSV.ChainClientResponse = clientResponseXML;
            clientResponseXML.ChainClientResponse = clientResponsePercent;
            clientResponsePercent.ChainClientResponse = clientResponseNoFormat;

            var processedResponse = clientResponseCSV.ProcessResponse(ClientRequestFormat);

            return processedResponse;

        }
    }
}

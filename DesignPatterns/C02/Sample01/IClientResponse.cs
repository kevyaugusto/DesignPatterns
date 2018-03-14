using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.C02.Sample01
{
    public interface IClientResponse
    {
        IClientResponse ChainClientResponse { get; set; }
        string ProcessResponse(ClientRequestFormat clientRequestFormat);
    }
}

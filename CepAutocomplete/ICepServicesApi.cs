using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CepAutocomplete
{
    public interface ICepServicesApi
    {
        [Get("/ws/{cep}/json/")]
        Task<ClientAddress> GetAddressAsync(string cep);
    }
}

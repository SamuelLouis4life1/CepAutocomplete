using Refit;
using System;
using System.Threading.Tasks;

namespace CepAutocomplete
{
    class Program
    {
        static async Task Main(string[] args)
        {

            try
            {
                var cepClient = RestService.For<ICepServicesApi>("https://viacep.com.br");
                Console.WriteLine("Cep...: ");

                string informedCep = Console.ReadLine().ToString();
                Console.WriteLine("Consulting your CEP : " + informedCep);

                var clientAddress = await cepClient.GetAddressAsync(informedCep);

                Console.Write($"\nLogradouro: {clientAddress.logradouro} \nComplemento: {clientAddress.complemento} \nBairro: {clientAddress.bairro} \nCidade: {clientAddress.localidade} \nIBGE: {clientAddress.ibge} \nDDD:{clientAddress.ddd}  \nComplemento: {clientAddress.uf} \nGia: {clientAddress.Gia}");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro while culsuting the CEP: " + ex.Message);
            }
        }
    }
}



// < script type = "text/javascript" >
//                            $("#cep").focusout(function() {
//                                $.ajax({
//    url: 'https://viacep.com.br/ws/' + $(this).val() + '/json/unicode/',
//                                    dataType: 'json',
//                                    success: function(resposta) {
//                                        $("#logradouro").val(resposta.logradouro);
//                                        $("#complemento").val(resposta.complemento);
//                                        $("#bairro").val(resposta.bairro);
//                                        $("#cidade").val(resposta.localidade);
//                                        $("#uf").val(resposta.uf);
//                                        $("#numero").focus();
//        }
//    });
//});
                       
//</ script >
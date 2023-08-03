using AppBancoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        /**
         * Realiza o login do correntista.
         */
        public static async Task<Correntista> LoginAsync(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/entrar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

        //Envia um Model em forma de JSON pra insert no banco.
        public static async Task<Correntista> CadastrarCorrentistas(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("DADOS QUE FORAM DIGITADOS PELO USUÁRIOS E JÁ CONVERTIDOS EM JSON: ");
            Console.WriteLine(json_a_enviar);
            Console.WriteLine("__________________________________________________________________");

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/save");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }
    }

   
}

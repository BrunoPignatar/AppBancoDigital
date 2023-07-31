using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using AppBancoDigital.Model;
using System.Threading.Tasks;

namespace AppBancoDigital.Service
{
    public class DataServicePix : DataService
    {
        //ENVIAR PIX

        /** public static async Task<Transacao> EnviarAsync(Transacao t)
         {
             var json_a_enviar = JsonConvert.SerializeObject(t);

             string json = await DataService.PostDataToService(json_a_enviar, "/pix/enviar");

             return JsonConvert.DeserializeObject<Transacao>(json);
       
         } */

        //RECEBER PIX

        /** public static async Task<Transacao> ReceberAsync(Transacao t)
        {
            var json_a_enviar = JsonConvert.SerializeObject(t);

            string json = await DataService.PostDataToService(json_a_enviar, "/pix/receber");

            return JsonConvert.DeserializeObject<Transacao>(json);
        }*/
    }
}

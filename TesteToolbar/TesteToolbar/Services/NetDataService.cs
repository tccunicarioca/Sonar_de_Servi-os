using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TesteToolbar.Entidades;

namespace TesteToolbar.Services
{
    public class NetDataService
    {
        HttpClient cliente = new HttpClient();

        public async Task<List<Usuario>> GetListUsuario()
        {
            try
            {
                string url = "http://sonardeservicos.azurewebsites.net";
                var response = await cliente.GetStringAsync(url);
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(response);
                return usuarios;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddUsuario(Usuario usuario)
        {
            try
            {
                string url = "http://sonardeservicos.azurewebsites.net";
                var uri = new Uri(string.Format(url, usuario.Id));

                var data = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(data, Encoding.UTF8);

                HttpRequestMessage response = null;

                /*response = await cliente.PostAsync(uri, content);
                if (!response.IsSucessStatusCode)*/
                {
                    throw new Exception("Erro ao incluir o cliente");
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    internal class FuncionarioService
    {
        public async Task<IEnumerable<Funcionario>?> Integracao()
        {
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync($"http://desenv-suins/ApiConsultasRh/ListaFuncionarios");
            var jsonString = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<IEnumerable<Funcionario>>(jsonString);

            if (jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
                return null;
            }
          
        }
    }
}

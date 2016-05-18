using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class GitHubRepositories
    {
        // Método assincrono para retornar a relação de repositórios no 
        // GitHub de um determinado usuário.
        public async Task<List<string>> GetRepositories(string usuario)
        {
            var repositories = new List<string>();

            string url = "https://api.github.com/users/" + usuario + "/repos";
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Other");
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonRepositories = JArray.Parse(await response.Content.ReadAsStringAsync());
                repositories.Add("RELAÇÃO DE PROJETOS");
                repositories.Add("===================");

                foreach (var repository in jsonRepositories)
                {
                    repositories.Add(
                        repository.Value<string>("name") + " - " +
                        repository.Value<string>("language"));
                }

            }else
            {
                repositories.Add("Não foram encontrado projetos");
            }


            return repositories;
        }
    }
}

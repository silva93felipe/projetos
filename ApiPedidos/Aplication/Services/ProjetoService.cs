using ApiPedidos.Contratos;
using ApiPedidos.Dto;

namespace ApiPedidos.Service
{
    public class ProjetoService : IProjetoService{
        private readonly string baseUrl = "http://localhost:5276/Projeto";
        public async void GetAll(){
            using var httpClient = new HttpClient();
            var result = await httpClient.GetAsync(baseUrl);
            Console.WriteLine(result.Content);
            if(result.IsSuccessStatusCode){
                var json = await result.Content.ReadFromJsonAsync<ProjetoDto>();
            }
        }
    }
}
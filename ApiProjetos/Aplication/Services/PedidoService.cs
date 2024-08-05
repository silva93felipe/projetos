using System.Net;
using ApiProjetos.Contratos;
using ApiProjetos.Dto;
using ApiProjetos.Models;
using Newtonsoft.Json;
namespace ApiProjetos.Services
{
    public class PedidoService : IPedidoService{
        private readonly string _baseUrl = "http://localhost:5139/Pedido/";
        public async Task<IEnumerable<PedidoDto>> GetAll(){
            using var httpClient = new HttpClient();
            var result = await httpClient.GetAsync(_baseUrl);
            Console.WriteLine(result.Content);
            if(result.IsSuccessStatusCode){
                return await result.Content.ReadFromJsonAsync<IEnumerable<PedidoDto>>();
            }else 
                return Enumerable.Empty<PedidoDto>();
        }

        public async Task<IEnumerable<PedidoDto>> GetAllByProjetoId(int projetoId)
        {
            using var httpClient = new HttpClient();
            var result = await httpClient.GetAsync(_baseUrl);
            if(result.IsSuccessStatusCode){
                return await result.Content.ReadFromJsonAsync<IEnumerable<PedidoDto>>();
            }
            return Enumerable.Empty<PedidoDto>();
        }
    }
}
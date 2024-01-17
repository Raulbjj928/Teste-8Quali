using Test8Quali.Models;

namespace Test8Quali.Servicos.Interfaces
{
    public interface IClienteService
    {
        ClienteModel Add(ClienteModel cliente);
        List<ClienteModel> GetAll();
        ClienteModel GetById(int id);
        ClienteModel Update(ClienteModel cliente);
        bool Delete(int id);
    }
}

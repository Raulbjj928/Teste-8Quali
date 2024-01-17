using Test8Quali.Models;
using Test8Quali.Servicos.Interfaces;

namespace Test8Quali.Servicos
{
    public class ClienteService : IClienteService
    {
        private static int id = 2;

        private static List<ClienteModel> _clientes = new List<ClienteModel>()
        {
            new ClienteModel
            {
                Id = 1,
                Nome = "Cleber",
                Empresa = "8Quali",
                EmailPricipal = "cleber@8quali.com",
                Email2 = "cleber@8qualidade.com",
                Email3 = "cleber.quali@8quali.com",
                Email4 = "cleber_dev@8quali.com",
                TelC = "4733668899",
                TelP = "4733668899"
            },
            new ClienteModel
            {
                
                Id = 2,
                Nome = "Raul Henrique Furtado",
                Empresa = "8Quali",
                EmailPricipal = "raul.rhf9316@gmail.com",
                Email2 = "raul@8qualidade.com",
                Email3 = "raul.quali@8quali.com",
                Email4 = "raul_dev@8quali.com", 
                TelC = "4733668899",
                TelP = "4733668899"
            }
        };

        public ClienteModel Add(ClienteModel cliente)
        {
            id++;
            cliente.Id = id;
            _clientes.Add(cliente);
            return cliente;
        }
        
        public List<ClienteModel> GetAll()
        {
            return _clientes;
        }

        public ClienteModel GetById(int id)
        {
            var cliente = _clientes.FirstOrDefault(x => x.Id == id);

            return cliente;
        }

        public ClienteModel Update(ClienteModel cliente)
        {
            var clienteDBLocal = GetById(cliente.Id);

            clienteDBLocal.Id = cliente.Id;
            clienteDBLocal.Nome = cliente.Nome;
            clienteDBLocal.Empresa = cliente.Empresa;
            clienteDBLocal.EmailPricipal= cliente.EmailPricipal;
            clienteDBLocal.Email2 = cliente.Email2;
            clienteDBLocal.Email3 = cliente.Email3;
            clienteDBLocal.Email4 = cliente.Email4;
            clienteDBLocal.TelP = cliente.TelP;
            clienteDBLocal.TelC = cliente.TelC;

            return clienteDBLocal;
        }
        
        public bool Delete(int id)
        {
            var cliente = GetById(id);

            _clientes.Remove(cliente);

            return true;
        }


    }
}

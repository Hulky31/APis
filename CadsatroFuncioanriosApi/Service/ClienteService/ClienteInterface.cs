using CadsatroFuncioanriosApi.Model;

namespace CadsatroFuncioanriosApi.Service.ClienteService
{
    public interface IClienteInterface
    {
        Task<ServiceResponse<List<ClienteModel>>> GetCliente();

        Task<ServiceResponse<List<ClienteModel>>> CreateCliente(ClienteModel novoCliente);

        Task<ServiceResponse<ClienteModel>> GetClienteById(int Id);

        Task<ServiceResponse<List<ClienteModel>>>UpdateCliente(ClienteModel clienteModel);

        Task<ServiceResponse<List<ClienteModel>>> DeleteCliente(int Id);

    }
}

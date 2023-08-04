using CadsatroFuncioanriosApi.Data;
using CadsatroFuncioanriosApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CadsatroFuncioanriosApi.Service.ClienteService
{
    public class ClienteService : IClienteInterface
    {
        private readonly ApplicationDbContext _context;
        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<ClienteModel>>> CreateCliente(ClienteModel novoCliente)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();
            try
            {
                if (novoCliente == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar dados";
                    serviceResponse.Sucesso = false;
                }
                _context.Add(novoCliente);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.CompreBem.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;

            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<ClienteModel>>> DeleteCliente(int Id)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>> ();
            try
            {
                ClienteModel cliente = _context.CompreBem.FirstOrDefault(x => x.Id == Id);

                if (cliente == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Cliente não encontrado";
                    serviceResponse.Sucesso = false;
                }

                _context.CompreBem.Remove(cliente);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.CompreBem.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;              
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<ClienteModel>>> GetCliente()
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();
            try
            {
                serviceResponse.Dados = _context.CompreBem.ToList();
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "nenhum dados encontrado";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
                
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<ClienteModel>> GetClienteById(int Id)
        {
            ServiceResponse<ClienteModel> serviceResponse = new ServiceResponse<ClienteModel>();
            try
            {
                ClienteModel clienteModel = _context.CompreBem.FirstOrDefault(x => x.Id == Id);

                if (clienteModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário não localizado";
                    serviceResponse.Sucesso = false;
                }

                serviceResponse.Dados = clienteModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<ClienteModel>>> UpdateCliente(ClienteModel clienteEditado)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();
            try
            {
                ClienteModel clienteModel = _context.CompreBem.AsNoTracking().FirstOrDefault(x => x.Id == clienteEditado.Id);
                
                if (clienteModel == null)

                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário não localizado";
                    serviceResponse.Sucesso = false;
                }

                _context.CompreBem.Update(clienteEditado);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.CompreBem.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }

            return serviceResponse;

            
        }
       
    }
}

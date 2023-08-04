using CadsatroFuncioanriosApi.Model;
using CadsatroFuncioanriosApi.Service.ClienteService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadsatroFuncioanriosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteInterface _clienteInterface;
        public ClienteController(IClienteInterface clienteInterface) 
        {
            _clienteInterface = clienteInterface;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ClienteModel>>>> GetCliente()
        {
            return Ok(await _clienteInterface.GetCliente());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<ClienteModel>>>> CreateCliente(ClienteModel clienteModel)
        {
            return Ok(await _clienteInterface.CreateCliente(clienteModel));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceResponse<ClienteModel>>> GetClienteById(int Id)
        {
            ServiceResponse<ClienteModel> serviceResponse = await _clienteInterface.GetClienteById(Id);
            return Ok(serviceResponse);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<ClienteModel>>>> UpdateCliente(ClienteModel clienteEditado)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = await _clienteInterface.UpdateCliente(clienteEditado);

            return Ok(serviceResponse);
        }
        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<ClienteModel>>>> DeleteCliente(int Id)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = await _clienteInterface.DeleteCliente(Id);
            return Ok(serviceResponse);
        }

    }
}

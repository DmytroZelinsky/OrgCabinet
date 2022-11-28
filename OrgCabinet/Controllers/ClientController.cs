using BLL.Services.Abstraction;
using EntityLayer.Entities.User;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrgCabinet.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientsController : ControllerBase
	{
		private readonly IClientsService _clientsService;

		public ClientsController(IClientsService clientsService)
		{
			_clientsService = clientsService;
		}

		[HttpGet]
		public IEnumerable<Client> Get()
		{
			return _clientsService.GetClients();
		}

		[HttpGet("{id}")]
		public Client Get(int id)
		{
			return _clientsService.GetClient(id);
		}

		[HttpPost]
		public void Post([FromBody] Client client)
		{
			_clientsService.CreateClient(client);
		}
	}
}

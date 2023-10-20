namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class Client : ControllerBase
    {
        private readonly IClientService clientService;

        public Client(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpPost]
        public async Task<ActionResult<Client>> Post([FromBody] ClientDto client)
        {

            var includeClient = await clientService.Create(client);

            return Ok(includeClient);
        }
    }
}
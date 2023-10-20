
using AutoMapper;

public class ClientService : IClientService
{
    private readonly IClientRepository clientRepository;
    private readonly IMapper mapper;
    public ClientService(IClientRepository clientRepository, IMapper mapper){
        this.clientRepository = clientRepository; 
        this.mapper = mapper;
    }
    public async Task<Client> Create(ClientDto clientDto)
    {
        var client = mapper.Map<Client>(clientDto);
        var clientIncluded = await clientRepository.Create(client);
        return clientIncluded;
    }
}

public class ClientRepository : IClientRepository
{
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Client> Create(Client client)
    {
       var newClient = await _context.Clients.AddAsync(client);
       await _context.SaveChangesAsync();
       return client;
    }
}
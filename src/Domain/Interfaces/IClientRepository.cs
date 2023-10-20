public interface IClientRepository
{
    public Task<Client> Create(Client client);
}
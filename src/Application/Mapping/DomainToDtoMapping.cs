using AutoMapper;
public class DomainToDtoMapping : Profile
{
    public DomainToDtoMapping()
    {
        CreateMap<Client, ClientDto>().ReverseMap();
    }
}
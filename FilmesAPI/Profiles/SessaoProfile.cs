using AutoMapper;
using FilmesAPI.Models;
using FilmesAPI.Data.Dtos;

public class SessaoProfile : Profile
{
    public SessaoProfile()
    {
        CreateMap<Sessao, ReadSessaoDto>();
        CreateMap<Sessao, ReadDetailedSessaoDto>()
            .ForMember(dto => dto.TituloFilme, opt => opt.MapFrom(src => src.Filme.Titulo))
            .ForMember(dto => dto.DiretorFilme, opt => opt.MapFrom(src => src.Filme.Diretor))
            .ForMember(dto => dto.NomeCinema, opt => opt.MapFrom(src => src.Cinema.Nome));
    }
}

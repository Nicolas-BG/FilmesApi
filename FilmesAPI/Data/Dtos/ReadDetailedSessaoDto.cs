namespace FilmesAPI.Data.Dtos
{
    public class ReadDetailedSessaoDto
    {
        public int FilmeId { get; set; }

        // Informações adicionais do filme
        
        public string TituloFilme { get; set; }
        public string DiretorFilme { get; set; }
        
        public int CinemaId { get; set; }

        // Informação adicional do cinema
        
        public string NomeCinema { get; set; }
        

    }
}

using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required (ErrorMessage = "O Título do filme é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O tamanho do filme não pode ter mais de 50 caracteres.")]

    public string Titulo { get; set; }

    [Required (ErrorMessage = "O Genêro do filme é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode ter mais de 50 caracteres.")]
    public  string Genero { get; set; }

    
    [MaxLength(50, ErrorMessage = "O tamanho do nome do Diretor não pode ter mais de 50 caracteres.")]
    public string? Diretor { get; set; }

    [Required (ErrorMessage = "A duração do filme é obrigatória.")]
    [Range(70, 600, ErrorMessage = "A duração do filme deve estar entre 70 e 600 minutos.")]
    public int Duracao { get; set; }

    [Key]
    [Required]
    public int Id { get; set; }
    public virtual ICollection<Sessao> Sessoes { get; set; }
}

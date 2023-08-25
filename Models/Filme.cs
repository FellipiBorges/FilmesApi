using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "É obrigatorio preencher o título do filme para prosseguir")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "É obrigatorio preencher o gênero do filme para prosseguir")]
    [MaxLength(50, ErrorMessage ="Limite de caracteres excedidos")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "É obrigatorio preencher a duração do filme para prosseguir")]
    [Range(70,600, ErrorMessage ="A duração deve ter entre 70 a 600 minutos")]
    public int Duracao { get; set; }
}

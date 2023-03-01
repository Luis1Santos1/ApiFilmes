using System.ComponentModel.DataAnnotations;
namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]

    //data annotation
    public int Id { get; set; }
    [Required(ErrorMessage = "O título do filme é obrigatório")]     //data annotation
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]    //data annotation
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")] //data annotation
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatório")]    //data annotation
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")] //data annotation
    public int Duracao { get; set; }
    public virtual ICollection<Sessao> Sessoes { get; set; }

}

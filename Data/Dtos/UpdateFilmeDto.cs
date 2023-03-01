using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class UpdateFilmeDto
    {
        //data annotation
        [Required(ErrorMessage = "O título do filme é obrigatório")]     //data annotation
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]    //data annotation
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")] //data annotation
        public string Genero { get; set; }
        [Required]    //data annotation
        [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")] //data annotation
        public int Duracao { get; set; }
    }
}
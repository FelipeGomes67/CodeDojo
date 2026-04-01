using System.ComponentModel.DataAnnotations;

namespace APITarefa.DTO;

public class TarefaDTO
{
    [Required(ErrorMessage = "O título da tarefa é obrigatório.")]
    public string? Titulo { get; set; }
        [Required(ErrorMessage = "A descrição da tarefa é obrigatória.")]
        public string? Descricao { get; set; }
    [Required(ErrorMessage = "O status da tarefa é obrigatório.")]
    public bool Status { get; set; }

}

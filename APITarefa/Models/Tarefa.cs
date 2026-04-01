using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APITarefa.Models;

[Table("Tarefa")]
public partial class Tarefa
{
    [Key]
    public Guid IdTarefa { get; set; }

    [StringLength(255)]
    public string Titulo { get; set; } = null!;

    [Column(TypeName = "text")]
    public string Descricao { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime? Data { get; set; }
}

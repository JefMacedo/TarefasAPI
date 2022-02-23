using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasAPI.Data;

[Table("Tarefa")]
public record Tarefa(int Id, string Atividade, string Status);

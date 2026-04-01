using APITarefa.Models;

namespace APITarefa.Interface;

public interface ITarefaRepository
{
    void Cadastrar(Tarefa tarefa);
    void Deletar(Guid id);
    List<Tarefa> Listar();
    Tarefa BuscarPorId(Guid id);
    void Atualizar(Guid id, Tarefa tarefa);

}


using APITarefa.Interface;
using APITarefa.DbContextTarefa;
using APITarefa.Models;

namespace API_Tarefa.Repository;

public class TarefaRepository : ITarefaRepository
{
    private readonly TarefaContext _context;

    public TarefaRepository(TarefaContext context)
    {
        _context = context;
    }

    public void Atualizar(Guid id, Tarefa tarefa)
    {
        var tarefaBuscado = _context.Tarefas.Find(id);

        if (tarefa != null)
        {
            tarefaBuscado.Titulo = tarefa.Titulo!;

        }
        _context.SaveChanges();
    }

    public Tarefa BuscarPorId(Guid id)
    {
        return _context.Tarefas.Find(id)!;
    }

    public void Cadastrar(Tarefa tarefa)
    {
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }
    }

    public void Deletar(Guid id)
    {
        var tarefaBuscado = _context.Tarefas.Find(id);

        if (tarefaBuscado != null)
        {
            _context.Tarefas.Remove(tarefaBuscado);
            _context.SaveChanges();
        }
    }

    public List<Tarefa> Listar()
    {
        return _context.Tarefas.ToList();
    }

}
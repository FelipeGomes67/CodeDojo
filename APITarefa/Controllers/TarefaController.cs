using APITarefa.DTO;
using APITarefa.Interface;
using APITarefa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Tarefa.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : ControllerBase
{
    private readonly ITarefaRepository _tarefaRepository;

    public TarefaController(ITarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }
    [HttpGet]
    public IActionResult Listar()
    {
        try
        {
        return Ok(_tarefaRepository.Listar());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
     [HttpGet("{id}")]
     public IActionResult BuscarPorId(Guid id)
     {
         try
         {
             return Ok(_tarefaRepository.BuscarPorId(id));
         }
         catch (Exception e)
         {
             return BadRequest(e.Message);
         }
    }

    [HttpPost]
    public IActionResult Cadastrar(TarefaDTO tarefa)
    {
        try
        {
            var novaTarefa = new Tarefa
                {
                
                Titulo = tarefa.Titulo!,
                Descricao = tarefa.Descricao!,
                Status = tarefa.Status,
            };
            _tarefaRepository.Cadastrar(novaTarefa);
            return StatusCode(201, novaTarefa);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id}")]
    public IActionResult Atualizar(Guid id, TarefaDTO tarefa)
    {
        try
        {
            var tarefaAtualizada = new Tarefa
            {
                Titulo = tarefa.Titulo!,
                Descricao = tarefa.Descricao!,
                Status = tarefa.Status,
            };
            _tarefaRepository.Atualizar(id, tarefaAtualizada);
            return StatusCode(204, tarefaAtualizada);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(Guid id)
    {
        try
        {
            _tarefaRepository.Deletar(id);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}

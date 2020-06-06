using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers
{
  // api/commands
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    // private readonly MockCommanderRepo _repository = new MockCommanderRepo();
    // this will be replaced by below
    private readonly ICommanderRepo _repository;
    public CommandsController(ICommanderRepo repository)
    {
      _repository = repository;
    }

    // GET api/commands
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAppCommands();

      return Ok(commandItems);
    }

    // GET api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);
    }
  }
}
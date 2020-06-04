using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAppCommands()
    {
      // throw new System.NotImplementedException();
      var commands = new List<Command>
      {
        new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
        new Command { Id = 1, HowTo = "Buy a suit", Line = "Chanel", Platform = "White tweed" },
        new Command { Id = 2, HowTo = "Adopt a cat", Line = "Russian", Platform = "Blue" }
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      // throw new System.NotImplementedException();
      return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
    }
  }
}
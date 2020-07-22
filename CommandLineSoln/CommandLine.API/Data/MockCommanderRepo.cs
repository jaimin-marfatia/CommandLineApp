using CommandLine.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandLine.API.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Cooking" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get knife", Platform = "Chopping board" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag", Platform = "Kettle" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil Water", Platform = "Cooking" };
        }
    }
}

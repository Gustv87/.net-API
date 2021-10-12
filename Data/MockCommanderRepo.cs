using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CrateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public  IEnumerable<Command> GetAllCommands()
        {
             var commands = new List<Command>
            {
              new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kattle & Pan"},
              new Command{Id=1, HowTo="Cut bread", Line="Get a Knife", Platform="Knife & chopping board"},
              new Command{Id=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Kattle & Cup"}
            };
            return commands;
        }

        

      public  Command GetCommandById(int id)
        {
           return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kattle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
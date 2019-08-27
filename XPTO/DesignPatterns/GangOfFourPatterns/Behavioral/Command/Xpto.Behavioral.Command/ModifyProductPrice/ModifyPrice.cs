using System.Collections.Generic;

namespace Xpto.Behavioral.Command.ModifyProductPrice
{
    //Invoker class
    public class ModifyPrice
    {
        private readonly List<ICommand> _commands;       

        public ModifyPrice()
        {
            _commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command) => _commands.Add(command);

        public void Invoke()
        {
            _commands.ForEach(c => c.ExecuteAction());           
        }
    }
}

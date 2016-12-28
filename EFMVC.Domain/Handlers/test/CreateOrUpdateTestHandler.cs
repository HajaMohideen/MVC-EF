using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMVC.Domain.Commands;
using EFMVC.CommandProcessor.Command;


namespace EFMVC.Domain.Handlers
{
    public class CreateOrUpdateTestHandler : ICommandHandler<CreateOrUpdateTestCommand>
    {

        public ICommandResult Execute(CreateOrUpdateTestCommand command)
        {
            int id = command.ID;
            return new CommandResult(true);
        }


    }


}

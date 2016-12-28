using EFMVC.CommandProcessor.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMVC.Domain.Commands
{
    public class CreateOrUpdateTestCommand : ICommand
    {

        public CreateOrUpdateTestCommand(int id)
        {
            this.ID = id;
        }

        public int ID { get; set; }

    }
}

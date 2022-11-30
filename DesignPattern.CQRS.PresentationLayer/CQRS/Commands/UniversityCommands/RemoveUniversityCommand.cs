using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Commands.UniversityCommands
{
    public class RemoveUniversityCommand
    {
        public RemoveUniversityCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

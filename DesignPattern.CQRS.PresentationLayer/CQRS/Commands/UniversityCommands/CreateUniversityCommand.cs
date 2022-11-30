using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Commands.UniversityCommands
{
    public class CreateUniversityCommand
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands
{
    public class CreatePersonCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public DateTime StartWork { get; set; }
        public bool Status { get; set; }
        public decimal Salary { get; set; }
    }
}

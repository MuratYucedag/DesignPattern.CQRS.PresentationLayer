using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results.PersonResult
{
    public class GetPersonByIDQueryResult
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}

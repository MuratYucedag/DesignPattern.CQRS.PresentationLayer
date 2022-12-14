using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results.UniversityResult
{
    public class GetAllUniversityQueryResult
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Results.UniversityResult
{
    public class GetUniversityByIDQueryResult
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

    }
}

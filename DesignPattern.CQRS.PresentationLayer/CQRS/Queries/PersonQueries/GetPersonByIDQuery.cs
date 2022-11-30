using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Queries.PersonQueries
{
    public class GetPersonByIDQuery
    {
        public GetPersonByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

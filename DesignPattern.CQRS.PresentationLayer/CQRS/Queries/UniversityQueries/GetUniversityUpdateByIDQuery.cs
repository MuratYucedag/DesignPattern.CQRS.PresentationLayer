﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Queries.UniversityQueries
{
    public class GetUniversityUpdateByIDQuery
    {
        public GetUniversityUpdateByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

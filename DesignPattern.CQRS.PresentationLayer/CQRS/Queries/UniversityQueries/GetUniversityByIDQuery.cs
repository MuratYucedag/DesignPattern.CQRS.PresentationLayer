﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Queries.UniversityQueries
{
    public class GetUniversityByIDQuery
    {
        public GetUniversityByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}

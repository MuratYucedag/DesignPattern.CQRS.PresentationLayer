﻿using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.PersonHandlers;
using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.PersonQueries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.CQRS.PresentationLayer.Controllers
{
    public class PersonController : Controller
    {
        private readonly GetPersonHumanResourceQueryHandler _getPersonHumanResourceQueryHandler;
        private readonly GetPersonByIDQueryHandler _getPersonByIDQueryHandler;
        private readonly CreatePersonHandler _createPersonHandler;

        public PersonController(GetPersonHumanResourceQueryHandler getPersonHumanResourceQueryHandler, GetPersonByIDQueryHandler getPersonByIDQueryHandler, CreatePersonHandler createPersonHandler)
        {
            _getPersonHumanResourceQueryHandler = getPersonHumanResourceQueryHandler;
            _getPersonByIDQueryHandler = getPersonByIDQueryHandler;
            _createPersonHandler = createPersonHandler;
        }

        public IActionResult Index()
        {
            var values = _getPersonHumanResourceQueryHandler.Handle(new GetPersonHumanResourceQuery());
            return View(values);
        }

        public IActionResult GetPerson(int id)
        {
            var values = _getPersonByIDQueryHandler.Handle(new GetPersonByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(CreatePersonCommand command)
        {
            _createPersonHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}

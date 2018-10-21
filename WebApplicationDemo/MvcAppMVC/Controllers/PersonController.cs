using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcAppMVC.Models;
using Mvc.Business.Interface;
using StructureMap;

namespace MvcAppMVC.Controllers
{
    public class PersonController : ApiController
    {
        private readonly IStringGenerator _service;
        public PersonController(IStringGenerator service)
        {
            this._service = service;
        }

        public PersonController() : this(ObjectFactory.GetInstance<IStringGenerator>())
        {

        }

        [HttpPost]
        public PersonModel FormatPerson(PersonModel person)
        {
            person.FormattedString = this._service.Format(person.Number.ToString());
            return person;
        }
    }
}

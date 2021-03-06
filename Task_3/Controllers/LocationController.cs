﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Task_3.Services;

namespace Task_3.Controllers
{
    public class LocationController : ApiController
    {
        private readonly ILocationService _service;

        public LocationController(
            ILocationService service
        )
        {
            _service = service;
        }


        [HttpGet]
        [Route("api/location/{id}")]
        public IHttpActionResult GetLocationDetail(string id)
        {
            Dictionary<String, String> pathVariables = new Dictionary<string, string>();
            pathVariables.Add("id", id);
            var data = _service.GetData(null, pathVariables, null);
            return Ok(data);
        }
    }
}

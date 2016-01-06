﻿using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController
    {
        private readonly ICounterService _counterService;

        public ValuesController(ICounterService counterService)
        {
            _counterService = counterService;
        }

        [HttpGet]
        public Task<long> GetAsync()
        {
            return _counterService.GetCurrentAsync();
        }

        [HttpPost]
        public Task<long> PostAsync()
        {
            return _counterService.IncrementAsync();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace UnitTests.Acheve.TestHost.Builders
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController
        : ControllerBase
    {
        [HttpGet("{param1}/{param2}")]
        public IActionResult GuidSupport(string param1,Guid param2)
        {
            return Ok();
        }

        [HttpGet("{param_1:guid}/{param_2:int}")]
        public IActionResult UnderDashSupport(Guid param_1, int param_2)
        {
            return Ok();
        }
    }
}

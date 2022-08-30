using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domgames.Interfaces;
using domgames.Models;
using Microsoft.AspNetCore.Mvc;
using CodeWorks.Auth0Provider;
using domgames.Services;

namespace domgames.Controllers
{
    [ApiController]
    [Route("api/[controller]/{id}")]
    public class ProfilesController : ControllerBase
    {
        private readonly AccountService _as;

        public ProfilesController(AccountService aServ)
        {
            _as = aServ;
        }
        
        [HttpGet]
        public ActionResult
        
    }
}
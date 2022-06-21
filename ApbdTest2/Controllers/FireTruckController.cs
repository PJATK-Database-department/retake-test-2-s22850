using ApbdTest2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Controllers
{
    [ApiController]
    [Route("firetrucks")]
    public class FireTruckController : Controller
    {
        public IDbService _dbService;

        public FireTruckController(IDbService dbs)
        {
            _dbService = dbs;
        }

        [HttpGet("{idFireTruck}")]
        public ActionResult GetFireTruckWithActions([FromRoute] int idFiretruck)
        {

            if (!_dbService.DoesTruckExist(idFiretruck))
            {
                return NotFound(404);
            }

            var result = _dbService.GetFiretruck(idFiretruck);

            return Ok(200);
          

        }

    }
}

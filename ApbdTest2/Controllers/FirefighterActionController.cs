using ApbdTest2.Responses;
using ApbdTest2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Controllers
{
    [ApiController]
    [Route("actions")]
    public class FirefighterActionController : Controller
    {
        public IDbService _dbService;

        public FirefighterActionController(IDbService dbs)
        {
            _dbService = dbs;
        }


        [HttpPut("{idAction}")]
        public ActionResult UpdateAction([FromBody] UpdateActionRequest actionRequest)
        {
            if (!_dbService.DoesFirefightingActionExist(actionRequest.IdAction))
            {
                return NotFound(404);
            }

            if (!_dbService.IsEndDateSet(actionRequest.IdAction)) {
                return BadRequest("Given action has end date already set.");
            }

            if (!_dbService.IsNewDateNotEarlier(actionRequest.StartTime, actionRequest.IdAction)) {
                return BadRequest("Given new date is earlier than existing start date.");
            }

            var result = _dbService.UpdateAction(actionRequest);

            return Ok(200);

        }
    }
}

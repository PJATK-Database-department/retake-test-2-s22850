using ApbdTest2.Dto;
using ApbdTest2.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApbdTest2.Services
{
    public class DbService : IDbService
    {
        public AmContext _dbContext;

        public DbService(AmContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool DoesFirefightingActionExist(int idAction)
        {
            return _dbContext.Actions.Any(ff => ff.IdAction == idAction);
        }

        public bool DoesTruckExist(int idFireTruck)
        {
            return _dbContext.Firetrucks.Any(ft => ft.IdFiretruck == idFireTruck);
        }

        public bool DoesTruckHaveActions(int idFireTruck)
        {
            return _dbContext.Firetruck_Actions.Any(fta => fta.FiretruckNavigation == idFireTruck);
        }

        public GetFiretruckResponse GetFiretruck(int idFiretruck)
        {
            var ft = _dbContext.Firetrucks.Where(ft => ft.IdFiretruck == idFiretruck);

            return ft;
            
        }

        public bool IsEndDateSet(int idAction)
        {
            return _dbContext.Actions.Where(a=> a.IdAction == idAction).Any(a => a.EndTime != null);
        }

        public bool IsNewDateNotEarlier(DateTime newDate, int idAction)
        {
            return _dbContext.Actions.Where(a => a.IdAction == idAction).Any(a => a.StartTime > newDate);
        }

        public bool UpdateAction(UpdateActionRequest actionRequest)
        {
            _dbContext.Actions.Update();
            return true;
        }
    }
}

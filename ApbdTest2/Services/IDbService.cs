using ApbdTest2.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Services
{
    public interface IDbService
    {
        bool DoesTruckExist(int idFireTruck);
        bool DoesTruckHaveActions(int idFireTruck);
        bool DoesFirefightingActionExist(int idAction);
        bool IsEndDateSet(int idAction);
        bool IsNewDateNotEarlier(DateTime newDate, int idAction);

        GetFiretruckResponse GetFiretruck(int idFiretruck);
        bool UpdateAction(UpdateActionRequest actionRequest);



    }
}

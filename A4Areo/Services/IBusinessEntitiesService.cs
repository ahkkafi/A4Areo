using A4Areo.Areas.Admin.Models;
using A4Areo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4Areo.Services
{
    public interface IBusinessEntitiesService
    {
        void InsertOrUpdateAgent(BusinessEntityContainer obj);
        void UpdateAgent(BusinessEntityContainer obj);
        BusinessEntities GetAgentById(BusinessEntities obj);
        void DeleteAgent(BusinessEntities obj);
        List<BusinessEntities> GetAllAgents(AgentFilter obj);
    }
}

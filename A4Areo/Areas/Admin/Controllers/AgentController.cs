using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A4Areo.Areas.Admin.Models;
using A4Areo.Domain;
using A4Areo.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace A4Areo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AgentController : Controller
    {
        private IBusinessEntitiesService _businessEntitiesService;
        public AgentController(IBusinessEntitiesService businessEntitiesService)
        {
            _businessEntitiesService = businessEntitiesService;

        }
        public IActionResult CreateAgent()
        {
            return View();
        }

        [HttpPost]
        public string CreateAgent([FromBody] BusinessEntityContainer model)
        {
            _businessEntitiesService.InsertOrUpdateAgent(model);

            var data = new ResponseResult { Success = "success" };
            string response = JsonConvert.SerializeObject(data);
            return response;
        }

        [HttpGet]
        public IActionResult AgentList()
        {
            return View();
        }

        [HttpPost]
        public string LoadAgentList([FromBody] AgentFilter obj)
        {
           var data= _businessEntitiesService.GetAllAgents(obj);
            string response = JsonConvert.SerializeObject(data);
            return response;
        }

        [HttpPost]
        public string GetAgent([FromBody]  BusinessEntities obj)
        {
            var data = _businessEntitiesService.GetAgentById(obj);
            return JsonConvert.SerializeObject(data);
        }


        [HttpPost]
        public string DeleteAgent([FromBody]  BusinessEntities obj)
        {
            _businessEntitiesService.DeleteAgent(obj);

            var data = new ResponseResult { Success = "success" };
            string response = JsonConvert.SerializeObject(data);
            return response;
        }
    }
}
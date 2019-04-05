using A4Areo.Areas.Admin.Models;
using A4Areo.Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace A4Areo.Services
{
    public class BusinessEntitiesService: IBusinessEntitiesService
    {
        private readonly Repository<BusinessEntities> _repositoryBusinessEntities;
        private IHostingEnvironment _env;
        public BusinessEntitiesService(IHostingEnvironment env)
        {
            _repositoryBusinessEntities = new Repository<BusinessEntities>();
            _env = env;
        }

        protected string SaveData(byte[] Data)
        {
            var directory = $"images/{Guid.NewGuid()}.jpg";
            BinaryWriter Writer = null;
            var filePath = Path.Combine(_env.WebRootPath, directory);
            try
            {
                // Create a new stream to write to the file
                Writer = new BinaryWriter(File.OpenWrite(filePath));

                Writer.Write(Data);
                Writer.Flush();
                Writer.Close();
            }
            catch
            {
                return "";
            }

            return directory;
        }
        public void InsertOrUpdateAgent(BusinessEntityContainer obj)
        {
            if (!string.IsNullOrEmpty(obj.Logo))
            {
                var directory = $"images/{Guid.NewGuid()}.jpg";
                var t = obj.Logo.Split(new string[] { "base64," }, StringSplitOptions.None)[1];
                byte[] imageBytes = Convert.FromBase64String(t);
                 obj.Logo= SaveData(imageBytes);
            }

            if (obj.BusinessId > 0)
            {
                UpdateAgent(obj);
            }

            else
            {
                var businessEntities = obj.ConvertToBusinessEntities();
                businessEntities.CreatedOnUtc = DateTime.Now;
                businessEntities.UpdatedOnUtc = DateTime.Now;



                _repositoryBusinessEntities.Insert(businessEntities);
            }
        }

        public void UpdateAgent(BusinessEntityContainer obj)
        {
            var previousObject = _repositoryBusinessEntities.SelectById(new BusinessEntities { BusinessId = obj.BusinessId });

            previousObject.Code = obj.Code;
            previousObject.Email = obj.Email;
            previousObject.Name = obj.Name;
            previousObject.Street = obj.Street;
            previousObject.City = obj.City;
            previousObject.State = obj.State;
            previousObject.Zip = obj.Zip;
            previousObject.Country = obj.Country;
            previousObject.Mobile = obj.Mobile;
            previousObject.Phone = obj.Phone;
            previousObject.ContactPerson = obj.ContactPerson;
            previousObject.ReferredBy = obj.ReferredBy;
            previousObject.Logo =string.IsNullOrEmpty(obj.Logo) ? previousObject.Logo: obj.Logo;
            previousObject.Status = obj.Status;
            previousObject.Balance = obj.Balance;
            previousObject.CurrentBalance = obj.CurrentBalance;
            previousObject.UpdatedOnUtc = DateTime.Now;


            _repositoryBusinessEntities.Update(previousObject);
        }

        public BusinessEntities GetAgentById(BusinessEntities obj)
        {
            return _repositoryBusinessEntities.SelectById(obj);
        }

        public void DeleteAgent(BusinessEntities obj)
        {
            _repositoryBusinessEntities.Delete(obj);
        }

        public List<BusinessEntities> GetAllAgents(AgentFilter obj)
        {
            string condition = string.Empty;
            if (!string.IsNullOrEmpty(obj.Code))
            {
                var searchParamCode = "Code='" + obj.Code + "'";
                condition += string.IsNullOrEmpty(condition) ? searchParamCode : " && " + searchParamCode;
            }
            if (!string.IsNullOrEmpty(obj.Name))
            {
                var searchParamCode = "Name Like '%" + obj.Name + "%'";
                condition += string.IsNullOrEmpty(condition) ? searchParamCode : " && " + searchParamCode;
            }
            return _repositoryBusinessEntities.GetAllByConditions(condition).ToList();
        }



    }
}

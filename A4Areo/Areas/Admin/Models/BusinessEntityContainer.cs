using A4Areo.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4Areo.Areas.Admin.Models
{
    public class BusinessEntityContainer
    {
        public int BusinessId { get; set; }

        public string Code { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string ReferredBy { get; set; }
        public string Logo { get; set; }
        public int Status { get; set; }
        public decimal Balance { get; set; }
        public decimal CurrentBalance { get; set; }





        public BusinessEntities ConvertToBusinessEntities()
        {
            BusinessEntities model = new BusinessEntities();
            model.BusinessId = BusinessId;
            model.Code = Code;
            model.Email = Email;
            model.Name = Name;
            model.Street = Street;
            model.City = City;
            model.State = State;
            model.Zip = Zip;
            model.Country = Country;
            model.Mobile = Mobile;
            model.Phone = Phone;
            model.ContactPerson = ContactPerson;
            model.ReferredBy = ReferredBy;
            model.Logo = Logo;
            model.Status = Status;
            model.Balance = Balance;
            model.CurrentBalance = CurrentBalance;




            model.LoginUrl = "";
            model.SecurityCode = "";
            model.SMTPServer = "";
            model.SMTPPort = 0;
            model.SMTPUsername = "";
            model.SMTPPassword = "";
            model.Deleted = false;
        

            return model;



        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Jalalat.Models;

namespace WebApi_Jalalat.Controllers
{
    public class MyApiController : ApiController
    {
        Models.Person P = new Models.Person();

        public MyApiController() : base()
        {
            P.Id = 1;
            P.Name = "Hamid";
            P.Family = "Jalalat";
            P.Address = "KhaniAbad";
        }

        [HttpGet]
        public Person GetPerson1()
        {
            return P;
        }
        [HttpGet]
        public List<Person> GetPerson2()
        {
            List<Person> Lperson = new List<Person>();
            Lperson.Add(P);
            return Lperson.ToList();
        }

        [HttpGet]
        public dynamic GetPerson3()
        {
            List<Person> Lperson = new List<Person>();
            Lperson.Add(P);
            return Lperson.Select(C => new { C.Id, C.Name }).ToList();
        }

        [HttpGet]
        public string GetPerson4()
        {
            string JsonString = JsonConvert.SerializeObject(P);
            return JsonString;
        }

        [HttpGet]
        public string GetPerson5()
        {
            string JsonString = "{\"Id\":1,\"Name\":\"Hamid\",\"Family\":\"Jalalat\",\"Address\":\"KhaniAbad\"}";
            return JsonString;
        }
        [HttpGet]
        public HttpResponseMessage GetPerson6()
        {
            return Request.CreateResponse(P);
        }

        [HttpGet]
        //نوشتن
        //abi
        //بسیار مهم است چون در کانفیگ ست کردیم
        [Route("api/googooli/Magooli")]
        public HttpResponseMessage GetPerson7()
        {
            return Request.CreateResponse(P);
        }


        [HttpPost]
        public bool PostPerson([FromBody]Person p)
        {
            var yy = p;
            return true ;
        }

    }
}

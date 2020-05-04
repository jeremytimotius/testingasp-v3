using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EntityData
    {
        public string angka1 { get; set; }
        public string angka2 { get; set; }
    }
        public class TestingController : ApiController
    {
        [HttpGet]
        [ActionName("Perkalian")]
        public HttpResponseMessage Perkalian()
        {
            int angka1;
            int angka2;
            int response;

            try
            {
                angka1 = 10;
                angka2 = 2;
                response = angka1 * angka2;

                return this.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    Status = "Success",
                    Hasil = response
                });
            }
            catch
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, new
                {
                    retVal = "Failed"
                });
            }
        }
 
        

        [HttpPost]
        [ActionName("Penambahan")]
        public HttpResponseMessage Penambahan([FromBody] EntityData ED)
        {
            int angka1;
            int angka2;
            int response;

            try
            {
                angka1 = Convert.ToInt32(ED.angka1);
                angka2 = Convert.ToInt32(ED.angka2);
                response = angka1 + angka2;

                return this.Request.CreateResponse(HttpStatusCode.OK, new
                {
                    Status = "Success",
                    Hasil = response
                });
            }
            catch
            {
                return this.Request.CreateResponse(HttpStatusCode.BadRequest, new
                {
                    retVal = "Failed"
                });
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Test.Dapper.Model;
using Dapper;
using System.Data.SqlClient;

namespace Test.Scaffold.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("get1")]
        public JsonResult Get1()
        {
            JsonResult result = new JsonResult("This is MVC");

            try
            {
                List<Person> personList;
                using(var con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
                {
                    personList = con.Query<Person>("Select * from person").ToList();
                }

                result = new JsonResult(personList);
            } 
            catch(Exception e)
            {
                result = new JsonResult("Failed");
            }

            return result;
        }
    }
}

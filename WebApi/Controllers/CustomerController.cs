using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using static WebApi.Models.ApiModel;

namespace WebApi.Controllers
{
    public class CustomerController : ApiController
    {

        // GET api/Customer

        //api/Customer/Get
        public Result Get()
        {
            return new Result() { IsSuccess = true,Message="Test " };
        }

    }
}
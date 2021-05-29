using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ApiModel
    {

        public class Result
        {

            public bool IsSuccess { get; set; }

            public string Message { get; set; }

            public object AddonData { get; set; }

        }
    }
}
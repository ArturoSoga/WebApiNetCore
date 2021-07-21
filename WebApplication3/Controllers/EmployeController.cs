using Microsoft.AspNetCore.Mvc;
using RestApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("Operation/[controller]")]
    [ApiController]
    [RestApiWeb.Attributes.ApiKey]
    public class EmployeController : ControllerBase
    {
        [HttpPost]
        public object PostEmployeData(RequestModel Empl)
        {
            var Employe = new EmployeModel().GetEmploye();

            if (Employe.empl_Clave == Empl.EmplClave)
            {
                return Employe;
            }
            else
            {
                return null;
            }
        }
    }
}

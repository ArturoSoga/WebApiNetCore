using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class EmployeModel
    {
        public string empl_Clave { set; get; }
        public string empl_Nombre { set; get; }
        public string empl_Puesto { set; get; }
        public string empl_Fechaingreso { set; get; }

        public EmployeModel GetEmploye()
        {
            return new EmployeModel()
            {
                empl_Clave = "adwa78489as",
                empl_Nombre = "Juan",
                empl_Puesto = "Contador",
                empl_Fechaingreso = "21/072021"
            };
        }
    }
}

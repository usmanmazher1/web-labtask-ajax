using JSon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSon.Controllers
{
    public class HomeController : Controller
    {
        public static Student[] empList = new Student[]
{
new Student() {Name="Fawad Bin Tariq", Regno="bse173091" , Cgpa=3.2 },
new Student() {Name="Muhammad Usman", Regno="bse173090" , Cgpa=3.1 },
new Student() {Name="Samir Obaid", Regno="bse173092" , Cgpa=3.3 },
new Student() {Name="Omaid Ghayur",Regno="bse173093" , Cgpa=3.4 },
};


        public JsonResult GetEmpData()
        {
            return Json(empList);
        }
    }
}
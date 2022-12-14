using EmployeeData.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace EmployeeData.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : BaseController
    {
        public EmployeeController() { }

        [HttpPost]
        [Route("rubix_employee/create")]
        public void Post([FromBody]List<RubixEmployees> rubix_data)
        {
            try
            {
           using (var ctx = new EmployeeDbContext())
                {
                    foreach (var item in rubix_data)
                    {
                        ctx.RubixEmployeess.Add(new RubixEmployees() {EmployeeId = item.EmployeeId, Emp_Name = item.Emp_Name, Emp_Salary = item.Emp_Salary });
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new HttpResponseException("Data not inserted properly");
            }
        }
        [HttpPut]
        [Route("Employee/Update_list")]
        public void Put(int EmployeeId, RubixEmployees rubix_dat)
        {

         
            //public void UpdatePatientGoal(int id, patient_goals)
            //{
            //    var goal = db.patient_goals.FirstOrDefault(x => x.id == id);

            //    if (goal != null)
            //    {
            //        goal.goal = patient_goals.goal;
            //        db.SaveChanges();
            //    }
            //}
            try
            {
                using (var ctx = new EmployeeDbContext())
                {
                    var RubixEmployees = ctx.RubixEmployeess.FirstOrDefault(x => x.EmployeeId == EmployeeId);

                    if(RubixEmployees != null)
                    {
                        RubixEmployees.EmployeeId = rubix_dat.EmployeeId;
                        ctx.RubixEmployeess.Add(new RubixEmployees() { EmployeeId = EmployeeId, Emp_Name = rubix_dat. Emp_Name, Emp_Salary = rubix_dat. Emp_Salary });
                      
                    }
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new HttpResponseException("Data not updated properly");
            }

        }
    }
}

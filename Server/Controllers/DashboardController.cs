using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRAppMudBlazorProject.Server.Data;
using HRAppMudBlazorProject.Server.Models;
using HRAppMudBlazorProject.Shared;

namespace HRAppMudBlazorProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<DashboardController>
        [HttpGet]
        public double[] Get()
        {
            var countMale = _context.Employee.Count(p => p.Sex == Models.Gender.Male);
            var countFemale = _context.Employee.Count(p => p.Sex == Models.Gender.Female);
            var countOthers = _context.Employee.Count(p => p.Sex == Models.Gender.Others);
           var dList = _context.Department.Select(x => x.DeptName).ToList();
            //string[] departmentList = _context.Department.Select(x => x.DeptName);
            double[] datas = {countMale,countFemale,countOthers};

            return datas;
            
        }
        
        //[HttpGet("DataGet")]
        //public async Task<ActionResult<IEnumerable<Department>>> DataGet()
        //{
        //    return await _context.Department.CountAsync().ToListAsync();
        //}

        // GET api/<DashboardController>/5
       
        // POST api/<DashboardController>
        
    }
}

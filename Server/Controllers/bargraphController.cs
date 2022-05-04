using HRAppMudBlazorProject.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRAppMudBlazorProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bargraphController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public bargraphController(ApplicationDbContext context)
        {
            _context=context;
        }

        //get: api/<bargraphcontroller>
        [HttpGet]
        public string[] Get()
        {
            var departmentList = _context.Designation.Select(x => x.DesignationName).ToList().ToArray();
            return departmentList;
        }
    }
}

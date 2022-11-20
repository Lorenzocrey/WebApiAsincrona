using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAsincrona.Model;

namespace WebApiAsincrona.Controllers
{
    [ApiController]
    [Route("api/alumno")]
    public class AlumnoController : Controller
    {
        private readonly AppDbContext context;

        public AlumnoController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> Obtener()
        {
            return await context.Alumno.ToListAsync();
        }
    }
}

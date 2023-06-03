using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Models;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public PeopleController(ApiDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
        {

            //localhost:5001/api/people
            //localhost:5001/api/people/1
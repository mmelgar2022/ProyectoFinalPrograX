using Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.Collections.Generic;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugaresController : ControllerBase
    {
        private readonly ILugaresVisitados service;
        private readonly IDbConnection connection;
        public LugaresController(ILugaresVisitados lugares, IDbConnection dbconnection)
        {
            this.service = lugares;
            this.connection = dbconnection;
        }
        // GET: api/<LugaresController>
        [HttpGet]
        public List<tbl_lugares_visitadosModel> Get()
        {
            return service.GetLugaresViss(connection);
        }

        // PUT api/<LugaresController>/5
        [HttpPut("{id}")]
        public List<tbl_lugares_visitadosModel> Put(int id)
        {
            return service.EditLugaresVis(connection, id);
        }
    }
}

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
    public class DestinoController : ControllerBase
    {
        private readonly IDestino service;
        private readonly IDbConnection connection;
        public DestinoController(IDestino destino, IDbConnection dbconnection)
        {
            this.service = destino;
            this.connection = dbconnection;
        }
        // GET: api/<DestinoController>
        [HttpGet]
        public List<tbl_destinoModel> Get()
        {
            return service.GetDestinos(connection);
        }

        // PUT api/<DestinoController>/5
        [HttpPut("{id}")]
        public List<tbl_destinoModel> Put(int id)
        {
            return service.EditDestino(connection, id);
        }
    }
}

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
    public class TransporteController : ControllerBase
    {
        private readonly ITransporte service;
        private readonly IDbConnection connection;
        public TransporteController(ITransporte transporte, IDbConnection dbconnection)
        {
            this.service = transporte;
            this.connection = dbconnection;
        }
        // GET: api/<TransporteController>
        [HttpGet]
        public List<tbl_transporteModel> Get()
        {
            return service.GetTransportes(connection);
        }

        // PUT api/<TransporteController>/5
        [HttpPut("{id}")]
        public List<tbl_transporteModel> Put(int id)
        {
            return service.EditTransporte(connection, id);
        }
    }
}

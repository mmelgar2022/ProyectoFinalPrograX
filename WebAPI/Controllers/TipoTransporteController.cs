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
    public class TipoTransporteController : ControllerBase
    {
        private readonly ITipoTrans service;
        private readonly IDbConnection connection;
        public TipoTransporteController(ITipoTrans tipotransporte, IDbConnection dbconnection)
        {
            this.service = tipotransporte;
            this.connection = dbconnection;
        }
        // GET: api/<TipoTransporteController>
        [HttpGet]
        public List<tbl_tipo_transporteModel> Get()
        {
            return service.GetTipos(connection);
        }

        // PUT api/<TipoTransporteController>/5
        [HttpPut("{id}")]
        public List<tbl_tipo_transporteModel> Put(int id)
        {
            return service.EditTipo(connection, id);
        }
    }
}

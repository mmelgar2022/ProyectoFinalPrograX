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
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoria service;
        private readonly IDbConnection connection;
        public CategoriaController(ICategoria categoria, IDbConnection dbconnection)
        {
            this.service = categoria;
            this.connection = dbconnection;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public List<tbl_categoriaModel> Get()
        {
            return service.GetCategorias(connection);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public List<tbl_categoriaModel> Put(int id)
        {
            return service.EditCategoria(connection, id);
        }
    }
}

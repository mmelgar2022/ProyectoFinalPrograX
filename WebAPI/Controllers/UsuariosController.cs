using Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuario service;
        private readonly IDbConnection connection;
        public UsuariosController(IUsuario usuario, IDbConnection dbconnection)
        {
            this.service = usuario;
            this.connection = dbconnection;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public List<tbl_usuarioModel> Get()
        {
            return service.GetUsuarios(connection);
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public List<tbl_usuarioModel> Put(int id)
        {
            return service.EditUsuario(connection, id);
        }
    }
}

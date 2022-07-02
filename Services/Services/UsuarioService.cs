using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Usuario
{
    public class UsuarioService : IUsuario
    {
        public void DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void EditUsuario(tbl_usuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public List<tbl_usuarioModel> EditUsuario(IDbConnection connection, int id_usuario)
        {
            throw new NotImplementedException();
        }

        public tbl_usuarioModel GetUsuario()
        {
            throw new NotImplementedException();
        }

        public List<tbl_usuarioModel> GetUsuarioByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<tbl_usuarioModel> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public List<tbl_usuarioModel> GetUsuarios(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetUsuario(tbl_usuarioModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}

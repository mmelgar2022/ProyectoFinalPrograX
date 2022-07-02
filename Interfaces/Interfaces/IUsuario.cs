using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IUsuario
    {
        tbl_usuarioModel GetUsuario();
        List<tbl_usuarioModel> GetUsuarios(System.Data.IDbConnection connection);
        List<tbl_usuarioModel> GetUsuarioByFirstLetter(char FirstLetter);
        void SetUsuario(tbl_usuarioModel usuario);
        void DeleteUsuario(int id);
        List<tbl_usuarioModel> EditUsuario(System.Data.IDbConnection connection, int id_usuario);
    }
}

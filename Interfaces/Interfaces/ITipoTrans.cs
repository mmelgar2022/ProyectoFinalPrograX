using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface ITipoTrans
    {
        tbl_tipo_transporteModel GetTipo();
        List<tbl_tipo_transporteModel> GetTipos(System.Data.IDbConnection connection);
        List<tbl_tipo_transporteModel> GetTipoByFirstLetter(char FirstLetter);
        void SetTipo(tbl_tipo_transporteModel tipo);
        void DeleteTipo(int id);
        List<tbl_tipo_transporteModel> EditTipo(System.Data.IDbConnection connection, int id_tipo_transporte);
    }
}

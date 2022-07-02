using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Tipo_Transporte
{
    public class TipoTransporteService : ITipoTrans
    {
        public void DeleteTipo(int id)
        {
            throw new NotImplementedException();
        }

        public void EditTipo(tbl_tipo_transporteModel tipo)
        {
            throw new NotImplementedException();
        }

        public List<tbl_tipo_transporteModel> EditTipo(IDbConnection connection, int id_tipo_transporte)
        {
            throw new NotImplementedException();
        }

        public tbl_tipo_transporteModel GetTipo()
        {
            throw new NotImplementedException();
        }

        public List<tbl_tipo_transporteModel> GetTipoByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<tbl_tipo_transporteModel> GetTipos()
        {
            throw new NotImplementedException();
        }

        public List<tbl_tipo_transporteModel> GetTipos(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetTipo(tbl_tipo_transporteModel tipo)
        {
            throw new NotImplementedException();
        }
    }
}

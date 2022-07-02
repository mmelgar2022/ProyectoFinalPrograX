using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Lugares
{
    public class LugaresService : ILugaresVisitados
    {
        public void DeleteLugaresVis(int id)
        {
            throw new NotImplementedException();
        }

        public void EditLugaresVis(tbl_lugares_visitadosModel lugares)
        {
            throw new NotImplementedException();
        }

        public List<tbl_lugares_visitadosModel> EditLugaresVis(IDbConnection connection, int id_lugar)
        {
            throw new NotImplementedException();
        }

        public tbl_lugares_visitadosModel GetLugaresVis()
        {
            throw new NotImplementedException();
        }

        public List<tbl_lugares_visitadosModel> GetLugaresVisByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<tbl_lugares_visitadosModel> GetLugaresViss()
        {
            throw new NotImplementedException();
        }

        public List<tbl_lugares_visitadosModel> GetLugaresViss(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetLugaresVis(tbl_lugares_visitadosModel lugares)
        {
            throw new NotImplementedException();
        }
    }
}

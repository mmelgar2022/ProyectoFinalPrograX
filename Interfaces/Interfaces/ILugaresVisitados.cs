using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface ILugaresVisitados
    {
        tbl_lugares_visitadosModel GetLugaresVis();
        List<tbl_lugares_visitadosModel> GetLugaresViss(System.Data.IDbConnection connection);
        List<tbl_lugares_visitadosModel> GetLugaresVisByFirstLetter(char FirstLetter);
        void SetLugaresVis(tbl_lugares_visitadosModel lugares);
        void DeleteLugaresVis(int id);
        List<tbl_lugares_visitadosModel> EditLugaresVis(System.Data.IDbConnection connection, int id_lugar);
    }
}

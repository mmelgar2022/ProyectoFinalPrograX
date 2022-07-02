using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface ITransporte
    {
        tbl_transporteModel GetTransporte();
        List<tbl_transporteModel> GetTransportes(System.Data.IDbConnection connection);
        List<tbl_transporteModel> GetTransporteByFirstLetter(char FirstLetter);
        void SetTransporte(tbl_transporteModel categoria);
        void DeleteTransporte(int id);
        List<tbl_transporteModel> EditTransporte(System.Data.IDbConnection connection, int id_transporte);
    }
}

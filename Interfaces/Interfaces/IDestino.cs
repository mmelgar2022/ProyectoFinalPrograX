using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IDestino
    {
        tbl_destinoModel GetDestino();
        List<tbl_destinoModel> GetDestinos(System.Data.IDbConnection connection);
        List<tbl_destinoModel> GetDestinoByFirstLetter(char FirstLetter);
        void SetDestino(tbl_destinoModel destino);
        void DeleteDestino(int id);
        List<tbl_destinoModel> EditDestino(System.Data.IDbConnection connection, int id_destino);
    }
}

using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Destino
{
    public class DestinoService : IDestino
    {
        public void DeleteDestino(int id)
        {
            throw new NotImplementedException();
        }

        public void EditDestino(tbl_destinoModel destino)
        {
            throw new NotImplementedException();
        }

        public List<tbl_destinoModel> EditDestino(IDbConnection connection, int id_destino)
        {
            throw new NotImplementedException();
        }

        public tbl_destinoModel GetDestino()
        {
            throw new NotImplementedException();
        }

        public List<tbl_destinoModel> GetDestinoByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<tbl_destinoModel> GetDestinos()
        {
            throw new NotImplementedException();
        }

        public List<tbl_destinoModel> GetDestinos(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetDestino(tbl_destinoModel destino)
        {
            throw new NotImplementedException();
        }
    }
}

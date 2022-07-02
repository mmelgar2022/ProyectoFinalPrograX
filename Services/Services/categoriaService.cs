using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Services.Categoria
{
    public class categoriaService : ICategoria
    {
        public void DeleteCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCategoria(tbl_categoriaModel categoria)
        {
            throw new NotImplementedException();
        }

        public List<tbl_categoriaModel> EditCategoria(IDbConnection dbConnection, int id_categoria)
        {
            throw new NotImplementedException();
        }

        public tbl_categoriaModel GetCategoria()
        {
            throw new NotImplementedException();
        }

        public List<tbl_categoriaModel> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public List<tbl_categoriaModel> GetCategorias(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public List<tbl_categoriaModel> GetCategoriayFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public void SetCategoria(tbl_categoriaModel categoria)
        {
            throw new NotImplementedException();
        }
    }
}

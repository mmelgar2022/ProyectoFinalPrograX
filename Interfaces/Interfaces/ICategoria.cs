using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface ICategoria
    {
        tbl_categoriaModel GetCategoria();
        List<tbl_categoriaModel> GetCategorias(System.Data.IDbConnection dbConnection);
        List<tbl_categoriaModel> GetCategoriayFirstLetter(char FirstLetter);
        void SetCategoria(tbl_categoriaModel categoria);
        void DeleteCategoria(int id);
        List<tbl_categoriaModel> EditCategoria(System.Data.IDbConnection dbConnection, int id_categoria);
    }
}

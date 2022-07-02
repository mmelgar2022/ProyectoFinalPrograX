using Autofac;
using Interfaces.Interfaces;
using Services.Destino;
using Services.Lugares;
using Services.Categoria;
using Services.Tipo_Transporte;
using Services.Transporte;
using Services.Usuario;
using System.Data;
using System.Data.SqlClient;


namespace WebAPI
{
    public class ModuleDI : Autofac.Module
    {
        string connectionString = @"Server=localhost;Initial Catalog=ProyectoPrograX;Trusted_Connection=true";

        protected override void Load(ContainerBuilder builder)
        {
            SqlConnection conn;
            #region Categoria
            builder.RegisterType<categoriaService>().As<ICategoria>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Destino
            builder.RegisterType<DestinoService>().As<IDestino>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Lugares Visitados
            builder.RegisterType<LugaresService>().As<ILugaresVisitados>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Tipo de transporte
            builder.RegisterType<TipoTransporteService>().As<ITipoTrans>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Transporte
            builder.RegisterType<TransporteSerivce>().As<ITransporte>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Usuario
            builder.RegisterType<UsuarioService>().As<IUsuario>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
        }
    }
}

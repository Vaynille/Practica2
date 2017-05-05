using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using PracticaFormulario.ViewModel;
namespace PracticaFormulario.Models
{
    public class DbConnection
    {
        private IDbConnection connection;

        public DbConnection()
        {

            connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=FormularioBilbioteca;Data Source=.");
        }


        public void RegistrarFormulario(FormViewModel formul)
        {
            connection.Execute
               ("insert into Formulario(Nombre,Email,Pass,Genero,Fecha_Nac) values(@Nombre,@Email,@Pass,@Genero,@Fecha_Nac)", formul);

        }

        public IEnumerable<FormViewModel> TablaFormulario
        {
            get
            {
                return connection.Query<FormViewModel>("SELECT * FROM Formulario");
            }
        }

    }
}
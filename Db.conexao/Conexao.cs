using System.Data.SqlClient;

namespace Banco
{
    public class Conexao : IDisposable //indicartável
    {
        private SqlConnection conn;
        private bool disposed = false;

        public Conexao()
        {
            conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=JovemProgramador;Data Source=TAYLOR\\SQLEXPRESS\r\n");
        }

        public void Conectar()
        {
            conn.Open();
        }

        public void Desconectar()
        {
            conn.Close();
        }

        public SqlConnection Connection => conn;

        public void Dispose()// descartar ou sair
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    conn?.Close();
                    conn?.Dispose();
                }
                disposed = true;
            }
        }
        public bool BuscarUsuario(string cpf, string senha)
        {

            string sql = $"SELECT * FROM Usuario WHERE cpf = '{cpf}' AND senha = '{senha}' ";
            Conexao db = new Conexao();
            db.Conectar();
            SqlCommand comando = new SqlCommand(sql, conn);
            var retorno = comando.ExecuteReader();


            if (retorno.Read())
                return true;
            return false;

        }
        public bool BuscarUsuario2(string cpf)
        {

            string sql = $"SELECT * FROM Usuario WHERE cpf = '{cpf}' ";
            Conexao db = new Conexao();
            db.Conectar();
            SqlCommand comando = new SqlCommand(sql, conn);
            var retorno = comando.ExecuteReader();


            if (retorno.Read())
                return true;
            return false;

        }

    }
}




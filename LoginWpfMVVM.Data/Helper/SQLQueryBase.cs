using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfMVVM.Data.Helper
{
    public abstract class SQLQueryBase
    {
        private readonly string m_connectionString = string.Empty;
        public SQLQueryBase()
        {
            m_connectionString = "Server=JBANZPC\\SQLEXPRESS;Database=LoginMVVM;Trusted_Connection=True;";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(m_connectionString);
        }

        protected void HandleException(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}

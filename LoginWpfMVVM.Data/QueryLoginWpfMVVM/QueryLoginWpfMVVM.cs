﻿using LoginWpfMVVM.Data.Entity;
using LoginWpfMVVM.Data.Helper;
using LoginWpfMVVM.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfMVVM.Data.QueryLoginWpfMVVM
{
    public class QueryLoginWpfMVVM : SQLQueryBase, IQueryLoginWpfMVVM
    {
        private static QueryLoginWpfMVVM m_SingletonInstance = null;
        public static QueryLoginWpfMVVM Instance
        {
            get
            {
                if (m_SingletonInstance == null) 
                {
                    m_SingletonInstance = new QueryLoginWpfMVVM();
                }

                return m_SingletonInstance;
            }
        }

        private QueryLoginWpfMVVM()
        {

        }

        public bool AddNewUser(LoginUser user)
        {
            bool addedSuccessfully = false;

            string query = "INSERT INTO LoginUser (Username,[UserPassword],FirstName,LastName,Email) VALUES (@Username,@[UserPassword],@FirstName, @LastName, @Email)";


            SqlConnection sqlConnection = GetConnection();

            try
            {

                if (sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand(query))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@[UserPassword]", user.Password);
                        command.Parameters.AddWithValue("@FirstName", user.FirstName);
                        command.Parameters.AddWithValue("@LastName", user.LastName);
                        command.Parameters.AddWithValue("@Email", user.Email);

                        var result = command.ExecuteNonQuery();

                        if (result == -1)
                        {
                            addedSuccessfully = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                sqlConnection.Close();
            }

            return addedSuccessfully;
        }

        public bool AuthenticateUser(LoginUser user)
        {
            throw new NotImplementedException();
        }
    }
}

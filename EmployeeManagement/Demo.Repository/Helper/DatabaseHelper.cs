﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Helper
{
    public class DatabaseHelper
    {
        private static SqlConnection _connection = null;
        private static string st;
        private static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    st = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
                    _connection = new SqlConnection(st);
                }

                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
        }
        public static SqlCommand GetCommand(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = commandType;

            foreach (SqlParameter p in parameters)
            {
                cmd.Parameters.Add(p);
            }

            return cmd;
        }
        public static int ExecuteNonQuery(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            return GetCommand(sql, commandType, parameters).ExecuteNonQuery();
        }
        public static SqlDataReader ExecuteReader(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            return GetCommand(sql, commandType, parameters).ExecuteReader();
        }
        public static object ExecuteScalar(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            return GetCommand(sql, commandType, parameters).ExecuteScalar();
        }
    }
}
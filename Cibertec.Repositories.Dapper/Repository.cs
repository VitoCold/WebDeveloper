﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Cibertec.Repositories.Dapper
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionString;

        public Repository(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) =>
            {
                return $"{type.Name}";
            };

            _connectionString = connectionString;
        }

        public bool Delete(T entity)
        {
            using (var connection=new SqlConnection(_connectionString))
            {
                return connection.Delete(entity);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public T GetyById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<T>(id);
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Update(entity);
            }
        }
    }
}

﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessCategoria
    {
        DBConnection conn = new DBConnection();

        public bool Delete(EntityCategoria categoria)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_id" , categoria.Id)
            };
            return conn.Write("delete_categoria", parameters);
        }

        public bool Insert(EntityCategoria categoria)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_nombre", categoria.Nombre),
                new SqlParameter("In_descripcion" ,  categoria.Descripcion),
            };
            return conn.Write("insert_categoria", parameters);
        }

        public List<EntityCategoria> SelectAll()
        {
            List<EntityCategoria> list = new List<EntityCategoria>();
            DataTable table = conn.Read("select_categoria", null);
            foreach (DataRow registro in table.Rows)
            {
                EntityCategoria categoria = SqlMapper.MapCategoria(registro);
                list.Add(categoria);
            }
            return list;    
        }

        public bool Update(EntityCategoria categoria)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("In_id", categoria.Id),
                new SqlParameter("In_nombre", categoria.Nombre),
                new SqlParameter("In_descripcion" , categoria.Descripcion)
            };
            return conn.Write("update_categoria", parameters);
        }
    }
}

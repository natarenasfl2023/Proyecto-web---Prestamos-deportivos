﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace App_ConsultaPrestamosDeportivos
{
    public class cls_consultar
    {
        DataTable dt_prestamos = new DataTable();
        cls_conexion obj_conectar = new cls_conexion();
        public void fnt_consultar(string id)
        {
            cls_conexion objconexion = new cls_conexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarPrestamos", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id_persona", id);
            objconexion.connection.Open();
            da.Fill(dt_prestamos);
            objconexion.connection.Close();
        }
        public DataTable getDt_prestamos() { return this.dt_prestamos; }
    }
}
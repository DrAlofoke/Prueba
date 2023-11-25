using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace PARCIALDOS
{
    public class cnn
    {
        // crea el conection string a la base de datos
        // DEBES DE COLOCAR EL NOMBRE DE TU PC + LA INSTANCIA
        public static string db = "Server=LAPTOP-8B99UN0I\\SQLEXPRESS;" +
                                  "DataBase=juanparcial\r\n;" +
                                  "Trusted_Connection=True";
    }
    public class HMenu
    {
        public static string nCia = "ITLA";
        public static string cia = "PGR1 - Instituto de Las Americas   (  ";
        public static string pc = "  )   PC - " + System.Environment.MachineName;

    }

    public class Busco
    {
        public static string Posiciones(string numPosicion)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  // crea el conection string a la base de datos
            cnxn.Open();  // abre la base de datos

            SqlCommand cmnd = new SqlCommand("SELECT NOMBREPOSICION FROM POSICIONES WHERE ID_POSICIONES = @PV", cnxn);  // aqui el script de sql
            cmnd.Parameters.AddWithValue("@PV", numPosicion);   // se le envia un parametro al script de sql
            SqlDataReader rsd = cmnd.ExecuteReader();           // ejecuta el script de sql

            if (rsd.Read())                                      // aqui pregunta que si tiene data el objeto rsd
            {
                return Convert.ToString(rsd["NOMBREPOSICION"]); 
                // si contiene data la retornara al textbox y saldra del metodo
            }

            cmnd.Dispose();
            cnxn.Close();
            return null;                                        
            // este return solo se ejecuta si no trajo data el script de sql
        }

        public static string Departamento(string numDepto)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  // crea el conection string a la base de datos
            cnxn.Open();  // abre la base de datos

            SqlCommand cmnd = new SqlCommand("SELECT NOMBRE_DEPARTAMENTOS FROM DEPARTAMENTOS WHERE ID_DEPARTAMENTOS = @PV", cnxn);  // aqui el script de sql
            cmnd.Parameters.AddWithValue("@PV", numDepto);   // se le envia un parametro al script de sql
            SqlDataReader rsd = cmnd.ExecuteReader();           // ejecuta el script de sql

            if (rsd.Read())                                      // aqui pregunta que si tiene data el objeto rsd
            {
                return Convert.ToString(rsd["NOMBRE_DEPARTAMENTOS"]); // si contiene data la retornara al textbox y saldra del metodo
            }

            cmnd.Dispose();
            cnxn.Close();
            return null;                                        // este return solo se ejecuta si no trajo data el script de sql
        }

        public static string Clientes(string numCliente)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            SqlCommand cmmnd = new SqlCommand("SELECT IDCLIENTE, NOMBRE_CLIENTE " +
                                              "  FROM CLIENTES " +
                                              " WHERE IDCLIENTE = @PV", cnxn);

            cmmnd.Parameters.AddWithValue("@PV", numCliente);
            SqlDataReader rsd = cmmnd.ExecuteReader();

            if (rsd.Read())
            {
                return Convert.ToString(rsd["NOMBRE_CLIENTE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }
    }
}

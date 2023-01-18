using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    internal class ManejoDatos
    {
        //atributos

        MySqlConnection conexion;

        private void conectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = cadcon;

            conexion.Open();
        }
        private void desconectarBD()
        {
            conexion.Close();
        }

        public int cargarSancion(string legajo, string apellido, string nombre, string sector, string puesto, string codmotivo, string motivo, string codresolucion, string resolucion, string cantSusp,string Fecha)
        {
            int confirmacion=0;
            try
            {
                //INSERT INTO `employee`.`sanciones` (`Legajo`, `Apellido`, `Nombre`, `Sector`, `Puesto`, `CodMotivo`, `Motivo`, `CodResolucion`, `Resolucion`, `CantSusp`, `Fecha`) VALUES ('1', 'a', 'd', 'a', 'd', '1', 'a', '2', 'd', '3', '4-03-12');
                string cargarinstruccion = "INSERT INTO `employee`.`sanciones` (`Legajo`, `Apellido`, `Nombre`, `Sector`, `Puesto`, `CodMotivo`, `Motivo`, `CodResolucion`, `Resolucion`, `CantSusp`, `Fecha`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');";
                cargarinstruccion= string.Format(cargarinstruccion,legajo,apellido,nombre,sector,puesto,codmotivo,motivo,codresolucion,resolucion,cantSusp,Fecha);
                conectarBD();
                MySqlCommand cdd = new MySqlCommand(cargarinstruccion, conexion);
                confirmacion = cdd.ExecuteNonQuery();
            }
            catch (Exception)
            {
           
            }
            finally {
                desconectarBD(); 
            }


            return confirmacion;
        }
       
        public int agregarCuenta(string num_legajo, string nombre, string apellido,string sexo,string sector,string puesto)
        {
            int resultado = 0;
            try
            {

                string instruccion = "INSERT INTO `employee`.`legajos` (`NroLegajo`, `Nombre`, `Apellido`, `Sexo`, `Sector`, `Puesto`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');";

                instruccion = string.Format(instruccion, num_legajo, nombre, apellido,sexo,sector,puesto);
                conectarBD();
                MySqlCommand cmd = new MySqlCommand(instruccion, conexion);
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception )
            {

            }
            finally
            {
                desconectarBD();
            }
            return resultado;
        }

        public int editarCuenta(string num_legajo, string nombre, string apellido, string sexo, string sector, string puesto)
        {
            int resultado = 0;
            try
            {

                string instruccion = "UPDATE `employee`.`legajos` SET `NroLegajo` = '{0}', `Nombre` = '{1}', `Apellido` = '{2}', `Sexo` = '{3}', `Sector` = '{4}', `Puesto` = '{5}' WHERE (`NroLegajo` = '{6}');";

                instruccion = string.Format(instruccion,num_legajo, nombre, apellido,sexo,sector,puesto,num_legajo);
                conectarBD();
                MySqlCommand cmd = new MySqlCommand(instruccion, conexion);
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            finally
            {
                desconectarBD();
            }
            return resultado;
        }

        public DataTable buscar()
    {
                conectarBD();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = ("SELECT * FROM employee.legajos;");
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                return tabla;
        }
        private void autoincremento()
        {
            conectarBD();
            MySqlCommand cmd=new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = ("INSERT INTO `employee`.`sanciones` (`NroCaso`) VALUES ('{0}');");


        }
        public MySqlDataReader buscarCaso(string num_caso)
        {
            MySqlDataReader leer = null;
            string instruccion = "SELECT * FROM employee.nrocaso where NroCaso='{0}';";
            instruccion = string.Format(instruccion, num_caso);
            try
            {
                conectarBD();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                leer = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            return leer;
        }

        public MySqlDataReader buscarEmpleado(string num_legajo)
        {
            MySqlDataReader dr= null;
            string instruccion = "SELECT * FROM employee.legajos where NroLegajo='{0}';";
            instruccion = string.Format(instruccion, num_legajo);
            try
            {
                conectarBD();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                dr = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw; 
            }
            return dr;
        }
        public int eliminarEmpleado(string num_legajo)
        {
            int resultado = 0;
            string instruccion = "DELETE FROM `employee`.`legajos` WHERE (`NroLegajo` = '{0}');";
            instruccion=string.Format(instruccion,num_legajo);
            try
            {
                conectarBD();
                MySqlCommand cmd = new MySqlCommand(instruccion, conexion);
              
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                desconectarBD();
            }
            return (resultado);
        }
            
    }

}


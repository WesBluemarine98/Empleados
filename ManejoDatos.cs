using MySql.Data.MySqlClient;
using System;

namespace Empleados

public class Class1
{
	public Class1()
	{
        
        //atributos
        string cadcon = "Server=bd_empleados;Database=employee;User=bd_empleados;pwd=Elvaron-dom4;";
        MySqlConnection conexion;

        private void conectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = cadcon

            conexion.Open();
        }
        private void desconectarBD()
        {
            conexion.Close();
        }
        public int agregarCuenta(int num_legajo, char nombre, char apellido, int dni)
        {
            int resultado = 0;
            try
            {

                string instruccion = "INSERT INTO `employee`.`legajos` (`num_legajo`, `nombre`, `apellido`, `dni`) VALUES ('{0}', '{1}', '{2}', '{3}');";
                instruccion = string.Format(instruccion, num_legajo, nombre, apellido, dni);
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
    }
}

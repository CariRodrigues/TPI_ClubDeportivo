// Referencia a MySQL (se agrega como librería)
using MySql.Data.MySqlClient; // Importa la biblioteca necesaria para trabajar con MySQL
//---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_ClubDeportivo.Datos.Infrastructure
{
    public class ConexionDB
    {
        // Definición de variables privadas para almacenar la configuración de conexión
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static ConexionDB? con = null; // Variable estática para la instancia de conexión

        // Constructor de la clase Conexion
        public ConexionDB()
        {
            this.baseDatos = "ClubDeportivo"; // Nombre de la base de datos asignado.
            // Obtiene las variables de entorno para la configuración de conexión.
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "holamundo34";
        }

        // Método para crear una conexión a la base de datos
        public MySqlConnection CrearConexion()
        {
            // Instanciamos una conexión
            MySqlConnection? cadena = new MySqlConnection();

            // El bloque try permite controlar errores
            try
            {
                // Construir la cadena de conexión utilizando las propiedades definidas
                cadena.ConnectionString = "datasource=" +this.servidor +
                                          ";port="  +this.puerto +
                                          ";username="  +this.usuario +
                                          ";password=" +this.clave +
                                          ";Database="  +this.baseDatos;
            }
            catch (Exception ex) // Captura cualquier excepción que ocurra
            {
                cadena = null; // Asigna null a la conexión en caso de error
                throw; // Relanza la excepción para manejarla en un nivel superior
            }
            return cadena; // Retorna la cadena de conexión
        }

        // Método para obtener la instancia única de la clase Conexion
        public static ConexionDB getInstancia()
        {
            if (con == null) // Verifica si la conexión no ha sido creada
            {
                con = new ConexionDB(); // Si no existe, se crea una nueva instancia
            }
            return con; // Retorna la instancia de conexión (puede ser nueva o existente)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición del espacio de nombres para organizar el código
namespace IntroduccionLinq
{
    // Definición de la clase 'Casa'
    public class Casa
    {
        // Propiedad 'Id' que representa un identificador único para cada objeto 'Casa'
        public int Id { get; set; }

        // Propiedad 'Direccion' que almacena la dirección de la casa
        public string Direccion { get; set; }

        // Propiedad 'Ciudad' que almacena la ciudad en la que se encuentra la casa
        public string Ciudad { get; set; }

        // Propiedad 'numeroHabitaciones' que almacena la cantidad de habitaciones que tiene la casa
        public int numeroHabitaciones { get; set; }

        // Método 'dameDatosCasa' que devuelve una cadena con la información de la casa
        public string dameDatosCasa()
        {
            // El método usa interpolación de cadenas para devolver la dirección, ciudad y número de habitaciones
            return $"Dirección es {Direccion} en la ciudad de {Ciudad} con número de habitaciones {numeroHabitaciones}";
        }
    }
}

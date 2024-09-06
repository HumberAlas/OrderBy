using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición del espacio de nombres para organizar el código
namespace IntroduccionLinq
{
    // Definición de la clase 'Habitante'
    public class Habitante
    {
        // Propiedad 'IdHabitante' que identifica al habitante de manera única
        public int IdHabitante { get; set; }

        // Propiedad 'Nombre' que almacena el nombre del habitante
        public string Nombre { get; set; }

        // Propiedad 'Edad' que almacena la edad del habitante
        public int Edad { get; set; }

        // Propiedad 'IdCasa' que hace referencia a la casa donde vive el habitante
        public int IdCasa { get; set; }

        // Método 'datosHabitante' que devuelve una descripción del habitante
        public string datosHabitante()
        {
            // Devuelve una cadena con el nombre, edad e identificación de la casa del habitante
            return $"Soy {Nombre} con edad de {Edad} años, vivo en la casa con Id {IdCasa}";
        }
    }
}


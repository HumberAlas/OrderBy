using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición del espacio de nombres para organizar el código
namespace IntroduccionLinq
{
    // Definición de la clase 'Enfermero' que hereda de 'Empleado'
    public class Enfermero : Empleado
    {
        // Redefinición de la propiedad 'nombre', lo cual no es necesario ya que se hereda de 'Empleado'
        public string nombre { get; set; }
    }
}


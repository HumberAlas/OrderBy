using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición del espacio de nombres
namespace IntroduccionLinq
{
    // Clase 'Medico' que hereda de 'Empleado'
    public class Medico : Empleado
    {
        // Redefinición de la propiedad 'nombre', que ya existe en la clase base 'Empleado'
        public string nombre { get; set; }
    }
}


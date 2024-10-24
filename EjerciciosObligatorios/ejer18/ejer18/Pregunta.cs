using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer18
{
    public class Pregunta
    {
        private string incongnita;
        private List<Opcion> opciones;
        private Opcion opcionCorrecta;
        private int puntos;
        public Pregunta(string incongnita, List<Opcion> opciones, Opcion opcionCorrecta, int puntos)
        {
            this.incongnita = incongnita;
            this.opciones = opciones;
            this.opcionCorrecta = opcionCorrecta;
            this.puntos = puntos;
        }
        public void mostrarPregunta()
        {

        }
        public void comprobarRespuesta()
        {

        }
    }
}

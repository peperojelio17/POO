using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{
    public abstract class Empleado
    {
        private string nombre;
        private int edad;
        private int salario;
        private const int PLUS = 300;
        public Empleado(string _nombre, int _edad, int _salario)
        {
            nombre = _nombre;
            edad = _edad;
            salario = _salario;
        }
        public string Nombre { get { return nombre; } }
        public int Edad { get { return edad; } }
        public int Salario { get { return salario; } set { salario = value; } }

        public int Plus {get {return PLUS; } }

        public abstract bool plus();


    }
    public class Repartidor : Empleado
    {
        private string zona;
        public Repartidor(string nombre, int edad, int salario, string _zona) : base(nombre, edad, salario)
        {
            zona = _zona;
        }
        public string Zona { get { return zona; } }
        public override bool plus()
        {
            if (base.Edad < 25 && zona == "zona 3")
            {
                base.Salario += base.Plus;
                return true; 
            }
            return false;
        }
    }
    public class Comercial : Empleado
    {
        private double comision;
        public Comercial(string nombre, int edad, int salario, double _comision) : base(nombre, edad, salario)
        {
            comision = _comision;
        }
        public double Comision { get { return comision; } }

        public override bool plus()
        {
            if(base.Edad > 30 && comision > 200)
            {
            base.Salario += base.Plus;
            return true;
            }
        return false;
        }
    }
}

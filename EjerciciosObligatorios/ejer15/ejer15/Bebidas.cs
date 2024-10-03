using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    public class Bebida
    {
        private int id;
        private int cantLitros;
        private int precio;
        private string marca;

        public int Id { get { return id; } }
        public int CantLitros { get { return cantLitros; } }
        public int Precio { get { return precio; } set { precio = value; } }
        public string Marca { get { return marca; } }
        public Bebida(int _id, int _cantLitros, int _precio, string _marca) 
        { 
            id = _id;
            cantLitros = _cantLitros;
            precio = _precio;
            marca = _marca;
        }
    }
    public class AguaMineral : Bebida
    {
        private string origen;
        public string Origen { get { return origen; } }
        public AguaMineral(int _id, int _cantLitros, int _precio, string _marca, string _origen) : base(_id, _cantLitros, _precio, _marca)
        {
            origen = _origen;
        }
    }
    public class BebidasAzucarada : Bebida
    {
        private int porcentajeAzucar;
        private bool promocion;
        private int p;
        public int PorcentajeAzucar { get { return porcentajeAzucar; } }
        public bool Promocion {  get { return promocion; } }
        public BebidasAzucarada(int _id, int _cantLitros, int _precio, string _marca, int _porcentajeAzucar, bool _promocion) : base(_id, _cantLitros, _precio, _marca)
        {
            porcentajeAzucar = _porcentajeAzucar;
            promocion = _promocion;
            Precio -= (promocion) ? _precio / 10: 0;
            
        }
    }

}

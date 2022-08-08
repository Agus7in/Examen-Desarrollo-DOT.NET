using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Flow_Technology_Agustin_Martinez
{
    public class Data
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        private string apellido;
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private int edad;
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public Data(int id, string apellido, string nombre, int edad)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGestionVehiculos
{
    public abstract class Vehiculo : Itransporte
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public abstract void Moverse();
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public virtual void Arrancar()
        {
            MessageBox.Show($"{Marca} {Modelo} esta arrancando");
        }
        public virtual void Detener()
        {
            MessageBox.Show($"{Marca} {Modelo}, se detuvo");
        }
        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGestionVehiculos
{
    public class Camion : Vehiculo
    {
        public int CapacidadCarga {  get; set; }
        public Camion(string marca, string modelo, int capacidadCarga) : base(marca, modelo)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override void Moverse()
        {
            MessageBox.Show($"{Marca} {Modelo} se esta moviendo con una capacidad de {CapacidadCarga}kg");
        }
    }
}

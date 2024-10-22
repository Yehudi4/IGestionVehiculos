using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGestionVehiculos
{
    public class Auto_Electrico : Vehiculo, IElectrico
    {
        public int CapacidadBateria { get; set; }
        public Auto_Electrico(string marca, string modelo, int capacidadBateria ) : base(marca, modelo)
        {
            CapacidadBateria = capacidadBateria;
        }

        public override void Moverse()
        {
            MessageBox.Show($"{Marca} {Modelo} esta moviendose con {CapacidadBateria} de bateria");
        }
        public void CargarBateria()
        {
            MessageBox.Show($"{Marca} {Modelo} esta cargando su bateria");
        }
    }
}

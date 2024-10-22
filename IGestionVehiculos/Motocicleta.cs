using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGestionVehiculos
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void Moverse()
        {
            MessageBox.Show($"{Marca} {Modelo} se esta moviendo");
        }
    }
}

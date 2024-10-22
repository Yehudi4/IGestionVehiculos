using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGestionVehiculos
{
    public class Auto : Vehiculo
    {
        public Auto(string marca, string modelo) : base(marca, modelo)
        {
        }

        public override void Moverse()
        {
            MessageBox.Show($"{Marca} {Modelo} se esta moviendo");
        }
    }
}

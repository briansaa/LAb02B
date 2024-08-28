using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LAb02B
{
    /// <summary>
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();

            List<User> users = new List<User>
            {
                new User{Fecha = DateTime.Now,Peso = 150.5,TipoAuto = "fERRari", NombreTransportista = "Saavedra", PesoIngreso = 1000.0, PesoSalida = 950.0, FechaHora = DateTime.Now},
                new User{Fecha = DateTime.Now.AddDays(-1),Peso = 200.0,TipoAuto = "SUV", NombreTransportista = "Juan Perez", PesoIngreso = 1200.0, PesoSalida = 1150.0, FechaHora = DateTime.Now.AddDays(-1)},
                new User {Fecha = DateTime.Now.AddDays(-2), Peso = 180.0,TipoAuto = "Toyota", NombreTransportista = "Samir velasquez",PesoIngreso = 1100.0,PesoSalida = 1050.0,FechaHora = DateTime.Now.AddDays(-2)},
            };

            dgSimple.ItemsSource = users;
        }
    }

    public class User
    {
        public DateTime Fecha { get; set; }
        public double Peso { get; set; }
        public string TipoAuto { get; set; }
        public string NombreTransportista { get; set; }
        public double PesoIngreso { get; set; }
        public double PesoSalida { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
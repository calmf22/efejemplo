using demobasedatos.MiBD;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace demobasedatos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //instanciar base de datos
            if (Regex.IsMatch(txtnombre.Text, @"^[a-zA-Z\s]+$") && Regex.IsMatch(txtsueldo.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                Empleado emp = new Empleado();
                emp.Nombre = txtnombre.Text;
                emp.Sueldo = int.Parse(txtsueldo.Text);
                db.Empleados.Add(emp);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Solo letras en el nombre y numeros en el saldo");
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtnombre.Text, @"^[a-zA-Z\s]+$") && Regex.IsMatch(txtsueldo.Text, @"^\d+$") && Regex.IsMatch(textBoxID.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int id = int.Parse(textBoxID.Text);
                var emp = db.Empleados.SingleOrDefault(x => x.id == id);
                /*from x in  
                where x.id == id
                  select x;*/
                if (emp != null)
                {
                    emp.Nombre = txtnombre.Text;
                    emp.Sueldo = int.Parse(txtsueldo.Text);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Solo letras en el nombre y numeros en el saldo");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(textBoxID.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int id = int.Parse(textBoxID.Text);
                var emp = db.Empleados.SingleOrDefault(x => x.id == id);

                if (emp != null)
                {
                    db.Empleados.Remove(emp);
                    db.SaveChanges();
                }
                
            
            }
            else
            {
                MessageBox.Show("solo numeros #id");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(textBoxID.Text, @"^\d+$"))
            {
                demoEF db = new demoEF();
                int id = int.Parse(textBoxID.Text);
                var registros = from s in db.Empleados
                                where s.id == id
                                select new
                                {
                                    s.Nombre,
                                    s.Sueldo
                                };
                DBgrid.ItemsSource = registros.ToList();

            }
            else
            {
                MessageBox.Show("solo numeros #id");
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            demoEF db = new demoEF();
            
            var registros = from s in db.Empleados                           
                            select s;
            DBgrid.ItemsSource = registros.ToList();
        }
    }
}

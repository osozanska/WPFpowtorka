using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrzedSprawdzianem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ksiazka> ListaKsiazek { get; set; } = new List<ksiazka>();

        public MainWindow()
        {
            
            InitializeComponent();
            lista.ItemsSource = ListaKsiazek;
            ListaKsiazek.Add(new ksiazka("lalka", "boleslaw prus"));
        }

        private void dodajKsiazke_Click(object sender, RoutedEventArgs e)
        {
            var oknoDodaj = new okno(this);
            oknoDodaj.ShowDialog();
            lista.Items.Refresh();
        }
        public void dodajKsiazke(ksiazka ksiazki)
        {
            ListaKsiazek.Add(ksiazki);
        }
    }
}
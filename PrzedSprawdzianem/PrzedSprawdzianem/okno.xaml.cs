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

namespace PrzedSprawdzianem
{
    /// <summary>
    /// Logika interakcji dla klasy okno.xaml
    /// </summary>
    public partial class okno : Window
    {
        private MainWindow noweOkno;
        public okno(MainWindow mainWindow)
        {
            InitializeComponent();
            noweOkno = mainWindow;
        }

       
        private void Anuluj_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TytulW.Text)) {
                MessageBox.Show("Wpisz tytul!");
                return;
            }
            if (string.IsNullOrWhiteSpace(AutorW.Text))
            {
                MessageBox.Show("Wpisz Autora!");
                return;
            }
            var ksiazki = new ksiazka(TytulW.Text, AutorW.Text);
            noweOkno.dodajKsiazke(ksiazki);

            MessageBox.Show("Ksiazka zostala dodana poprawnie!");
            this.Close();
        }
    }
}

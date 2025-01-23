using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace ListyCwiczenia
{
    
        
    public partial class MainWindow : Window
    {
        public ObservableCollection<Uczen> Uczniowie { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Uczniowie = new ObservableCollection<Uczen>();

            Uczniowie.Add(new Uczen("Bartosz", 13, false, "Elektronik"));
            Uczniowie.Add(new Uczen("Amelia", 17, true, "Programista"));
            Uczniowie.Add(new Uczen("Krzysztof", 9, true, "Geodeta"));
            Uczniowie.Add(new Uczen("Kunegunda", 21, false, "Psycholog"));

            DataContext = this;



            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = imieUczniaTextBox.Text;
            int wiek;

            if(int.TryParse(wiekUczniaTextBox.Text, out wiek))
            {

            }
            else
            {
                wiek = 10;
                MessageBox.Show("Wiek ma być liczbą. Zapisano: 10.");
            }

            bool czyPowtarzaRok = czyPowtarzaCheckBox.IsChecked == true ? true : false;
            string zawod = zawodUczniaTextBox.Text;

            Uczniowie.Add(new Uczen(imie, wiek, czyPowtarzaRok, zawod));
            
        }
    }
}

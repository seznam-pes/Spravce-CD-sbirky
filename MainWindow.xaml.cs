using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public ObservableCollection<CDDisc> CDkolekce = new ObservableCollection<CDDisc>()
        {
            new CDDisc{ID = 0, Nazev = "S.A.M.O", Artist = "Saul", DatumVydani = new DateTime (2025, 01, 18), PocetSkladeb = 12, Zanr = "R&B", Vydavatelstvi = "WLVS", DatumPridani = new DateTime (2026, 03, 19) },
            new CDDisc{ID = 1, Nazev = "My Beautfiul Dark Twisted Fantasy", Artist = "Kanye West", DatumVydani = new DateTime(2010, 11, 22), PocetSkladeb = 13, Zanr = "Hip-hop", Vydavatelstvi = "Roc-A-Fella, Def Jam Recordings", DatumPridani = new DateTime(2024, 08, 24)},
        };

        int i = 2;
        public int id;
        public DateTime datumvydani;
        public DateTime datumpridani;

        public MainWindow()
        {
            InitializeComponent();
            CDgrid.ItemsSource = CDkolekce;
            
        }

        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string tempcount = pocet_skladeb.Text;

            if (int.TryParse(tempcount, out int pocet)) {
                pocet = int.Parse(tempcount);
            }
            else
            {
                MessageBox.Show("Nezadal jste číslo.");
                return;
            }

            CDkolekce.Add(new CDDisc
            {
                ID = i,
                Nazev = name.Text,
                Artist = artist.Text,
                DatumVydani = datumvydani, //zprovoznit
                PocetSkladeb = pocet,
                Vydavatelstvi = vydavatelstvi.Text,
                Zanr = zanr.Text,
                DatumPridani = datumpridani //zprovoznit
            });
            i++;
        }

        public void DelButton_Click(object sender, RoutedEventArgs e)
        {
            var vybraneCD = CDgrid.SelectedItem as CDDisc;

            if (vybraneCD != null)
            {
                CDkolekce.Remove(vybraneCD);
            }
            else
            {
                MessageBox.Show("Klikněte na CD, které chcete smazat.");
            }
        }

        public void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
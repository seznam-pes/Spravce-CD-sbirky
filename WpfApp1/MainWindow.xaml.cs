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
        Backend bejros = new Backend();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = bejros;
        }

        public string nazev;
        public string umelec;
        public DateTime datumvydani;
        public int songcount;
        public string genre;
        public string label;
        public DateTime datumpridani;

        public void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string tempcount = pocet_skladeb.Text;

            nazev = name.Text;
            umelec = artist.Text;
            datumvydani = releasedate.SelectedDate.Value.Date;
            songcount = int.Parse(tempcount);
            genre = zanr.Text;
            label = vydavatelstvi.Text;
            datumpridani = adddate.SelectedDate.Value.Date;
            bejros.AddCD();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class Backend
    {
        MainWindow bejr = (MainWindow)Application.Current.MainWindow;
        ObservableCollection<CDDisc> CDkolekce = new ObservableCollection<CDDisc>()
        {

        };

        public void AddCD()
        {
            CDkolekce.Add(new CDDisc{
                Nazev = bejr.nazev,
                Artist = bejr.umelec,
                // přidat release date
                PocetSkladeb = bejr.songcount,
                Vydavatelstvi = bejr.label,
                Zanr = bejr.genre,
                // přidat add date
            });
        }
    }
}

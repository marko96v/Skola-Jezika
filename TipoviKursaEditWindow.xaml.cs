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
using SkolaJezikaConsole;

namespace SkolaJezikaWPF
{
    /// <summary>
    /// Interaction logic for TipoviKursaEditWindow.xaml
    /// </summary>
    public partial class TipoviKursaEditWindow : Window
    {
        protected TipKursa orginal, copyObj;
        protected MOD mod;
        public TipoviKursaEditWindow()
        {
            InitializeComponent();

        }

        public TipoviKursaEditWindow(TipKursa k, MOD m = MOD.DODAVANJE) : this()
        {
            this.orginal = k;
            this.mod = m;
            this.copyObj = orginal.Clone() as TipKursa;
            this.DataContext = copyObj;
        }

        private void bSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            this.orginal.setValues(copyObj);

            if (mod == MOD.DODAVANJE)
            {
                Aplikacija.Instanca.TipoviKursa.Add(orginal);
            }


            this.DialogResult = true;
            this.Close();
        }

        private void bOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

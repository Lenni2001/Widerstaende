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

namespace Widerstaende
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonUebernehmen_Click(object sender, RoutedEventArgs e)
        {
            //Wert aus der ErgebnisTextbox als 1. Wert übernehmen
            this.TextBoxR1.Text = this.TextBoxRges.Text.Replace('Ω', ' ').Trim();
            if (this.TextBoxR1.Text == "") this.TextBoxR1.Text = "0"; //leeren Wert durch Null ersetzen
        }

        private void ButtonParallel_Click(object sender, RoutedEventArgs e)
        {
            /* //ohne Klasse
                        double R1 = System.Convert.ToDouble(this.TextBoxR1.Text.Replace('R', ','));
                        double R2 = System.Convert.ToDouble(this.TextBoxR2.Text.Replace('R', ','));
                        double Rges = (R1 * R2) / (R1 + R2);
                        TextBoxRges.Text = Rges.ToString()+ " Ohm";
                        TextBoxInfo.Text += R1.ToString() + " Ohm parallel zu " + R2.ToString() + " Ohm ergibt " + Rges.ToString() + " Ohm\r\n";
            */
            //Zwei Widerstände als Instanzen der Klasse Widerstand anlegen
            //Werte aus den Textboxen benutzen
            Widerstand R1 = new Widerstand(System.Convert.ToDouble(this.TextBoxR1.Text));
            Widerstand R2 = new Widerstand(System.Convert.ToDouble(this.TextBoxR2.Text));
            Widerstand Rges = R1 / R2; //R1 und R2 parallel schalten
            TextBoxRges.Text = Rges.ToString(); //Ergebnis ausgeben
            //Infos in der Infobos anhängen
            TextBoxInfo.Text += R1.ToString() + " parallel zu " + R2.ToString() + " ergibt " + Rges.ToString() + "\r\n";

        }

        private void ButtonReihe_Click(object sender, RoutedEventArgs e)
        {
            /* //ohne Klasse
                        double R1 = System.Convert.ToDouble(this.TextBoxR1.Text.Replace('R',','));
                        double R2 = System.Convert.ToDouble(this.TextBoxR2.Text.Replace('R', ','));
                        double Rges = R1 + R2;
                        TextBoxRges.Text = Rges.ToString()+ " Ohm";
                        TextBoxInfo.Text += R1.ToString() + " Ohm in Reihe zu " + R2.ToString() + " Ohm ergibt " + Rges.ToString() + " Ohm\r\n";
            */
            //Zwei Widerstände als Instanzen der Klasse Widerstand anlegen
            //Werte aus den Textboxen benutzen
            Widerstand R1 = new Widerstand(System.Convert.ToDouble(this.TextBoxR1.Text));
            Widerstand R2 = new Widerstand(System.Convert.ToDouble(this.TextBoxR2.Text));
            Widerstand Rges = R1 + R2; //R1 und R2 in Reihe schalten
            TextBoxRges.Text = Rges.ToString(); //Ergebnis ausgeben
            //Infos in der Infobos anhängen
            TextBoxInfo.Text += R1.ToString() + " in Reihe zu " + R2.ToString() + " ergibt " + Rges.ToString() + "\r\n";
        }
    }
}

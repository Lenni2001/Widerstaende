using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widerstaende
{
    class Widerstand// Modell für einen Widerstand
    {
        //Der Widerstandswert
        public double R { get; }  //nur lesenden Zugriff zulassen
        //Der Parameterkonstruktor
        public Widerstand(double R)
        {
            if (R > 0) //nur positive Werte zulassen.
                this.R = R;
            else
                this.R = 0;
        }
        //Reihenschaltung von Widerständen
        public static Widerstand operator +(Widerstand l, Widerstand r)
        {
            return new Widerstand(l.R + r.R);//Werte addieren
        }
        //Parallelschaltung von Widerständen
        public static Widerstand operator /(Widerstand l, Widerstand r)
        {
            return new Widerstand(1 / (1 / l.R + 1 / r.R));//Kehrwerte addiert ergibt den Gesamtkehrwert
        }
        //Wert mit Einheit ausgeben
        public override string ToString()
        {
            //return R.ToString() + " Ohm"; //basis ToString verwenden und " Ohm" anhängen"
            //oder bessert mit griechischem Zeichen Omega 
            //Z.B. aus Word|Einfügen|Sonderzeichen in die Zwischenablage kopieren
            //und über die Zwischenablage hier in den Quellcode hineinkopiert
            return R.ToString() + " Ω"; //basis ToString verwenden und " Ω" anhängen"
        }
    }
}

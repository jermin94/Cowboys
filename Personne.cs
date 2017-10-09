namespace Cowboy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Personne
    {
        public string Nom { get; set; }
        public int Poids { get; set; }
        public double Vitesse { get; set; }
        public Cowboy [] Groupe { get; set; }
        public Personne(string nom, double poids)
        {

        }
        public Personne()
        {

        }
    }
}

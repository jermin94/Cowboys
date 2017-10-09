namespace Cowboy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Objet
    {
        public double PoidsSupporte { get; set; }
        public Objet(double poids)
        {
            this.PoidsSupporte = poids;
        }
        public Objet()
        {

        }
    }
}

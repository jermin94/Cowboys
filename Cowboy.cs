namespace Cowboy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Cowboy : Personne
    {
        public Revolver Revolver { get; set; }


        public Cowboy[] RecupererLinfoDuCowboy()
        {
            Personne cowboys = new Cowboy();
            Console.Write("Le nombre de cowboy : ");
            int nombreDeCowboy = int.Parse(Console.ReadLine());
            cowboys.Groupe = new Cowboy[nombreDeCowboy];
            for (int i = 0; i < nombreDeCowboy; i++)
            {
               

                
                cowboys.Groupe[i] = new Cowboy();
                Console.Write("Le nom du cowboy : ");
                cowboys.Groupe[i].Nom = Console.ReadLine();
                Console.Write("Le poids du cowboy : ");
                cowboys.Groupe[i].Poids = int.Parse(Console.ReadLine());
                Console.Write("La vitesse du cowboy : ");
                cowboys.Groupe[i].Vitesse = double.Parse(Console.ReadLine());
            }

            //var res =  cowboys.Groupe.OrderBy(x=>x.Poids); Trier les cowboys via une expression lambda
            //res.OrderBy(x => x.Vitesse);Trier les cowboys via une expression lambda
            return cowboys.Groupe;

        }

        public override string ToString()
        {
            string res = String.Format("Voici le nom du cowboy {0}", this.Nom);
            
            return base.ToString(); 
        }

      
 

    }
}

namespace Cowboy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Traverser
    {
        public double Temps { get; set; }
        public int Rotation { get; set; }
        List<Cowboy> CowboysPlusLeger { get; set; }
        List<Cowboy> CowboysPlusRapides { get; set; }
        Objet pont = new Pont();


     

      public Cowboy[] TrierManuellementLesCowboys(Cowboy[] cowboys)
        {
            for (int i = 1; i < cowboys.Count(); i++)
            {
                double lePoidDuCowboyActuel = cowboys[i].Poids;
                
                Cowboy cowBoyActuel = cowboys[i];

                int j = i;

                while (j > 0 && cowboys[j-1].Poids> lePoidDuCowboyActuel)
                {
                    cowboys[j] = cowboys[j - 1];
                    j = j - 1;

                  
                }
                cowboys[j] = cowBoyActuel;

            }
            return cowboys;
        }


        public int PoidTotaleDesCowboys(Cowboy[] cowboys,Pont p)
        {
            int ab = 0;
            for (int z = 0; z < cowboys.Length; z++)
            {
                ab += cowboys[z].Poids;
            }



            return ab;

        }

        public double calculeDuTemps(List<Cowboy> lesCowboys,Pont p)
        {
            double calcul = 0.0;
            double calculerLeTemps = 0.0;
            for (int i = 0; i < lesCowboys.Count; i++)
            {
                calcul += lesCowboys[i].Vitesse;
             
            }
            calcul = calcul / lesCowboys.Count;
            
            calculerLeTemps = p.Longueur / calcul;
            return calculerLeTemps;
        }

        public List<Cowboy> nombreDeGroupeQuiPeutTraverserLePont(List<Cowboy> cowboys, Pont pont)
        {
            var cowboyQuiTraverse = new List<Cowboy>();
            int nombre = 0;
            int compteurDuPoids = 0;
            
            List<Cowboy> converti = cowboys.ToList();
            var cowboyLePlusLeger = converti[0];
            //converti.Add(cowboyLePlusLeger);
            cowboyQuiTraverse.Add(cowboyLePlusLeger);
            compteurDuPoids = cowboyLePlusLeger.Poids;
          
            for (int i = 1; i < converti.Count; i++)
            {
                if (converti.Count==1)
                {
                    return cowboyQuiTraverse;
                
                }

                int k =i;
                while (compteurDuPoids<pont.PoidsSupporte && k<converti.Count && compteurDuPoids+converti[k].Poids <= pont.PoidsSupporte )
                {
                    cowboyQuiTraverse.Add(converti[k]);
                    compteurDuPoids += cowboys[k].Poids;
                    converti.RemoveAt(k);
                     


                    if (k<cowboyQuiTraverse.Count)
                    {
                        k++;
                    }              

                }                   
            }
            compteurDuPoids = 0;
            if (cowboyQuiTraverse.Count==1)
            {
                int tours = 1;
                Console.WriteLine("Attention !!! Une personne peut traverser le pont à la fois !", tours);
                Console.WriteLine(  );
                Console.WriteLine();
                tours = 0;
                double temps = calculeDuTemps(cowboyQuiTraverse, pont);
                double val = Math.Round(temps, 4);
                Console.WriteLine("Le temps qu il faut pour traverser le pont est de : "+ val.extentionDoubleHeure()+ "heures et "+ val.extentionMinute()+ " minutes");

                cowboys.RemoveAt(0);
            }
            return cowboyQuiTraverse;
        }


    }
}

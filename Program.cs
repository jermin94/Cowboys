namespace Cowboy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

            Cowboy Joueur = new Cowboy();        
     
             var lesCowboys =  Joueur.RecupererLinfoDuCowboy();
            Traverser traver = new Traverser();
            var cowboysTries = traver.TrierManuellementLesCowboys(lesCowboys);

         

            
            Pont p = new Pont();
            Console.Write("Le poids que le pont peut supporter ? :");
             p.PoidsSupporte = int.Parse(Console.ReadLine());
            Console.Write("La longueur du pont en kilometres  : ");
           p.Longueur = double.Parse(Console.ReadLine());
            var poidsTotaleDesCowboys = traver.PoidTotaleDesCowboys(lesCowboys,p);
           
            if (poidsTotaleDesCowboys < p.PoidsSupporte)
            {
                List<Cowboy> cowboysConverti2 = lesCowboys.ToList();
                int lesTours = 1;
               
                Console.WriteLine("Le poids totale des cowboys, {0} est suffisant pour traverser le pont en une fois : ", poidsTotaleDesCowboys);
                var letempsPourEquipe = traver.calculeDuTemps(cowboysConverti2, p);
                Console.WriteLine("Sur le pont " + cowboysConverti2.Count + " cowboys peuvent traverser!!! ");
                double val = Math.Round(letempsPourEquipe, 4);
                Console.WriteLine("Le temps qu il faut pour traverser le pont est de : " + val.extentionDoubleHeure() + "heures et " + val.extentionMinute() + " minutes");

            }
            else if (lesCowboys[0].Poids > p.PoidsSupporte)
            {
                Console.WriteLine("Le pont ne peux meme pas supporter une personne! Donc personne peut traverser !!!");

            }
            else
            {
            List<Cowboy> CowboysConverti = cowboysTries.ToList();
            int lesTours = 0;              
            Cowboy t = new Cowboy();
            var groupeQuiTraverse = new List<Cowboy>();
            List<Cowboy> cowboyTries1 = cowboysTries.ToList();
            int compteurDestours = 0;
        
            while (cowboyTries1.Count>1)
                {              
                
                var groupeDeCowboys = traver.nombreDeGroupeQuiPeutTraverserLePont(cowboyTries1, p);

               
                if (groupeDeCowboys.Count==1)
                {                   
                    cowboyTries1.RemoveRange(0,1);
                  
                    //Console.WriteLine("Ca fait " + lesTours + " tours");
                    lesTours = 1;
                    var letempsPourEquipe = traver.calculeDuTemps(groupeDeCowboys, p);
                    Console.WriteLine("Sur le pont " + lesTours + " cowboys peuvent traverser!!! ");
                    double val = Math.Round(letempsPourEquipe, 4);
                    Console.WriteLine("Le temps qu il faut pour traverser le pont est de : "+ val.extentionDoubleHeure()+ "heures et "+ val.extentionMinute()+ " minutes");

                    lesTours = 0;
                }
                else if(groupeDeCowboys.Count>1)
                {
                    lesTours += groupeDeCowboys.Count;
                    var letempsPourEquipe = traver.calculeDuTemps(groupeDeCowboys,p);
                    cowboyTries1.RemoveRange(1, groupeDeCowboys.Count-1);
                    Console.Write("Sur le pont "+lesTours+" cowboys peuvent traverser!!! ");
                    lesTours = 0;
                    compteurDestours += 1;
                    Console.WriteLine("Ca fait "+compteurDestours+" tours");
                    double val = Math.Round(letempsPourEquipe, 4);
                    string tempsEnHeure = val.extentionDoubleHeure();
                    Console.WriteLine("Le temps qu il faut pour traverser le pont est de : "+ tempsEnHeure+ "heures et "+val.extentionMinute()+" minutes");
                }
          
            }









            }



             Console.ReadLine();

        }
     
    }
}

using System;

namespace Rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            
             string bababooey, Protivnik;

            int idkhovno;

            string moretonevim;

            bool staleHrat = true;


                            while (staleHrat)


            {

                int Vyhrose = 0;


                int Prohry = 0;


                int Remizy = 0;


                            while (staleHrat)




                {

                    Random FialovejMonsterProKubu = new Random();

                    idkhovno = FialovejMonsterProKubu.Next(1, 4);
                                        Console.Write("Zadej jednu z moznosti RSP: R = Rock, Zadej S = Scissors, Zadej P = Paper. ");


                    bababooey= Console.ReadLine();
                    bababooey = bababooey.ToUpper();

                    
                    
                    
                                switch (idkhovno)

                    {

                                    case 1:

                            Protivnik = "Rock";


                            Console.WriteLine("Tvuj protivnik zahral KAMEN PICO");
                            
                            
                                    if (bababooey == "R")
                            {
                                
                                Console.WriteLine("Remiza");
                                Remizy++;
                            }



                            else if (bababooey == "P")
                            {
                                
                                Console.WriteLine("Vyhral jsi, pekne pekne");
                                Vyhrose++;
                            }
                            
                            
                            else if (bababooey == "S")
                            {
                                
                                Console.WriteLine("Tvuj protivnik ti rozmrdal prdel ");
                                Prohry++;
                            }
                            


                            
                            break;




                                    case 2:
                            Protivnik = "Paper";

                            Console.WriteLine("Tvuj protivnik zahral papiros");
                            
                            
                                    if (bababooey == "P")
                            {
                                
                                Console.WriteLine("ajjj Remizos");
                                Remizy++;
                            }
                            
                            
                            else if (bababooey == "R")
                            {
                               
                                Console.WriteLine("Dostal jsi pres picu :(");
                                Prohry++;
                            }
                            
                            
                            else if (bababooey == "S")
                            {
                                
                                Console.WriteLine("VYHRAL JSI LETSGGOOOO");
                                Vyhrose++;
                            }
                            
                            


                            break;




                                    case 3:
                            Protivnik = "Scissors";

                            Console.WriteLine(" Tvuj protivnik zahral nuzky");

                            
                            
                                    if (bababooey == "S")

                            {

                                
                                Console.WriteLine("Remiza (-_-)");
                                Remizy++;

                            }
                            
                            
                            else if (bababooey == "R")
                            {

                                
                                Console.WriteLine("Vyhral jsi, serife");
                                Vyhrose++;

                            }
                            
                            
                            else if (bababooey == "P")
                            {

                                
                                Console.WriteLine("damn, jses spatnej sorry");
                                Prohry++;

                            }




                            break;
                            
                    
                                       
                            }

                        Console.WriteLine("Skóre:\nVyhry:{0}\nProhry:{1}\nRemizy:{2}", Vyhrose, Prohry, Remizy);

                        Console.WriteLine("Ches hrat jeste jednou? (y/n)");
                                    moretonevim = Console.ReadLine();
                           if (moretonevim == "y")
                    {
                                staleHrat = true;

                    }
                    
                    
                    else if (moretonevim == "n")


                    {
                                staleHrat = false;
                    }
                    
                    
                    else


                    {

                    }

                }

            }

        }
    }
}

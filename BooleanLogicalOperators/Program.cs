using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus;
            //Programm küsib kasutajal sisestada parool;
            //Programm kontrollib, kas mõlemad, nii kasutajatunnus
            //kui ka paool on õiged
            //kui mõlemad, kasutajatunnus ja parool on õiged
            //Programm kuvab konsoolis "Tere tulemast"
            //kui kasutajatunnus või parool on vale, siis 
            //Programm kuvab "sisselogimine ebaõnnestus. Proov uuesti"
            //Kt: Admin, pr:admin12345
            


            Console.WriteLine("Palun sisestada kasutajatunnus");
                string Kasutajatunnus = Console.ReadLine();
            Console.WriteLine("Palun sisesta parool");
            string Kasutajaparool = Console.ReadLine();

            if(Kasutajatunnus == "Admin" && Kasutajaparool == "Admin12345")
            
                //  &&  V; on selleks, et kontrollida kas kumbgi on vale. Kui kumbgi on vale siis võtab else commandi
            
            {
                Console.WriteLine("Tere Tulemast!");
            }
            else
            {
                Console.WriteLine("sisselogimine ebaõnnestus, proovi uuesti!");
            }










        }
    }
}

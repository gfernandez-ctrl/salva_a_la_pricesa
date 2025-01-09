using System;
using System.Collections.Generic;



class x
{
    static void Main()
    {
        
        string[] armes = new string[]
        {
            "Escut", "Casc", "Espasa", "Escut", "Espasa", "Casc", "Armadura", "Llança", "Escut", "Escut", "Casc", 
            "Armadura", "Escut", "Llança", "Espasa", "Escut", "Llança", "Escut", "Espasa", "Casc", "Casc", "Escut", 
            "Espasa", "Llança", "Llança", "Espasa", "Armadura", "Escut", "Escut", "Armadura", "Armadura", "Llança", 
            "Armadura", "Espasa", "Escut", "Casc", "Escut", "Espasa", "Armadura", "Armadura", "Casc", "Casc", "Llança", 
            "Casc", "Escut", "Escut", "Llança", "Llança", "Casc", "Espasa", "Armadura", "Casc", "Armadura", "Espasa", 
            "Llança", "Casc", "Llança", "Llança", "Espasa", "Casc", "Espasa", "Casc", "Armadura", "Casc", "Casc", 
            "Armadura", "Llança", "Escut", "Escut", "Armadura", "Llança", "Espasa", "Casc", "Llança", "Armadura", 
            "Espasa", "Casc", "Escut", "Armadura", "Llança", "Llança", "Casc", "Casc", "Espasa", "Armadura", "Escut", 
            "Armadura", "Espasa", "Armadura", "Espasa", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Casc", 
            "Llança", "Armadura", "Casc", "Armadura", "Llança", "Casc", "Escut", "Espasa", "Casc", "Casc", "Llança", 
            "Llança", "Armadura", "Casc", "Llança", "Llança", "Espasa", "Llança", "Armadura", "Casc", "Casc", "Escut", 
            "Casc", "Llança", "Casc", "Escut", "Llança", "Escut", "Espasa", "Escut", "Llança", "Armadura", "Casc", 
            "Escut", "Espasa", "Llança", "Llança", "Casc", "Escut", "Casc", "Espasa", "Escut", "Escut", "Llança", 
            "Llança", "Llança", "Llança", "Casc", "Escut", "Armadura", "Llança", "Casc", "Espasa", "Espasa",
        };

        int casc = 0;
        int escut = 0;
        int espasa = 0;
        int llança = 0;
        int armadura = 0;

        for (int i = 0; i < armes.Length; i++)
        {
            switch (armes[i])
            {
                case "Casc":
                    casc++;
                    break;
                case "Escut":
                    escut++;
                    break;
                case "Espasa":
                    espasa++;
                    break;
                case "Llança":
                    llança++;
                    break;
                case "Armadura":
                    armadura++;
                    break;
                default:
                    break;
            }
        }

        int cavaller = 0;
        int soldat = 0;
        int pages = 0;

        while (casc > 0 && armadura > 0 && escut > 0 && llança > 0)
        {
            cavaller++;
            casc--;
            armadura--;
            escut--;
            llança--;
        }
        
        while (casc > 0 && espasa > 0 && escut > 0)
        {
            soldat++;
            casc--;
            espasa--;
            escut--;
        }
        while (llança > 0)
        {
            pages++;
            llança--;
        }

        Console.Write("Es pot enviar: " + "\n");
        Console.Write("\t" + "Pagesos: " + pages + "\n");
        Console.Write("\t" + "Soldats: " + soldat + "\n");
        Console.Write("\t" + "Cavallers: " + cavaller);

    }

    
    
}
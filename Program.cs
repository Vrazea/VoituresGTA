namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void DisplayCars(string[] garage)
    {
        Console.WriteLine("véhicules du Garage : ");
        for (int i = 0; i < garage.Length; i++)
        {
            Console.WriteLine("\n"+(i+1).ToString() + "" + garage[i]);
            
        }
    }
    
    static void Main(string[] args)
    {
        String[] garage = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };

        DisplayCars(garage);
        
        Console.WriteLine(" Saisis le numéro du véhicule que tu souhaites remplacer ( 1 - 5 ) ");
        int remplacer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Quel est le nom du nouveau véhicule ? ");
        string name = Console.ReadLine();
        garage[(remplacer-1)] = name;
        
        DisplayCars(garage);
        
    }
}
using Labb_2___Kitchen_Appliance;
var kitchenAppliance = new Köksapparater();
List<string[]> apparater = new List<string[]>();


bool startMenu = true;
while (startMenu)
{
    //Skriver ut meny med vår menymetod
    PrintMenu();
    Int32.TryParse(Console.ReadLine(), out int selectedOption);
    switch (selectedOption)
    {
        //Använd köksapparat
        case 1:

            break;

        //Lägg till en köksapparat
        case 2:
            break;

        //Lista köksapparater
        case 3:
            break;

        //Ta bort kökapparat
        case 4:
            break;

        //Stäng av programmet
        case 5:
            startMenu = false;
            break;

            //Visar något vid felinmatning
        default:
            Console.WriteLine("Error, lär dig läsa menyn!");
            break;
    }
}

void PrintMenu()
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\t=======Menu=======" +
    "\n\t1. Use Appliance" +
    "\n\t2. Add Kitchen Appliance" +
    "\n\t3. List Kitchen Appliances" +
    "\n\t4. Remove Appliance" +
    "\n\t5. Exit" +
    "\n\t>");
}
void ApplianceUsage(List<string> list)
{
    Console.WriteLine("Which appliance would you like to use?");
    
}
void AddUserInputAppliance()
{

}
string[] AddAppliance(string Type, string Brand)
{

}
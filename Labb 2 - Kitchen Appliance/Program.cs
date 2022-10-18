using Labb_2___Kitchen_Appliance;
var kitchenAppliance = new Köksapparater("", "", false);
var kitchenApplianceDummy = new Köksapparater("Beater", "New Brand", false);
var kitchenApplianceDummy2 = new Köksapparater("Microwave Oven", "Nuclear Blast", true);
List<Köksapparater> apparater = new List<Köksapparater>() { };
apparater.Add(kitchenApplianceDummy2);
apparater.Add(kitchenApplianceDummy);
string input = "";
bool startMenu = true, search = false, found = false;
while (startMenu)
{
    //Skriver ut meny med vår menymetod
    PrintMenu();
    Int32.TryParse(Console.ReadLine(), out int selectedOption);
    switch (selectedOption)
    {
        //Använd köksapparat
        case 1:
            ApplianceUsage();
            break;
        //Lägg till en köksapparat
        case 2:
            AddUserInputAppliance();
            break;
        //Lista köksapparater
        case 3:
            ListAllAppliances();
            break;
        //Ta bort kökapparat
        case 4:
            RemoveAppliance();
            break;
        //Stäng av programmet
        case 5:
            startMenu = false;
            break;
        //Visar något vid felinmatning
        default:
            Console.Write("\n\tError, learn to read the menu!");
            break;
    }
}
void PrintMenu()
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("\n\t=======Menu=======" +
    "\n\t1. Use Appliance" +
    "\n\t2. Add Kitchen Appliance" +
    "\n\t3. List Kitchen Appliances" +
    "\n\t4. Remove Appliance" +
    "\n\t5. Exit" +
    "\n\t>");
}
void ApplianceUsage()
{
    ListAllAppliances();
    Console.Write("\tWhich appliance would you like to use? (type or brand)" + "\n\t>");
    input = Console.ReadLine();
    search = true;
    found = false;
    while (search)
    {
        foreach (var appliance in apparater)
            if (input.ToLower() == appliance.Type.ToLower() || input.ToLower() == appliance.Brand.ToLower() && appliance.IsFunctioning == true)
            {
                Console.Write("\tYou are now using " + appliance.Type + ".");
                search = false;
                found = true;
            }
            else if (input.ToLower() == appliance.Type.ToLower() || input.ToLower() == appliance.Brand.ToLower() && appliance.IsFunctioning == false)
            {
                Console.WriteLine("\tThe " + appliance.Type + " that you are trying to use is broken");
                search = false;
                found = true;
            }
        search = false;
    }
    if (!found) Console.Write("\tNot found!");
}
void AddUserInputAppliance()
{
    bool broken = true;
    Console.Write("\tWhat kind of appliance is it?\n\t>");
    string type = Console.ReadLine();
    Console.Write("\tWhat kind of brand is it?\n\t>");
    string brand = Console.ReadLine();
    bool isFunc = true;
    while (isFunc)
    {
        Console.Write("\tIs it working? (j/n)\n\t>");
        string func = Console.ReadLine();

        if (func == "j".ToLower())
        {
            broken = false;
            isFunc = false;
        }
        else if (func == "n".ToLower())
        {
            broken = true;
            isFunc = false;
        }
        else
            Console.Write("\n\tYou need to input j or n");
    }
    kitchenAppliance = new Köksapparater(type, brand, broken);
    apparater.Add(kitchenAppliance);
}
void ListAllAppliances()
{
    foreach (var appliance in apparater)
        if (appliance.IsFunctioning == true)
        {
            Console.Write("\n\tAppliance type: " + appliance.Type +
            "\n\tBrand: " + appliance.Brand +
            "\n\tbut it is broken." +
            "\n\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
        else if (appliance.IsFunctioning == false)
        {
            Console.Write("\n\tAppliance type: " + appliance.Type +
            "\n\tBrand: " + appliance.Brand +
            "\n\tit works, woopdidoo!" +
            "\n\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
}
void RemoveAppliance()
{
    ListAllAppliances();
    Console.Write("\tWhich appliance would you want to remove? (type or brand) \n\t>");
    input = Console.ReadLine();
    search = true;
    while (search)
    {
        foreach (var appliance in apparater)
            if (input.ToLower() == appliance.Type.ToLower() || input.ToLower() == appliance.Brand.ToLower() && appliance.IsFunctioning == true)
            {
                Console.Write("\t" + appliance.Type + " is now removed");
                apparater.Remove(appliance);
                search = false;
                found = true;
                break;
            }
        search = false;
    }
    if (!found) Console.Write("\tNot found!");
}

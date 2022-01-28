// See https://aka.ms/new-console-template for more information
Console.WriteLine("'ate orks");
Console.WriteLine("'ate elves");

string[] armor = initializeArmor();
string[] units = initializeUnits();
string[] weapons = initializeWeapons();

static string[] initializeArmor(){
    string[] list = {};

    return list;
}

static string[] initializeUnits(){   
    string[] list = {
        "Battalion",
        "Brigade",
        "Company",
        "Division",
        "Guard",
        "Hunters",
        "Legion",
        "Rangers",
        "Regiment",
        "Shooters",
        "Skirmishers",
        "Squadron",
        "Watch"
    };

    return list;
}

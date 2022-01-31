// Initialize things to choose from
string[] units = initializeGeneralUnits();
string[] melee = initializeMelee();
string[] blunt = initializeBlunt();
string[] cut = initializeCut();
string[] pierce = initializePierce();
string[] ranged = initializeRanged();
string[] adjectives = initializeAdjectives();

// Console.WriteLine("Specify or leave empty for total random.");
// System.Console.WriteLine("-w [weapontype] for weapon type");

Random rnd = new Random();
units = units.Concat(melee).ToArray();
units = units.Concat(blunt).ToArray();
units = units.Concat(cut).ToArray();
units = units.Concat(pierce).ToArray();
units = units.Concat(ranged).ToArray();
int iUnit = rnd.Next(0, units.Length);
int iAdjective = rnd.Next(0, adjectives.Length);

System.Console.WriteLine("1. {0} {1}", adjectives[iAdjective], units[iUnit]);


static string[] initializeGeneralUnits(){   
    string[] list = {
        "[weapon the squad uses]",
        "Battalion",
        "Brigade",
        "Company",
        "Division",
        "Fighters",
        "Fists",
        "Guard",
        "Hands",
        "Helmets",
        "Killers",
        "Legion",
        "Marauders",
        "Raiders",
        "Regiment",
        "Scars",
        "Soldiers",
        "Sons",
        "Squadron",
        "Volunteers",
        "Wardens",
        "Warriors",
        "Watch"
    };

    return list;
}

static string[] initializeMelee(){   
    string[] list = {
        "Bearers",
        "Brawlers",
        "Holders",
        "Linebreakers",
        "Lineholders",
        "Shields",
        "Stormers"
    };

    return list;
}

static string[] initializeBlunt(){   
    string[] list = {
        "Bashers",
        "Breakers",
        "Bruisers",
        "Crushers",
        "Smashers"
    };

    return list;
}

static string[] initializeCut(){   
    string[] list = {
        "Cutters",
        "Choppers",
        "Slashers"
    };

    return list;
}

static string[] initializePierce(){   
    string[] list = {
        "Porcupines"
    };

    return list;
}

static string[] initializeRanged(){   
    string[] list = {
        "Arbalists",
        "Arrows",
        "Bolts",
        "Hunters",
        "Marksdwarves",
        "Quarrellers",
        "Rangers",
        "Shooters",
        "Skirmishers",
        "Stalkers"
    };

    return list;
}

static string[] initializeAdjectives(){   
    string[] list = {
        "[Current leader of the fort's]",
        "[First expedition leader's]",
        "[Fort name's]",
        "[Squad leader's]",
        "Black",
        "Brave",
        "Brown",
        "Blue",
        "Golden",
        "Green",
        "Grey",
        "Iron",
        "Metal",
        "Orange",
        "Red",
        "Shining",
        "Silver",
        "Steel",
        "White",
        "Yellow"
    };

    return list;
}

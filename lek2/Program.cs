Skill attack = new()
{
Name = "Attack enemy",
ManaCost = 10

    
};

Skill heal = new(){

    Name = "Heal self",
    ManaCost = 20
};

Skill active = attack;

Player p1 = new Player();


Console.WriteLine("Skriv ditt namn");
string n = Console.ReadLine();
Console.WriteLine(n);

Console.WriteLine(active.Name);
Console.ReadLine();


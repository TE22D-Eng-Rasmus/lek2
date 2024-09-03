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

Console.WriteLine(active.Name);
Console.ReadLine();


public class Player
{
public string _name = " ";
public string GetName()
{
return _name;    
}

public int strength = 0;

public Player()
  {
    strength = Random.Shared.Next(5,10);
  }
}


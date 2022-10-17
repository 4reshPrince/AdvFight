using System;

Fighter hero = new Fighter();
hero.name = "HERO";
hero.weapon = new Weapon();
hero.weapon.name = "Dark sword";

Fighter villain = new Fighter();
villain.name = "VILLAIN";
villain.weapon = new Weapon();
villain.weapon.name = "Bright sword";


Random generator = new Random();

while (hero.hp > 0 && villain.hp > 0)
{
  Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
  Console.WriteLine($"{hero.name}: {hero.hp} || {villain.name}: {villain.hp}\n");

  hero.Attack(villain);
  villain.Attack(hero);

  Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (hero.hp == 0 && villain.hp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (hero.hp == 0)
{
  Console.WriteLine($"{villain.name} vann!");
}
else
{
  Console.WriteLine($"{hero.name} vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();
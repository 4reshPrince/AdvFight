using System;

Fighter hero = new Fighter();
hero.name = "Magnus Chase";
hero.weapon = new Weapon();
hero.weapon.name = "Sword of Summer";

Fighter villain = new Fighter();
villain.name = "Ares";
villain.weapon = new Weapon();
villain.weapon.name = "Ares Sword";


Random generator = new Random();

Console.WriteLine("----- ===== Welcome To Fight Round ===== -----");
Console.WriteLine("----- ===== Press button to Start ===== -----");
Console.ReadKey();
Console.Clear();

while (hero.hp > 0 && villain.hp > 0)
{
  Console.WriteLine("\n----- ===== New Round ===== -----");
  Console.WriteLine($"{hero.name}: {hero.hp} || {villain.name}: {villain.hp}\n");

  hero.Attack(villain);
  villain.Attack(hero);

  Console.WriteLine("Press button to continue. ");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== Fight Over ===== -----");

if (hero.hp == 0 && villain.hp == 0)
{
  Console.WriteLine("Draw");
}
else if (hero.hp == 0)
{
  Console.WriteLine($"{villain.name} Winner!");
}
else
{
  Console.WriteLine($"{hero.name} Winner!");
}

Console.WriteLine("Press button to Exit. ");
Console.ReadKey();
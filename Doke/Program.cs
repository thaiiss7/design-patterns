using Doke.Pokedex;
using Doke.Pokedex.Models;

List<Attack> necrozmaAttacks = new List<Attack>();

var photonGeyser = new Attack("Photon Geyser", 10, Doke.Pokedex.Enum.PokemonType.Psychic);
var prismaticLaser = new Attack("Prismatic Laser", 16, Doke.Pokedex.Enum.PokemonType.Psychic);
var nightSlash = new Attack("Night Slash", 7, Doke.Pokedex.Enum.PokemonType.Dark);
var ironDefense = new Attack("Iron Defense", 0, Doke.Pokedex.Enum.PokemonType.Steel);
var lightThatBurnstheSky = new Attack("Light That Burns the Sky", 20, Doke.Pokedex.Enum.PokemonType.Psychic);

necrozmaAttacks.Add(photonGeyser);
necrozmaAttacks.Add(prismaticLaser);
necrozmaAttacks.Add(nightSlash);
necrozmaAttacks.Add(ironDefense);
necrozmaAttacks.Add(lightThatBurnstheSky);

var necrozma = new Pokemon();
necrozma.Name = "Necrozma";
necrozma.Hp = 97;
necrozma.Type = Doke.Pokedex.Enum.PokemonType.Psychic;
necrozma.Attacks = necrozmaAttacks;

List<Attack> squirtleAttacks = new List<Attack>();

var waterGun = new Attack("Water Gun", 4, Doke.Pokedex.Enum.PokemonType.Water);
var withdraw = new Attack("Withdraw", 0, Doke.Pokedex.Enum.PokemonType.Water);
var bubbleBeam = new Attack("Bubble Beam", 6, Doke.Pokedex.Enum.PokemonType.Water);
var rapidSpin = new Attack("Rapid Spin", 5, Doke.Pokedex.Enum.PokemonType.Normal);
var hydroPump = new Attack("Hydro Pump", 11, Doke.Pokedex.Enum.PokemonType.Water);

squirtleAttacks.Add(waterGun);
squirtleAttacks.Add(withdraw);
squirtleAttacks.Add(bubbleBeam);
squirtleAttacks.Add(rapidSpin);
squirtleAttacks.Add(hydroPump);

var squirtle = new Pokemon();
squirtle.Name = "Squirtle";
squirtle.Hp = 44;
squirtle.Type = Doke.Pokedex.Enum.PokemonType.Water;
squirtle.Attacks = squirtleAttacks;

List<Attack> dittoAttacks = new List<Attack>();

var transform = new Attack("Transform", 0, Doke.Pokedex.Enum.PokemonType.Psychic);

dittoAttacks.Add(transform);

var ditto = new Pokemon();
ditto.Name = "Ditto";
ditto.Hp = 48;
ditto.Type = Doke.Pokedex.Enum.PokemonType.Normal;

Console.WriteLine(new string('=',40) + "Poke Battle!" + new string('=',40));

while (true)
{
    var attackindex1 = Random.Shared.Next(0, 4);
    var attackindex2 = Random.Shared.Next(0, 4);

    Console.WriteLine(squirtle.Name + " | " + necrozma.Name);
    Console.WriteLine("Used: " + squirtle.Attacks[attackindex1].Name + " | " + "Used: " + necrozma.Attacks[attackindex2].Name);
    Console.WriteLine("Hp: " + squirtle.Hp + " | " + "Hp: " + necrozma.Hp);

    squirtle.Hp -= necrozma.Attacks[attackindex2].Damage;
    necrozma.Hp -= squirtle.Attacks[attackindex1].Damage;

    for (int i = 0; i <= 20; i++)
        Console.Write("-");
    Console.WriteLine("\n");

    if (!squirtle.IsAlive() || !necrozma.IsAlive())
    {
        Console.WriteLine("Game Over!!");
        Console.WriteLine("Hp: " + squirtle.Hp + " | " + "Hp: " + necrozma.Hp);
        break;
    }
}


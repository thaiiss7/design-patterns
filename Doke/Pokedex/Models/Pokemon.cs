using Doke.Pokedex.Enum;

namespace Doke.Pokedex.Models;

public class Pokemon
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Hp { get; set; }
    public PokemonType Type { get; set; }
    public List<Attack> Attacks { get; set; } = [];

    public bool IsAlive()
    {
        if(Hp <= 0)
            return false;

        return true;
    }
}


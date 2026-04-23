using Doke.Pokedex.Models;

namespace Doke.Pokedex;

public interface IStrategy
{
    void execute(Pokemon attacker, Pokemon target);
}
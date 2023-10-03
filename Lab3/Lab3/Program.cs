using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;
using Lab3.Models;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string database = "C:\\Users\\Owner\\source\\repos\\Lab3\\Lab3\\Data\\data.db";
            


            var test = new Pokemon() { Id = 1, DexNumber = 1, Name = "Gary", Form = "", Type1 = "Normal", Type2 = "", Total = 600, HP = 100, Attack = 100, Defense = 100, SpecialAttack = 100, SpecialDefense = 100, Speed = 100, Generation = 9 };
            var bannedgames = new BannedGame() { Id = 1, Title = "Game Title", Series = "Game Series", Country = "All", Details = "Was really boring"};

            var pokemons = new List<Pokemon>()
            {
                new Pokemon() { Id = 1, DexNumber = 1, Name = "Gary", Form = "", Type1 = "Normal", Type2 = "", Total = 600, HP = 100, Attack = 100, Defense = 100, SpecialAttack = 100, SpecialDefense = 100, Speed = 100, Generation = 9},
                new Pokemon() { Id = 2, DexNumber = 2, Name = "Larry", Form = "", Type1 = "Fighting", Type2 = "", Total = 600, HP = 100, Attack = 100, Defense = 100, SpecialAttack = 100, SpecialDefense = 100, Speed = 100, Generation = 9},
                new Pokemon() { Id = 3, DexNumber = 3, Name = "Barry", Form = "", Type1 = "Flying", Type2 = "", Total = 600, HP = 100, Attack = 100, Defense = 100, SpecialAttack = 100, SpecialDefense = 100, Speed = 100, Generation = 9 }
            };

            var bannedlist = new List<BannedGame>()
            {
                new BannedGame() { Id = 1, Title = "Game Title", Series = "Game Series", Country = "All", Details = "Was really boring"},
                new BannedGame() { Id = 2, Title = "Game Title 2", Series = "Game Series", Country = "All", Details = "Was really boring, but they still made a second one"},
                new BannedGame() { Id = 3, Title = "NOT a Game Title", Series = "NOT a Game Series", Country = "USA", Details = "Was a little TOO fun"}
            };

           QueryBuilder queryb = new QueryBuilder(database);
           
            queryb.DeleteAll<BannedGame>();
            queryb.DeleteAll<Pokemon>(); 
           
            foreach (var p in pokemons)
            {
                queryb.Create<Pokemon>(p);
            }

           // queryb.Create<Pokemon>(test);
           // queryb.Create<BannedGame>(bannedgames);

            //ReadLine();
        }
    }
}
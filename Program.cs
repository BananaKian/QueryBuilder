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
            var testID = 0;



            var testList = new Pokemon() { Id = 1046, DexNumber = 1046, Name = "Gary", Form = "", Type1 = "Normal", Type2 = "", Total = 600, HP = 100, Attack = 100, Defense = 100, SpecialAttack = 100, SpecialDefense = 100, Speed = 100, Generation = 9 };
           


            QueryBuilder queryb = new QueryBuilder(database);

            string test = "";

            List<Pokemon> pk1 = new();

            pk1 = queryb.ReadAll<Pokemon>();
            var pk2 = queryb.Read<Pokemon>(3);

            Pokemon testDel = queryb.Delete<Pokemon>(); 

          //  Pokemon allDelete = queryb.DeleteAll<Pokemon>();

            foreach (var e in pk1)
            {
                WriteLine($"{e.Id} {e.DexNumber} {e.Name} {e.Form} {e.Type1} {e.Type2} {e.Total} {e.HP} {e.Attack} {e.Defense} {e.SpecialAttack} {e.SpecialDefense} {e.Speed} {e.Generation}");
            }
            WriteLine(pk2.Name);
            ReadLine();
        }
    }
}
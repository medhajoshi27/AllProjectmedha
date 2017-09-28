using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {

        public class Galaxy
        {
            public string Name { get; set; }
            public string Dept { get; set; }
        }
        // var salmons = new List<string>();
        // salmons.Add("Joey");
        // salmons.Add("Chandler");
        // salmons.Add("Monika");
        // salmons.Add("Rachel");


        //  foreach (var salmon in salmons)
        // {
        //  Console.Write(salmon + " ");
        //   }
        static void Main(string[] args)
       
        {
            var theGalaxies = new List<Galaxy>
        {
            new Galaxy() { Name="joey", Dept="HR"},
            new Galaxy() { Name="Chandler", Dept="IS"},
            new Galaxy() { Name="ross",Dept="Software"},
            new Galaxy() { Name="pheebs", Dept="HR"}
        };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.Dept);
            }
       
        Console.ReadLine();
        }
    }
}
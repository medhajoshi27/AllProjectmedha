using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplication12
{
    public class Manufacturer
    {
        public string Headquarters;
        public string Name;
        public int Year;
    }

public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            /*  var q = File.ReadAllLines(@"C:\Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication12\ConsoleApplication12\fuel.csv")
                         .Skip(1)
               .Where(c => c.Length > 1)
                         .Select(c => c);
              foreach (var car in q.Take(10))
              { Console.WriteLine(car); }
              var q2 = File.ReadAllLines(@"C:\Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication12\ConsoleApplication12\manufacturer.csv")
                                 .Where(l => l.Length > 1)
                                 .Select(l =>
                                 {
                                     var columns = l.Split(',');
                                     return new Manufacturer
                                     {
                                         Name = columns[0],
                                         Year = int.Parse(columns[2])
                                     };

                                 });

              foreach (var m in q2)
              {
                  Console.WriteLine(" " + m.Name + " " + m.Year);
              }*/

              var cars = ProcessCars("fuel.csv");
               var manufacturers = ProcessManufacturers("manufacturers.csv");

         /*   var query1 = cars.GroupBy(c => c.Manufacturer.ToUpper())
                      .OrderBy(m => m.Key);
               foreach (var grp in query1)
               {
                   Console.WriteLine(grp.Key);
                   foreach (var car in grp.OrderByDescending(c => c.Combined).Take(3))
                   { Console.WriteLine($"{car.Name} : {car.Combined}"); }
               }*/
           var query = cars.Join(manufacturers,
                                        c => c.Manufacturer,
                                        m => m.Name, (c, m) => new
                                        {
                                            m.Headquarters,
                                            m.Name,
                                            c.Combined

                                        })
                                    .OrderByDescending(c => c.Combined)
                                    .ThenBy(c => c.Name);

                foreach (var car in query.Take(10))
                {
                    Console.WriteLine($"{car.Headquarters} {car.Name} : {car.Combined}");

                }

            Console.ReadLine();
        }
    
        private static List<Manufacturer> ProcessManufacturers(string path)
        {
            var query =
                     File.ReadAllLines(@"C:\Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication12\ConsoleApplication12\manufacturer.csv")
                    .Where(l => l.Length > 1)
                    .Select(l =>
                    {
                        var columns = l.Split(',');
                        return new Manufacturer
                        {
                            Name = columns[0],
                            Headquarters = columns[1],
                            Year = int.Parse(columns[2])
                        };
                    });
            return query.ToList();
        }
        private static List<Car> ProcessCars(string path)
        {
            var query =

               File.ReadAllLines(@"C: \Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication12\ConsoleApplication12\fuel.csv")
                   .Skip(1)
                   .Where(l => l.Length > 1)
                   .ToCar();

            return query.ToList();

        }
    }

    public static class CarExtensions
    {
        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');

                yield return new Car
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
            }
        }
    }
}

    



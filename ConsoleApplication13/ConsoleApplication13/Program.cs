using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace taskcollection
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public phone phoneNo { get; set; }
        public int age { get; set; }
    }
      public class phone
        {
            public int home { get; set; }
            public int mobile { get; set; }

        public static implicit operator phone(int v)
        {
            throw new NotImplementedException();
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            var personList = new List<Person> {
                    new Person { Id = 101,Name = "joe", Email = "joe@exp.com",phoneNo = new phone {home= 7454919,mobile=748542 }, age = 20 },
                    new Person { Id = 102, Name = "Chandler", Email = "chandler@exp.com", phoneNo = new phone {home= 7454919,mobile=748542 },age = 27 },
                    new Person { Id = 103, Name = "Pheebs", Email = "pheebs@exp.com", phoneNo = new phone {home= 7454919,mobile=748542 }, age = 23 },
                    new Person { Id = 104, Name = "Monika ", Email= "monika@exp.com", phoneNo = new phone {home= 7454919,mobile=748542 }, age = 13 },
                    new Person { Id = 105, Name = "ross ", Email= "ross@exp.com", phoneNo = new phone {home= 7454919,mobile=748542 }, age = 21 },
                    new Person { Id = 106, Name = "rachel", Email= "rachel@exp.com",phoneNo = new phone {home= 7454919,mobile=748542 }, age = 22 },
                    new Person { Id = 107, Name = "stuart ", Email= "stuart@exp.com", phoneNo = new phone {home= 7454919,mobile=748542 }, age = 42},
                    new Person { Id = 108, Name = "kevin ", Email= "kevin@exp.com", phoneNo = new phone {home= 7454919,mobile=748542 }, age = 27 },
                    new Person { Id = 109, Name = "bob", Email= "bob@exp.com",phoneNo = new phone {home= 7454919,mobile=748542 }, age = 20 },
                    new Person { Id = 110, Name = "mini", Email= "mini@exp.com",phoneNo = new phone {home= 7454919,mobile=748542 }, age = 30}
            };
            
            try
            {
                if (!Directory.Exists(@"C:\Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication13\ConsoleApplication13\file-name.json"))
                { DirectoryInfo di = Directory.CreateDirectory(@"C:\Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication13\ConsoleApplication13\file-name.json"); }
            }
            catch (IOException ioex) 
            {
                Console.WriteLine(ioex.Message);
            }

            var f = true;
            while (f)
            {
                string json = sedr(personList);
                File.WriteAllText(@"C:\Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication13\ConsoleApplication13\file-name.json", json);
                string t = System.IO.File.ReadAllText(@"C:\Users\Humera Sheikh\Documents\Visual Studio 2015\Projects\asp.net\ConsoleApplication13\ConsoleApplication13\file-name.json");
                Console.WriteLine("{0}", t);
                Console.WriteLine("press 1 for new data");
                Console.WriteLine("press 2 for search");
                Console.WriteLine("press 3 for update");
                Console.WriteLine("press 4 to remove");
                Console.WriteLine("press 5 to display");
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("enter name of the person");
                        string nam = Console.ReadLine();
                        Console.WriteLine("enter id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter email");
                        string em = Console.ReadLine();
                        Console.WriteLine("enter phone no");
                        int ph = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter age");
                        int ag = Convert.ToInt32(Console.ReadLine());
                        personList.Add(new Person { Id = id, Name = nam, Email = em, phoneNo = ph, age = ag });
                        Console.WriteLine($"added: id={id} name={nam} Email={em} phone={ph} age={ag}");
                        break;
                    case 2:
                        Console.WriteLine("Enter name of person");
                        string name;
                        name = Console.ReadLine();
                        var pro = personList.Where(s => s.Name == name);
                        foreach (Person pr in pro)
                        {
                            Console.Clear();
                            Console.WriteLine(pr.Id + " " + pr.Name + " " + pr.Email + " " + pr.phoneNo + " " + pr.age);
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter the person ID which wants to update:");
                        var update = Convert.ToInt32(Console.ReadLine());
                        var upd = personList.FirstOrDefault(u => u.Id == update);
                        Console.WriteLine("Enter new phone no");
                        int pho = Convert.ToInt32(Console.ReadLine());
                        upd.phoneNo = pho;
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter the product_id which wants to delete:");
                        var remove = Convert.ToInt32(Console.ReadLine());
                        var rem = personList.Where(sa => sa.Id == remove).ToList<Person>();

                        foreach (var r in rem)
                        {
                            personList.Remove(r);
                        }

                        Console.WriteLine("Record deleted");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Displaying all products:");
                        foreach (var l in personList)
                        {
                            Console.WriteLine(l.Id + " " + l.Name + " " + l.Email + " " + l.phoneNo + " " + l.age);
                        }
                        Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static string sedr(List<Person> personList)
        {
            return JsonConvert.SerializeObject(personList, Formatting.Indented);
        }
    }
}
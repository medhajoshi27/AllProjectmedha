using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;
using System.IO;
using System.Collections;
using System.Reflection;


namespace myfirstprogram
{

    class product
    {
        public string name { get; set; }

        public string brand { get; set; }
        public int id { get; set; }
        public int price { get; set; }
    }
   
    
    class Common
    {
        private List<product> Info;

        public void create()
        {
            List<product> prd = GetInfo();
            ObjectDumper.Write(Info);
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            if (name == "monitor")
            {
                var x = Info.Where(c => c.name == "monitor");
                ObjectDumper.Write(x);
            }
            if (name == "cpu")
            {
                var x = Info.Where(c => c.name == "cpu");
                ObjectDumper.Write(x);
            }
            if (name == "mobile")
            {
                var x = Info.Where(c => c.name == "mobile");
                ObjectDumper.Write(x);
            }
            if (name == "laptop")
            {
                var x = Info.Where(c => c.name == "laptop");
                ObjectDumper.Write(x);
            }
            if (name == "mouse")
            {
                var x = Info.Where(c => c.name == "mouse");
                ObjectDumper.Write(x);
            }

  Console.ReadLine();

            Console.WriteLine("press 1 to add");
            Console.WriteLine("press 2 to search");
            Console.WriteLine("press 3 to update");
            Console.WriteLine("press 4 to delete");

           
        }
        public List<product> GetInfo()
        {
            if (Info == null)
            {
                createEntry();
            }
            return Info;
        }
        private void createEntry()
        {
            Info = new List<product>
            {

                new product {name="monitor ",brand="Acer",id=101,price=12000},
                new product {name="cpu ",brand="HP",id=102,price=60000},
                 new product {name="mobile ",brand="Motorola",id=103,price=15000},
                  new product {name="laptop",brand="Dell",id=104,price=55000},
                   new product {name="mouse",brand="HP",id=105,price=3500},
            };
        }
        class Result
        {
            static void Main(string[] args) 
            {


                Common c = new Common();
                c.create();

            }
        }
    }
}




public class ObjectDumper
{
    public static void Write(object o)
    {
        Write(o, 0);
    }

    public static void Write(object o, int depth)
    {
        ObjectDumper dumper = new ObjectDumper(depth);
        dumper.WriteObject(null, o);
    }

    TextWriter writer;
    int pos;
    int level;
    int depth;

    private ObjectDumper(int depth)
    {
        this.writer = Console.Out;
        this.depth = depth;
    }

    private void Write(string s)
    {
        if (s != null)
        {
            writer.Write(s);
            pos += s.Length;
        }
    }

    private void WriteIndent()
    {
        for (int i = 0; i < level; i++) writer.Write("  ");
    }

    private void WriteLine()
    {
        writer.WriteLine();
        pos = 0;
    }

    private void WriteTab()
    {
        Write("  ");
        while (pos % 8 != 0) Write(" ");
    }

    private void WriteObject(string prefix, object o)
    {
        if (o == null || o is ValueType || o is string)
        {
            WriteIndent();
            Write(prefix);
            WriteValue(o);
            WriteLine();
        }
        else if (o is IEnumerable)
        {
            foreach (object element in (IEnumerable)o)
            {
                if (element is IEnumerable && !(element is string))
                {
                    WriteIndent();
                    Write(prefix);
                    Write("...");
                    WriteLine();
                    if (level < depth)
                    {
                        level++;
                        WriteObject(prefix, element);
                        level--;
                    }
                }
                else
                {
                    WriteObject(prefix, element);
                }
            }
        }
        else
        {
            MemberInfo[] members = o.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance);
            WriteIndent();
            Write(prefix);
            bool propWritten = false;
            foreach (MemberInfo m in members)
            {
                FieldInfo f = m as FieldInfo;
                PropertyInfo p = m as PropertyInfo;
                if (f != null || p != null)
                {
                    if (propWritten)
                    {
                        WriteTab();
                    }
                    else
                    {
                        propWritten = true;
                    }
                    Write(m.Name);
                    Write("=");
                    Type t = f != null ? f.FieldType : p.PropertyType;
                    if (t.IsValueType || t == typeof(string))
                    {
                        WriteValue(f != null ? f.GetValue(o) : p.GetValue(o, null));
                    }
                    else
                    {
                        if (typeof(IEnumerable).IsAssignableFrom(t))
                        {
                            Write("...");
                        }
                        else
                        {
                            Write("{ }");
                        }
                    }
                }
            }
            if (propWritten) WriteLine();
            if (level < depth)
            {
                foreach (MemberInfo m in members)
                {
                    FieldInfo f = m as FieldInfo;
                    PropertyInfo p = m as PropertyInfo;
                    if (f != null || p != null)
                    {
                        Type t = f != null ? f.FieldType : p.PropertyType;
                        if (!(t.IsValueType || t == typeof(string)))
                        {
                            object value = f != null ? f.GetValue(o) : p.GetValue(o, null);
                            if (value != null)
                            {
                                level++;
                                WriteObject(m.Name + ": ", value);
                                level--;
                            }
                        }
                    }
                }
            }
        }
    }

    private void WriteValue(object o)
    {
        if (o == null)
        {
            Write("null");
        }
        else if (o is DateTime)
        {
            Write(((DateTime)o).ToShortDateString());
        }
        else if (o is ValueType || o is string)
        {
            Write(o.ToString());
        }
        else if (o is IEnumerable)
        {
            Write("...");
        }
        else
        {
            Write("{ }");
        }
    }
}

using System;



class Program
{
    static void Main(string[] args)
    {   
        // Show the user different option
        List<Entry> entries = new List<Entry>();
        string number = "0";
        Save _save=  new Save();
        Load _load= new Load();
        while (number !="5"){
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            number = Console.ReadLine();

//option 1 calling from write.cs function
            if (number== "1"){
                Entry entry = new Entry();
                entry.promptquestion();
                entries.Add(entry);
                
            
            }
            //option 2 calling from save.cs and load.cs
            else if (number=="2"){
                foreach(Entry entry in entries){
                    Console.WriteLine(" ");
                    Console.WriteLine($"Entry Data: {entry._date}");
                    Console.WriteLine($"Prompt Asked: {entry._prompt}");
                    Console.WriteLine($"Answer from User: {entry._entry}");
                    Console.WriteLine(" ");
                }
            }
            //option 3 function calling from load.cs
            else if (number=="3"){
                _load._load(entries);

            }//option 4 function calling from save.cs
            else if (number=="4"){
                _save._save(entries);

            }
            
            
        }
            

    }
}
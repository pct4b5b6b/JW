using System;

public class Save
{
    //promt the user to create a file and type the file name
    public void _save(List<Entry>entries){
        Console.WriteLine("Please entry the file name: ");

        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {// record the time and date to save with the file
            foreach(Entry entry in entries){
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._entry}");

            }
            
            
        }

    }

}
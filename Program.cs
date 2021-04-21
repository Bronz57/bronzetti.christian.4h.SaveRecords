using System;
using bronzetti.christian._4h.SaveRecord.Models;

namespace bronzetti.christian._4h.SaveRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma che serializza un file cvs in un file binario");
            ConvertitoreBinario comuniItaliani = new ConvertitoreBinario(@"Models/CodiciComuni.csv");
           try
           {
                comuniItaliani.SerializzaInFileBinario();
           }
           catch(Exception e)
           {
               Console.WriteLine(e.Message);
           }
        }
    }
}

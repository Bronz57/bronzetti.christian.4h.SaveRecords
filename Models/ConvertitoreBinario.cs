using System;
using System.Collections.Generic;
using System.IO;

namespace bronzetti.christian._4h.SaveRecord.Models
{
    class ConvertitoreBinario
    {
        public List<Comune> elencoComuni = new List<Comune>();
        public ConvertitoreBinario(string path)
        {

            using(StreamReader sr = new StreamReader(path))
            {
                while(true)
                {
                    string letto = sr.ReadLine();
                    
                    if (letto == null)
                        break;

                    string[] sottoStringa = letto.Split(',');
                    elencoComuni.Add(new Comune(sottoStringa[0], sottoStringa[1]));
                };

                sr.Close();
            }
        }

        public void SerializzaInFileBinario()
        {
            try
            {
                FileStream comuniBin = new FileStream("Comuni.bin", FileMode.OpenOrCreate);
                BinaryWriter writeBinaryComuni = new BinaryWriter(comuniBin);
                 foreach(Comune c in elencoComuni)
                    {
                        writeBinaryComuni.Seek((c.Id - 1) * 32, SeekOrigin.Begin);
                        c.Nome = c.Nome.PadRight(22);
                        writeBinaryComuni.Write(c.ToString());
                    }
            
                writeBinaryComuni.Flush();
                comuniBin.Close();
            }
            catch
            {
                throw new Exception("Si è verificato un errore");
            }
        }
        
    }
}
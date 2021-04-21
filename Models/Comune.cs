using System;
using System.Text;
namespace bronzetti.christian._4h.SaveRecord.Models
{
    class Comune
    {
        string _codiceCatastale;
        public string CodiceCatastale => _codiceCatastale;
        string _nome;
        public string Nome 
        {
            get => _nome;
            set
            {
                _nome = value;
            }
        }

        //id statico
        static int id;
        int _id;

        public int Id => _id;
        
        public Comune (string codice, string comune)
        {
            (_codiceCatastale, _nome, _id) = (codice, comune, ++id);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_nome);
            sb.Append(" "+ _codiceCatastale);
            return sb.ToString();
        }
    }
}
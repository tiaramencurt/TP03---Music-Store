using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP03posta.Models
{
    public class Disco
    {
        public string artista { get; private set; }
        public string productor { get; private set; }
        public string genero { get; private set; }
        public List<string> canciones { get; private set; }
        public int id { get; private set; }
        public string foto { get; private set; }
        public Disco(string n, string a, string p, string d)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP03posta.Models
{
    public class Disco
    {
        public string disco { get; private set; }
        public string artista { get; private set; }
        public string productor { get; private set; }
        public string genero { get; private set; }
        public List<Cancion> canciones { get; private set; }
        public int id { get; private set; }
        public string foto { get; private set; }
        public Disco(string d, string a, string p, string g, List<Cancion> c, int i, string f)
        {
            this.disco = d;
            this.artista = a;
            this.productor = p;
            this.genero = g;
            this.canciones = c;
            this.id = i;
            this.foto = f;

        }
    }
}
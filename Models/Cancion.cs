using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP03posta.Models
{
    public class Cancion
    {
        public string nombre { get; private set; }
        public string link { get; private set; }
        public Cancion(string n, string l)
        {
            this.nombre = n;
            this.link = l;
        }
    }
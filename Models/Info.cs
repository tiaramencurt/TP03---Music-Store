using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP03posta.Models
{
    public class Info
    {
        public List<Disco> listaDiscos { get; private set; }
        public Info(List<Disco> lD)
        {
            this.listaDiscos = lD;
        }
    }
}
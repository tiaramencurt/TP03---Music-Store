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

        public static void InicializarGrupo()
        {
            Disco datoTaylor = new Disco("Taylor Swift", "Jack Antonoff", "Pop/Country", List<, 1, "/fotos/Maica.jpg");
            Disco datoBadBunny = new Disco("Bad Bunny", "Tainy", "Reggaetón / Trap latino", List<, 2, "/fotos/Maica.jpg");
            Disco datoTini = new Disco("Tini Stoessel", "Andrés Torres & Mauricio Rengifo", "Pop latino / Reggaetón", List<, 3, "/fotos/Maica.jpg");
            Disco datoAriana = new Disco("Ariana Grande", "Tommy Brown", "Pop / R&B", List<, 4, "/fotos/Maica.jpg");
            List<DatoFamiliar>familiaresMaica = new List<DatoFamiliar>();
            familiaresMaica.Add(MaicaMama);
            familiaresMaica.Add(MaicaPapa);
            familiaresMaica.Add(MaicaHermano);
            List<DatoFamiliar>familiaresMile = new List<DatoFamiliar>();
            familiaresMile.Add(MileMama);
            familiaresMile.Add(MilePapa);
            familiaresMile.Add(MileHermana);
            Integrante Maica = new Integrante(49192000, datoMaica, familiaresMaica, deMaica);
            Integrante Mile = new Integrante(49008545, datoMile, familiaresMile, deMile);
            integrantes = new Dictionary<int, Integrante>();
            integrantes.Add(Maica.dni, Maica);
            integrantes.Add(Mile.dni, Mile);
        }
    }
}
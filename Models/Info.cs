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
          // =================== CANCIONES ===================

// Taylor Swift
Cancion LoveStory = new Cancion("Love Story", "https://youtu.be/8xg3vE8Ie_E");
Cancion BlankSpace = new Cancion("Blank Space", "https://youtu.be/e-ORhEE9VVg");
Cancion AntiHero = new Cancion("Anti-Hero", "https://youtu.be/b1kbLwvqugk");
Cancion CruelSummer = new Cancion("Cruel Summer", "https://youtu.be/ic8j13piAhQ");

// Bad Bunny
Cancion TitiMePregunto = new Cancion("Tití me preguntó", "https://youtu.be/1IHR6dS8BNE");
Cancion MePortoBonito = new Cancion("Me porto bonito", "https://youtu.be/ZRtdQ81jPUQ");
Cancion Yonaguni = new Cancion("Yonaguni", "https://youtu.be/Do8NSL5Wyeg");
Cancion OjitosLindos = new Cancion("Ojitos lindos", "https://youtu.be/TbL7y9FiM4A");

// Billie Eilish
Cancion BadGuy = new Cancion("Bad Guy", "https://youtu.be/DyDfgMOUjCI");
Cancion HappierThanEver = new Cancion("Happier Than Ever", "https://youtu.be/5GJWxDKyk3A");
Cancion OceanEyes = new Cancion("Ocean Eyes", "https://youtu.be/viimfQi_pUw");
Cancion ThereforeIAm = new Cancion("Therefore I Am", "https://youtu.be/RUQl6YcMalg");

// Dua Lipa
Cancion DontStartNow = new Cancion("Don't Start Now", "https://youtu.be/oygrmJFKYZY");
Cancion Levitating = new Cancion("Levitating", "https://youtu.be/TUVcZfQe-Kw");
Cancion NewRules = new Cancion("New Rules", "https://youtu.be/k2qgadSvNyU");
Cancion Houdini = new Cancion("Houdini", "https://youtu.be/f6YDKF0LVWw");

// Harry Styles
Cancion AsItWas = new Cancion("As It Was", "https://youtu.be/H5v3kku4y6Q");
Cancion WatermelonSugar = new Cancion("Watermelon Sugar", "https://youtu.be/E07s5ZYygMg");
Cancion AdoreYou = new Cancion("Adore You", "https://youtu.be/V9Z6MDEh1gc");
Cancion SignOfTheTimes = new Cancion("Sign of the Times", "https://youtu.be/qN4ooNx77u0");

// ROSALÍA
Cancion Despecha = new Cancion("Despechá", "https://youtu.be/6iFbuIpe68o");
Cancion Motomami = new Cancion("Motomami", "https://youtu.be/bjDRMdtJsss");
Cancion LaFama = new Cancion("La Fama", "https://youtu.be/_WgHasvL6RE");
Cancion Saoko = new Cancion("Saoko", "https://youtu.be/_1cHozXPh4U");

// Ed Sheeran
Cancion ShapeOfYou = new Cancion("Shape of You", "https://youtu.be/JGwWNGJdvx8");
Cancion Perfect = new Cancion("Perfect", "https://youtu.be/2Vv-BfVoq4g");
Cancion BadHabits = new Cancion("Bad Habits", "https://youtu.be/orJSJGHjBLI");
Cancion EyesClosed = new Cancion("Eyes Closed", "https://youtu.be/0tC5E1bIT2g");

// Karol G
Cancion TQG = new Cancion("TQG", "https://youtu.be/5C6cvH1L4TI");
Cancion Provenza = new Cancion("Provenza", "https://youtu.be/Mi9uNu35Gmk");
Cancion Bichota = new Cancion("Bichota", "https://youtu.be/QAknWNivPsQ");
Cancion Cairo = new Cancion("Cairo", "https://youtu.be/B4L9GAslEVE");

// The Weeknd
Cancion BlindingLights = new Cancion("Blinding Lights", "https://youtu.be/fHI8X4OXluQ");
Cancion SaveYourTears = new Cancion("Save Your Tears", "https://youtu.be/XXYlFuWEuKI");
Cancion Starboy = new Cancion("Starboy", "https://youtu.be/34Na4j8AVgA");
Cancion DieForYou = new Cancion("Die for You", "https://youtu.be/YQ-qToZU3gc");

// Shakira
Cancion HipsDontLie = new Cancion("Hips Don't Lie", "https://youtu.be/DUT5rEU6pqM");
Cancion WakaWaka = new Cancion("Waka Waka", "https://youtu.be/pRpeEdMmmQ0");
Cancion Monotonia = new Cancion("Monotonía", "https://youtu.be/j5y6xLpRwx4");
Cancion Chantaje = new Cancion("Chantaje", "https://youtu.be/6Mgqbai3fKo");

// =================== LISTAS DE CANCIONES ===================

List<Cancion> cancionesTaylor = new List<Cancion> { LoveStory, BlankSpace, AntiHero, CruelSummer };
List<Cancion> cancionesBadBunny = new List<Cancion> { TitiMePregunto, MePortoBonito, Yonaguni, OjitosLindos };
List<Cancion> cancionesBillie = new List<Cancion> { BadGuy, HappierThanEver, OceanEyes, ThereforeIAm };
List<Cancion> cancionesDua = new List<Cancion> { DontStartNow, Levitating, NewRules, Houdini };
List<Cancion> cancionesHarry = new List<Cancion> { AsItWas, WatermelonSugar, AdoreYou, SignOfTheTimes };
List<Cancion> cancionesRosalia = new List<Cancion> { Despecha, Motomami, LaFama, Saoko };
List<Cancion> cancionesEd = new List<Cancion> { ShapeOfYou, Perfect, BadHabits, EyesClosed };
List<Cancion> cancionesKarol = new List<Cancion> { TQG, Provenza, Bichota, Cairo };
List<Cancion> cancionesWeeknd = new List<Cancion> { BlindingLights, SaveYourTears, Starboy, DieForYou };
List<Cancion> cancionesShakira = new List<Cancion> { HipsDontLie, WakaWaka, Monotonia, Chantaje };

// =================== DISCOS ===================

Disco Fearless = new Disco("Fearless", "Taylor Swift", "Jack Antonoff", "Pop / Country", cancionesTaylor, 0);
Disco UnVeranoSinTi = new Disco("Un Verano Sin Ti", "Bad Bunny", "Tainy", "Reggaetón / Trap latino", cancionesBadBunny, 1);
Disco HappierThanEverDisco = new Disco("Happier Than Ever", "Billie Eilish", "Finneas", "Pop alternativo", cancionesBillie, 2);
Disco FutureNostalgia = new Disco("Future Nostalgia", "Dua Lipa", "Ian Kirkpatrick", "Pop / Dance", cancionesDua, 3);
Disco HarrysHouse = new Disco("Harry's House", "Harry Styles", "Kid Harpoon", "Pop / Rock", cancionesHarry, 4);
Disco MotomamiDisco = new Disco("Motomami", "ROSALÍA", "El Guincho", "Pop / Experimental", cancionesRosalia, 5);
Disco Divide = new Disco("Divide", "Ed Sheeran", "Ed Sheeran", "Pop / Folk", cancionesEd, 6);
Disco MananaSeraBonito = new Disco("Mañana Será Bonito", "Karol G", "Ovy On The Drums", "Urbano / Reggaetón", cancionesKarol, 7);
Disco AfterHours = new Disco("After Hours", "The Weeknd", "Max Martin", "Synthpop / R&B", cancionesWeeknd, 8);
Disco ElDorado = new Disco("El Dorado", "Shakira", "Luis Fernando Ochoa", "Pop latino / Reggaetón", cancionesShakira, 9);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Bronco");
            Humano miHumano = new Humano("Ada");
            Gorila miGorila = new Gorila("Monky");
            Ballena miBallena = new Ballena("Neno");
            Cocodrilo miCocodrilo = new Cocodrilo("Bruno");

            Mamifero[] almacenAnimales = new Mamifero[4];
            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = miHumano;
            almacenAnimales[2] = miGorila;
            almacenAnimales[3] = miBallena;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamifero miMamifero = new Mamifero("");
            miMamifero.pensar();

            miCaballo.cuidarCrias();
            miHumano.getNombre();
            miGorila.trepar();

        }


    }

    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy Capaz de respirar");
        }

        public abstract void getNombre();
    }

    interface IAnimalesTerrestres
    {
        int numeroPatas();
    }

    class Reptil : Animales
    {
        public Reptil(String nombre)
        {
            String nombreSerVivo = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine("Este animal es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }

    class Mamifero : Animales
    {
        public Mamifero(String nombre)
        {
        }



        public void pensar()
        {
            Console.WriteLine("capacidad de analicis");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuidar de las crias hasta que se valgan por si solar");
        }


        public override void getNombre()
        {
            Console.WriteLine("Este animal es: " + nombreSerVivo);
        }

        private String nombreSerVivo;


    }

    class Ballena : Mamifero
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Puedo nadar");
        }
    }

    class Caballo : Mamifero, IAnimalesTerrestres
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("me gusta galopar");
        }

        public int numeroPatas()
        {
            return 4;
        }

    }

    class Humano : Mamifero
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        public void Pensar()
        {
            Console.WriteLine("Puedo pensar tengo la capacidad de crear mi propio mundo en mi cabeza");
        }

        public int numeroPies()
        {
            return 2;
        }
    }

    class Gorila : Mamifero, IAnimalesTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public void trepar()
        {
            Console.WriteLine("Aprendi a trepar");
        }
        public int numeroPatas()
        {
            return 2;
        }
    }

    class Cocodrilo : Reptil, IAnimalesTerrestres
    {
        public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
        {

        }

        public void muerde()
        {
            Console.WriteLine("tengo muchos dientes para moder mi alimento");
        }
        public int numeroPatas()
        {
            return 4;
        }
    }


}

    


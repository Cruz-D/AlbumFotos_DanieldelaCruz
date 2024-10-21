using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFotos_DanieldelaCruz
{
    internal class AlbumTest
    {
        public static void Main(string[] args)
        {
            // Crear un álbum predeterminado y mostrar el número de páginas
            AlbumFotos album1 = new AlbumFotos();
            Console.WriteLine("El álbum predeterminado tiene " + album1.numPaginas() + " páginas.\n");

            // Crear un álbum con 24 páginas y mostrar el número de páginas
            AlbumFotos album2 = new AlbumFotos(24);
            Console.WriteLine("El álbum personalizado tiene " + album2.numPaginas() + " páginas.\n");

            // Crear un gran álbum y mostrar el número de páginas
            SuperAlbumFotos superAlbum = new SuperAlbumFotos();
            Console.WriteLine("El super álbum tiene " + superAlbum.numPaginas() + " páginas.\n");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFotos_DanieldelaCruz
{
    // Clase SuperAlbumFotos que hereda de AlbumFotos
    internal class SuperAlbumFotos : AlbumFotos
    {
        // Constructor que inicializa el álbum con 64 páginas
        // llamando al constructor de la clase base con el número de páginas
        // y estableciendo el número de páginas base en 64
        public SuperAlbumFotos() : base(64)
        {
        }

    }
}

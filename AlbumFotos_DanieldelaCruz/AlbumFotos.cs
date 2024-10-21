using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFotos_DanieldelaCruz
{
    internal class AlbumFotos
    {
        // declarar una variable privada para almacenar el número de páginas
        // y una propiedad pública para acceder a ella
        private int _numPaginas;

        // propiedad pública para acceder al número de páginas
        // y establecer el número de páginas base
        public int NumPaginasBase { get; set; }

        // Constructor predeterminado que inicializa con 16 páginas
        // y constructor que recibe el número de páginas
        public AlbumFotos()
        {
            _numPaginas = 16;
        }

        // constructor que recibe el número de páginas y lo establece
        // en la variable privada
        public AlbumFotos(int numPaginas) => _numPaginas = numPaginas;

        // método para devolver el número de páginas base del álbum
        // y se puede acceder desde la clase de prueba AlbumTest
        public int numPaginas()
        {
            return _numPaginas;
        }

    }
}

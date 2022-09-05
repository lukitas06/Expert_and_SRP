using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
//El error de este codigo es que tiene dos responsabilidades asociadas a dos funciones diferentes.
//La clase tiene dos motivos para cambiar.
//Las responsabilidades de saber el titulo, el autor y el codigo estan bien, porque son relacionadas a los libros.
//Las responsabilidades de saber el sector de la libreria y la estanteria tendrian que estar en otra clase.

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
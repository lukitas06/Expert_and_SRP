using System.Collections;
namespace SRP
{
public class ShelveBook
{
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

         ArrayList books= new ArrayList();

        public  ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
      
        public void addBook(Book book){
            books.Add(book);
        }

        public string toString(){
            string consoleConstructor="";
            
            foreach(Book book in books){
                consoleConstructor+= $"{book.Title} | Author: {book.Author} | Code: {book.Code}\n ";
            }
            return $"Sector {this.LibrarySector} || Shelve {this.LibraryShelve} \n Books:\n {consoleConstructor } ";
        }

}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam1_MiniKindle
{
    public class Library
    {
        private List<Book> library;

        public Library()
        {
            library = new List<Book>();
        }

        public void LoadLibrary(String path)
        {
            string[] filenames = Directory.GetFiles(path);
            foreach (string fn in filenames)
            {
                Book newBook = new Book();
                newBook.LoadBook(fn);
                library.Add(newBook);
            }
        }

        public Book SelectBook(int i)
        {
            return library[i];
        }

        public List<String> Display()
        {
            List<string> listOfBookInfo = new List<string>();

            for (int i = 0; i < library.Count; i++)
            {
                listOfBookInfo.Add(library[i].ToString());
            }

            return listOfBookInfo;
        }


    }
}

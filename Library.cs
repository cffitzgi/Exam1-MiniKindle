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

        public void LoadLibrary(string path)
        {
            string[] filenames = Directory.GetFiles(path);
            foreach (string fn in filenames)
            {
                Book newBook = new Book();
                newBook.LoadBook(path + fn);
            }
//TODO: Read each filename in path, and for each filename
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_MiniKindle
{
    public class Library
    {
        private List<Book> library;

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

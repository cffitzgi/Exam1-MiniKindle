using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_MiniKindle
{
    public class Book
    {
        private List<String> pages;

        private int currentPage;

        private string author;

        private List<int> bookmarks;

        private string title;

        public Book()
        {

        }

        public void AddRemBkMk(int p)
        {
            bool remove = false;

            for (int i = 0; i < bookmarks.Count; i++)
            {
                if (bookmarks[i] == p)
                {
                    remove = true;
                    bookmarks[i] = 0;
                }
            }
            if (!remove)
            {
                bookmarks.Add(p);
            }
        }

        public void FlipPage(bool dir)
        {
            if (dir)
            {
                currentPage++;
            }
            else
            {
                currentPage--;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", title, author);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam1_MiniKindle
{
    public class Book
    {
        private List<String> pages;

        private int currentPage;

        private String author;

        private List<int> bookmarks;

        private String title;


        public Book()
        {
            pages = new List<String>();
            bookmarks = new List<int>();
        }


        /// <summary>
        /// Loads book from saved .txt file.
        /// </summary>
        /// <param name="path">Path to .txt file.</param>
        public void LoadBook(String path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                // Sets title and author from file.
                title = sr.ReadLine();
                author = sr.ReadLine();

                // Reads bookmarks saved in File
                string[] bmString = sr.ReadLine().Split(' ');
                int bm;
                foreach (string s in bmString)
                {
                    if (s.Length < 1) continue;

                    bm = int.Parse(s);
                    if (bm > 0)
                        bookmarks.Add(bm);
                }

                // Sets current page to last bookmark, or first page.
                if (bookmarks.Count > 0)
                    currentPage = bookmarks[bookmarks.Count - 1];
                else
                    currentPage = 0;
                
                // Reads the pages themselves, where each page is stored as a newline.
                while(!sr.EndOfStream)
                {
                    string page = sr.ReadLine();
                    if (page.Length > 0)
                        pages.Add(page);
                }
            }
        }

        /// <summary>
        /// Toggles bookmark of current page.
        /// </summary>
        public void AddRemBkMk()
        {
            bool remove = false;

            for (int i = 0; i < bookmarks.Count; i++)
            {
                if (bookmarks[i] == currentPage)
                {
                    remove = true;
                    bookmarks.RemoveAt(i);
                }
            }
            if (!remove && bookmarks.Count <= 3)
            {
                bookmarks.Add(currentPage);
            }
        }

        /// <summary>
        /// Checks if the current page is already bookmarked.
        /// </summary>
        /// <returns>True if the current page is bookmarked.</returns>
        public bool CurrentPageMarked()
        {
            for (int i = 0; i < bookmarks.Count; i++)
            {
                if (bookmarks[i] == currentPage)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Turns the page depending on the direction.
        /// </summary>
        /// <param name="dir">True goes forward, false goes backwards.</param>
        public void FlipPage(bool dir)
        {
            if (dir && currentPage < pages.Count - 1)
            {
                currentPage++;
            }
            else if (!dir && currentPage > 0)
            {
                currentPage--;
            }
        }

        /// <summary>
        /// Returns the page's contents as text.
        /// </summary>
        /// <returns>The page's contents as a String object.</returns>
        public String DisplayPage()
        {
            return pages[currentPage];
        }

        /// <summary>
        /// Gets the current page number.
        /// </summary>
        /// <returns>Current page number as an int.</returns>
        public int GetCurrentPage()
        {
            return currentPage + 1;
        }

        /// <summary>
        /// Overrides ToString to return the book's Title by Author
        /// </summary>
        /// <returns>Book Title by Author as String object.</returns>
        public override String ToString()
        {
            return String.Format("{0} by {1}", title, author);
        }
    }
}

using System;

namespace Fisher.Bookstore.Models{
    public class Book{
        public int BookID{get; set; }

        public string Title {get; set; }

        public Author Author {get; set; }

        public void SellBook(){
            // Code to sell book goes here
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bookshelf.Models;

namespace Bookshelf.Data
{
    public class BookRepository
    {
        private static Book[] _Books = new Book[]
        {
            new Book()
            {
                BookTitle = "War and Peace",
                Year = 1869,
                Author = new Author() { FirstName = "Leo", LastName = "Tolstoy" },
                Description = "Often called the greatest novel ever written, War and Peace is at once an epic of the Napoleonic wars, a philosophical study, and a celebration of the Russian spirit. Tolstoy's genius is clearly seen in the multitude of characters in this massive chronicle, all of them fully realized and equally memorable. Out of this complex narrative emerges a profound examination of the individual's place in the historical process, one that makes it clear why Thomas Mann praised Tolstoy for his Homeric powers and placed War and Peace in the same category as The Iliad.",
                Image = "https://images-na.ssl-images-amazon.com/images/I/51fyqN7woLL._SY346_.jpg"
            },

            new Book()
            {
                BookTitle = "Anna Karenina",
                Year = 1878,
                Author = new Author() { FirstName = "Leo", LastName = "Tolstoy"},
                Description = "At its simplest, Anna Karenina is a love story. It is a portrait of a beautiful and intelligent woman whose passionate love for a handsome officer sweeps aside all other ties - to her marriage and to the network of relationships and moral values that bind the society around her. The love affair of Anna and Vronsky is played out alongside the developing romance of Kitty and Levin, and in the character of Levin, closely based on Tolstoy himself, the search for happiness takes on a deeper philosophical significance. One of the greatest novels ever written, Anna Karenina combines penetrating psychological insight with an encyclopedic depiction of Russian life in the 1870s. The novel takes us from high society St Petersburg to the threshing fields on Levin's estate, with unforgettable scenes at a Moscow ballroom, the skating rink, a race course, a railway station. It creates an intricate labyrinth of connections that is profoundly satisfying, and deeply moving.",
                Image = "https://images-na.ssl-images-amazon.com/images/I/511W-J2%2B8ZL._SX327_BO1,204,203,200_.jpg"
            }

        };

        public Book GetBook(int id)
        {
            Book bookToReturn = null;

            foreach (var book in _Books)
            {
                if (book.Id == id)
                {
                    bookToReturn = book;

                    break;
                }
            }

            return bookToReturn;
        }
    }
}
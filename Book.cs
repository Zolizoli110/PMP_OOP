using System;

namespace Oop
{
  class Book
  {
    private string author;
    private string title;
    private int releaseDate;
    private int pageNumber;

    public Book(string title, string author, int releaseDate, int pageNumber)
    {
      this.author = author;
      this.title = title;
      this.releaseDate = releaseDate;
      this.pageNumber = pageNumber;
    }

    public string AllData()
    {
      return author + ": " + title + ", " + releaseDate + " (" + pageNumber + ")";
    }
  }
}

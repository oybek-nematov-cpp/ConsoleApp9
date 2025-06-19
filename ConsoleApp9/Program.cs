using System;

public class PhotoBook
{
    private int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

   
    public PhotoBook(int pages)
    {
        numPages = pages;
    }

  
    public int GetNumberPages()
    {
        return numPages;
    }
}

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)
    {
       
    }
}


public class PhotoBookTest
{
    public static void Main(string[] args)
    {
      
        PhotoBook defaultBook = new PhotoBook();
        Console.WriteLine(defaultBook.GetNumberPages()); 

        PhotoBook customBook = new PhotoBook(24);
        Console.WriteLine(customBook.GetNumberPages()); 

     
        BigPhotoBook bigBook = new BigPhotoBook();
        Console.WriteLine(bigBook.GetNumberPages()); 
    }
}

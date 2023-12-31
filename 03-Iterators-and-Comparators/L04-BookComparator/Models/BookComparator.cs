﻿using System.Collections.Generic;

public class BookComparator : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        var result = x.Title.CompareTo(y.Title); // ASC
        if (result == 0)
        {
            result = y.Year.CompareTo(x.Year);   // DESC
        }
        return result;
    }
}
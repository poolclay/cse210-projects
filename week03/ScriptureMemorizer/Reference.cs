using System;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;
    public Reference(string text, int chapter, int verse)
    {
        _book =text;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string text, int chapter, int starVerse, int endVerse)
    {
        _book =text;
        _chapter = chapter;
        _verse = starVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else 
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }

}
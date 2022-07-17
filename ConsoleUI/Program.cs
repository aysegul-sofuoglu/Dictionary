using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            WordTest();

           // LanguageTest();

        }

        private static void LanguageTest()
        {
            LanguageManager languageManager = new LanguageManager(new EfLanguageDal());

            foreach (var language in languageManager.GetAll())
            {
                Console.WriteLine(language.NAME);
            }
        }

        private static void WordTest()
        {
            WordManager wordManager = new WordManager(new EfWordDal());

            foreach (var word in wordManager.GetAll())
            {
                Console.WriteLine(word.NAME);
            }
        }
    }
}

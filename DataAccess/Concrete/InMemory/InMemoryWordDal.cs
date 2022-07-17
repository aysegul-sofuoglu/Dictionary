using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryWordDal : IWordDal
    {
        List<Word> _words;
        public InMemoryWordDal()
        {
            _words = new List<Word> {  };
        }
        public void Add(Word word)
        {
            _words.Add(word);
        }

        public void Delete(Word word)
        {
            Word wordToDelete = _words.SingleOrDefault(w=>w.ID == word.ID);

            _words.Remove(wordToDelete);
        }

        public Word Get(Expression<Func<Word, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Word> GetAll()
        {
            return _words;
        }

        public List<Word> GetAll(Expression<Func<Word, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Word> GetAllByName(string name)
        {
            return _words.Where(w => w.NAME == name).ToList();
        }

        

        public void Update(Word word)
        {
            Word wordToUpdate = _words.SingleOrDefault(w => w.ID == word.ID);
            wordToUpdate.NAME = word.NAME;
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WordManager : IWordService
    {
        IWordDal _wordDal;

        public WordManager(IWordDal wordDal)
        {
            _wordDal = wordDal;
        }

        public List<Word> GetAll()
        {
            return _wordDal.GetAll();
            
        }
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class LanguageWord: IEntity
    {
        public int ID { get; set; }
        public int VALUE { get; set; }
        public int WORDID { get; set; }
        public int LANGUAGEID { get; set; }
    }
}

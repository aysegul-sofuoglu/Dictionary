﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Word: IEntity
    {
        public int ID { get; set; }
        public string NAME { get; set; }
    }
}

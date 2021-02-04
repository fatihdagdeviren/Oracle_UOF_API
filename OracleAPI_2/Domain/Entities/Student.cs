﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}

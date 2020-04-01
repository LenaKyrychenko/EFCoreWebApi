﻿using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class BaseEntity : IEntity<int>
    {
        public int Id { get; set; }
    }
}

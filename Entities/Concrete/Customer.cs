﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {
        public int UserId { get; set; } //Users tablosu ile iliskili
        public string CompanyName { get; set; }
    }
}

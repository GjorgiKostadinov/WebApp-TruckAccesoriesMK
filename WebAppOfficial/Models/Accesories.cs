﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppOfficial.Models
{
    public class Accesories
    {
        public int Id { get; set; }

        public string Name { get; set; }    
        public string Description { get; set; }
        public string Price { get; set; }

        public string ImageUrl { get; set; }

        public float Rating { get; set; }

    }
}
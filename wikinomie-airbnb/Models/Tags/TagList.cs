﻿using System.Collections.Generic;

namespace PrototypeWikinomie.Models.Tags
{
    public class TagList
    {
        public Dictionary<string, string> List { get; set; }
        public string Previous { get; set; }
        public string Date { get; set; }
    }
}
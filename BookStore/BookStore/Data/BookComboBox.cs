﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookComboBox
    {

        public string Text { get; set; }
        public string Value { get; set; }
       

        public override string ToString() => Text;
    }
}

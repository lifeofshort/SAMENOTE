﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTE.ClassModel
{
    class FontBrush
    {
       public  Font f = null;
        public Color c = Color.Black;
        public FontBrush()
        {
        }
        public FontBrush(Font f , Color c)
        {
            this.f = f;
            this.c = c;
        }
    }
}

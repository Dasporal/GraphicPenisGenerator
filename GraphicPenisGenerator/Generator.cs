using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicPenisGenerator
{
    class Generator
    {
        private int sizeP;
        private string size;
        Random sizePenis = new Random();
        public Generator(int sizeP, string size)
        {
            this.sizeP = sizeP;
            this.size = size;
        }
        public int setSize(int sizeP)
        {
            return sizePenis.Next(1, 15);
        }
        public string sizeD(int sizeP)
        {
            for (int i = 0; i < sizeP; i++)
            {
                size += "=";
            }
            return size;
        }
        public string clear(string size)
        {
            return size = "";
        }

    }
}



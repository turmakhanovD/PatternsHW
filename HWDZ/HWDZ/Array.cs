using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWDZ
{
    public class Array
    {
        private int[] mas;
        public int Size { get; set; }
        public Array(int size)
        {
            Size = size;
            mas = new int[Size];
        }
        public int this[int i]
        {
            get
            {
                return mas[i];
            }
            set
            {
                mas[i] = value * value;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0924_실습과제
{
    class myioarr
    {
        private accio[] iolist;
        public int Size { get; private set; }
        public int Max { get; private set; }

        public myioarr()
        {
            Size = 0;
            Max = 500;
            iolist = new accio[Max];
        }

        public accio getdata(int idx)
        {
            return iolist[idx];
        }


        public accio this[int index]
        {
            get { return iolist[index]; }
        }

        public void insert(accio info)
        {
            if (Size >= Max)
                throw new Exception("저장 공간 부족");

            iolist[Size] = info;
            Size++;
        }


    }
}

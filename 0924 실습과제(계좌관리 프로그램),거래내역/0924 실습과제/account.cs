using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0924_실습과제
{
    class account
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }

        public account(string n,int id,int b)
        {
            Name = n;
            Id = id;
            Balance = b;
        }

        public void Print()
        {
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("계좌번호 : " + Id);
            Console.WriteLine("잔액 : " + Balance);
        }
        public override string ToString()
        {
            string temp = string.Format("[{0}] 계좌 : {1} 잔액 : {2}", Name, Id, Balance);
            return temp;
        }
    }
}

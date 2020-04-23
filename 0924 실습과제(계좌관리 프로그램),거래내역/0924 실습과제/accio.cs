using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0924_실습과제
{
    class accio
    {
       public int Id { get; private set; }
       public int Inmoney { get; private set; }
       public int Outmoney { get; private set; }
        public int Balance { get; private set; }
        public string Time { get; private set; }


        public accio(account acc,int inmoney,int outmoney)
        {
            Id = acc.Id;
            Balance = acc.Balance;
            Inmoney = inmoney;
            Outmoney = outmoney;
            Time = DateTime.Now.ToString("yy/mm/dd HH:mm:ss");
        }

        public void Print()
        {
            Console.WriteLine("계좌번호 : " + Id);
            Console.WriteLine("입금액 : " + Inmoney);
            Console.WriteLine("출금액 : " + Outmoney);
            Console.WriteLine("잔액 : " + Balance);
            Console.WriteLine("시간 : " + Time);
        }
        public override string ToString()
        {
            string temp = string.Format("[{0}] 입금액 : {1} 출금액 : {2} 잔액 : {3} 시간 : {4}"
                , Id, Inmoney, Outmoney, Balance, Time);
            return temp;
        }

    }
}

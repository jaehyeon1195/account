using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0924_실습과제
{
    class control
    {
        //저장소========================
        wbarray array = new wbarray();
        myioarr ioarr = new myioarr();
        //==============================

        public void printall()
        {
            Console.WriteLine("저장개수 : {0}개", array.Size);
            for (int i = 0; i < array.Size; i++)
            {
                account mem = array.getdata(i);
                Console.WriteLine(mem);
            }
        }
        public void insert()
        {
            try
            {
                string name = wblib.inputstring("이름");
                int id = wblib.inputnumber("계좌번호");
                int balance = wblib.inputnumber("잔액");
                account mem = new account(name, id, balance);
                array.insert(mem);

                accio info = new accio(mem, 0, 0);
                ioarr.insert(info);

                Console.WriteLine("저장 완료");
            }
            catch (Exception ex)
            {
                Console.WriteLine("입력 오류");
                Console.WriteLine(">> " + ex.Message);
            }


        }

        private int idtoidx(int id)
        {
            for (int i = 0; i < array.Size; i++)
            {
                account acc = array[i];
                if (acc.Id.Equals(id) == true)
                    return i;
            }
            throw new Exception("잘못된 계좌");
        }

        public void deposit()
        {
            try
            {
                int id = wblib.inputnumber("계좌 ID");
                int money = wblib.inputnumber("입금액");

                if (money <0)
                {
                    Console.WriteLine("잘못된 금액");
                    return;
                }

                account mem = array[idtoidx(id)];
                mem.Balance += money;

                accio info = new accio(mem, money, 0);
                ioarr.insert(info);

            }
            catch (Exception ex)
            {
                Console.WriteLine("입금 오류");
                Console.WriteLine(">> " + ex.Message);
            }


        }

        public void Withdraw()
        {
            try
            {
                int id = wblib.inputnumber("계좌 ID");
                int money = wblib.inputnumber("출금액");
                account mem = array[idtoidx(id)];

                if (money < 0 || mem.Balance<money)
                {
                    Console.WriteLine("잘못된 금액");
                    return;
                }

                mem.Balance -= money;

                accio info = new accio(mem, 0, money);
                ioarr.insert(info);
            }
            catch (Exception ex)
            {
                Console.WriteLine("출금 오류");
                Console.WriteLine(">> " + ex.Message);
            }
        }

        public void Inquire()
        {
            int id = wblib.inputnumber("검색할 계좌 ID");
            account mem = array[idtoidx(id)];
            Console.WriteLine(mem);
            Console.WriteLine("************************************************");
            for (int i = 0; i < ioarr.Size; i++)
            {
                accio info = ioarr.getdata(i);
                if(mem.Id==info.Id)
                 Console.WriteLine(info);
 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0924_실습과제
{
    class wbprint
    {
        public static void logo()
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("2019.9.24");
            Console.WriteLine("우송비트고급30기 C#언어과정");
            Console.WriteLine("계좌관리프로그램 -첫번째 과제");
            Console.WriteLine("김재현");
            Console.WriteLine("*********************************************");
            pause();
        }

        public static void ending()
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("계좌관리프로그램 -첫번째 실습");
            Console.WriteLine("프로그램 종료");
            Console.WriteLine("*********************************************");
            pause();
        }

        public static void menuprint()
        {

            Console.WriteLine("*********************************************");
            Console.WriteLine("[F1] 계좌 등록");
            Console.WriteLine("[F2] 계좌 검색");
            Console.WriteLine("[F3] 입금");
            Console.WriteLine("[F4] 출금");
            Console.WriteLine("[ESC] 프로그램 종료");
            Console.WriteLine("*********************************************");
        }

        public static void pause()
        {
            Console.WriteLine("아무키나 누르세요");
            Console.ReadKey();
        }
    }
}

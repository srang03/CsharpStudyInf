using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    internal class CWorker2
    {
        int iCount;

        public delegate void Full_dele(); // 1. 델리게이트 선언
        public event Full_dele OnFull; // 2. 이벤트 선언
        // delegate로 만든 변수인데 Event라는 것을 명시적으로 안내
        // public Full_dele OnFull;

        // 해당 클래스에서 발생한 이벤트를 처리해주는 객체는, 클래스의 인스턴스를 생성한 객체이다.
        // CWorker2를 생성한 

        public CWorker2()
        {
            iCount = 0;
        }

        public void receive()
        {
            iCount += 1;
            Console.WriteLine("Recevied : " + iCount);

            if (iCount % 5 == 0)
            {
                if(OnFull == null)
                {
                    Console.WriteLine("이벤트가 연결되지 않음");
                }
                else
                {
                    OnFull(); // 3. 이벤트 발생
                }
                
            }
        }


    }
}

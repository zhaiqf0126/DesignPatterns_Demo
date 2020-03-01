using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignMethod.SinglePattern
{
    public class SingleFirst
    {
        private SingleFirst()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{this.GetType().Name}被构造,线程ID {Thread.CurrentThread.ManagedThreadId}");
        }

        public static SingleFirst _SingleFirst = null;

        private static object _Singlelock = new object();
        public static  SingleFirst CreateInstance()
        {
            if (_SingleFirst == null)  //为了不用等待
            {
                Console.WriteLine("等待....");
                lock (_Singlelock)  //保证只有一个线程进去，其余线程等待
                {

                    if (_SingleFirst == null) //如果为空，则创建
                    {
                        _SingleFirst = new SingleFirst();
                    }
                }
            }
            return _SingleFirst;
        }


        public void Show()
        {
            Console.WriteLine($"这里调用了{this.GetType().Name}.show()");
        }
    }
}

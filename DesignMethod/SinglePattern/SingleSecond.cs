using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignMethod.SinglePattern
{
    public class SingleSecond
    {
        private SingleSecond()
        {
            Thread.Sleep(1000);
            Console.WriteLine("单例二私有构造函数");
        }

        public static SingleSecond _singleSecond = null;

        //由CLR保证，在第一次使用这个类之前，调用且只调用一次
        static SingleSecond()
        {
            Console.WriteLine("静态构造函数。");
            _singleSecond = new SingleSecond();
        }

        public static SingleSecond CreateInstance()
        {
            return _singleSecond;
        }

        public void Show()
        {
            Console.WriteLine($"调用{this.GetType().Name}.show() 方法");
        }

    }
}

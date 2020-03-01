using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignMethod.SinglePattern
{
    public class SingleThird
    {
        private SingleThird()
        {
            Thread.Sleep(1000);
            Console.WriteLine("单例三私有构造函数");
        }

        public static SingleThird _singleThird = new SingleThird();

        public static SingleThird CreateInstance()
        {
            return _singleThird;
        }
        public void Show()
        {
            Console.WriteLine($"调用{this.GetType().Name}.show() 方法");
        }
    }
}

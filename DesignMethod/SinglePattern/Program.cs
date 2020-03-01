using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignMethod.SinglePattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            Console.WriteLine("******************************************************************");

            //单例一
            {
                SingleFirst first = SingleFirst.CreateInstance();

                //单线程构造
                for (int i = 0; i < 10; i++)
                {
                    SingleFirst first1 = SingleFirst.CreateInstance();
                    first1.Show();
                }

                //多线程构造
                List<IAsyncResult> async = new List<IAsyncResult>();
                for (int i = 0; i < 10; i++)
                {
                    async.Add(
                    new Action(() =>
                    {
                        SingleFirst first1 = SingleFirst.CreateInstance();
                        first1.Show();

                    }).BeginInvoke(null, null));
                }
                Console.WriteLine("********************************************");
                while (async.Count(t => !t.IsCompleted) > 0)
                {
                    Thread.Sleep(1000);
                }

                for (int i = 0; i < 10; i++)
                {
                    async.Add(
                    new Action(() =>
                    {
                        SingleFirst first1 = SingleFirst.CreateInstance();
                        first1.Show();

                    }).BeginInvoke(null, null));
                }

            }

            //单例二
            {
                //SingleSecond second = SingleSecond.CreateInstance();

                //for (int i = 0; i < 10; i++)
                //{

                //    SingleSecond second = SingleSecond.CreateInstance();
                //    second.Show();
                //}
            }

            //单例三
            {
                //SingleThird third = SingleThird.CreateInstance();
                //third.Show();

                for (int i = 0; i < 10; i++)
                {
                    SingleThird third = SingleThird.CreateInstance();
                    third.Show();
                }
            }

            Console.WriteLine("******************************************************************");
            Console.ReadKey();
        }
    }
}


//保证整个进程中，该对象只被实例化一次    可以很大程度的提升速度
//常驻内存的

//普通的类型是需要的时候就初始化，用完就被GC 回收

//场景： 如 线程池，数据库链接池
//单件模式（Single Pattern）
//Singleton单例模式为一个面向对象的应用程序提供了对象唯一的访问点，不管它实现何种功能，
//此种模式都为设计及开发团队提供了共享的概念。然而，Singleton对象类派生子类就有很大的困难，
//只有在父类没有被实例化时才可以实现。值得注意的是，有些对象不可以做成Singleton，
//比如.net的数据库链接对象(Connection)，整个应用程序同享一个Connection对象会出现连接池溢出错误。
//另外，.net提供了自动废物回收的技术，因此，如果实例化的对象长时间不被利用，系统会认为它是废物，
//自动消灭它并回收它的资源，下次利用时又会重新实例化，这种情况下应注意其状态的丢失。



//优点

//          一、节约了系统资源。由于系统中只存在一个实例对象，对与一些需要频繁创建和销毁对象的系统而言，单
//例模式无疑节约了系统资源和提高了系统的性能。
//             二、因为单例类封装了它的唯一实例，所以它可以严格控制客户怎样以及何时访问它。

//缺点
//             一、由于单例模式中没有抽象层，因此单例类的扩展有很大的困难。
//             二、单例类的职责过重，在一定程度上违背了“单一职责原则”。

//模式使用场景

//下列几种情况可以使用单例模式。
//        一、系统只需要一个实例对象，如系统要求提供一个唯一的序列号生成器，或者需要考虑资源消耗太大而只允许创建一个对象。
//       二、客户调用类的单个实例只允许使用一个公共访问点，除了该公共访问点，不能通过其他途径访问该实例。

//总结          
//           1. 单例模式中确保程序中一个类最多只有一个实例。
//           2. 单例模式的构造器是私有了，而且它必须要提供实例的全局访问点。
//           3. 单例模式可能会因为多线程的问题而带来安全隐患。
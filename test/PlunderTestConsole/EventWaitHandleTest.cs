﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlunderTestConsole
{
    public static class EventWaitHandleTest
    {
        static void EventSingnThreadTest()
        {
            AutoResetEvent autoResetEvent = new AutoResetEvent(false); //声明 false， WaitOne时线程等待
            var thread = new Thread(() =>
            {
                Console.WriteLine(@"1.ConsumerBroker Start");
                Console.WriteLine(@"2.Excute Consume");
                Task.Run(async () =>
                {
                    Console.WriteLine(@"3.Task doing...");
                    await Task.Delay(10000);
                    Console.WriteLine(@"4.Task end");
                    autoResetEvent.Set();//终止信号，允许等待线程继续。。
                });
                Console.WriteLine(@"5.End of the Task declarations. Start WaitOne");
                autoResetEvent.WaitOne();//线程等待
                Console.WriteLine(@"6.ConsumerBroker End");
            });
            thread.Start();

        }


        static void NLoopConsumeTest()
        {
            AutoResetEvent autoResetEvent = new AutoResetEvent(false); //声明 false， WaitOne时线程等待
            while (true)
            {
                autoResetEvent.Reset(); //WaitOne时，使线程等待
                //todo：从队列取数据

                //消费者
                Task.Run(() =>
                {
                    //todo:处理数据
                    autoResetEvent.Set(); //消费完成，允许线程继续
                });
                autoResetEvent.WaitOne(); //等待某个消费者空闲，线程等待

            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft;
using Microsoft.Scripting.Runtime;
using IronPython.Runtime;
using IronPython.Zlib;
using IronPython.Compiler;
using IronPython.Modules;
using IronPython.SQLite;

namespace ConsoleApp1

{
    class Program
    {
        public void thread1(Object obj)//定义方法thread1
        {
            for (int i = 0; i <= 3; i++)//输出0~3的值
            {
                Console.Write(i.ToString());
            }
            Console.WriteLine();//换行
        }
        public void thread2(Object obj)//定义方法thread2
        {
            for (int i = 4; i <= 6; i++)//输出4~6的值
            {
                Console.Write(i.ToString() + obj.ToString());//值后面加货币符号
            }
            Console.WriteLine();//换行
        }
        static void Main(string[] args)
        {
            Console.Write("{0}", ("dxper".Equals("net")).ToString().ToUpper());

            //    string Ostr = "￥";//用字符串记录货币符号
            //    Program prog = new Program();//实例化Program类
            //    for (int i = 0; i <= 3; i++)
            //    {
            //        //用线程池执行无参数方法
            //        ThreadPool.QueueUserWorkItem(new WaitCallback(prog.thread1));
            //        //用线程池执行有参数方法
            //        ThreadPool.QueueUserWorkItem(new WaitCallback(prog.thread2), Ostr);
            //    }
            //    Console.ReadLine();
            //}
            ScriptRuntime p = Python.CreateRuntime();
            dynamic obj = p.UseFile("TextFile1.py");
            Console.WriteLine(obj.welcome("haha"));
            Console.ReadKey();
        }
    }
}
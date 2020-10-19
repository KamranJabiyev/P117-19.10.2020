using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Methods
            //Console.WriteLine(Sum(5, 10));

            //CustomJoin("test", 10);

            //Fullname("Mehemmed", "Mikayilov");
            //SumOrDifference(10);
            //int[] arr = { 10, 20, 30, 40, 50 };
            //Console.WriteLine(GetAverage(arr));
            //Console.WriteLine(GetAverage(10, 200));
            //Console.WriteLine(GetAverage(10, 20, 30, 40));
            //Info("Melek");
            //Sum(10, 15);
            //Write(10.5);
            #endregion


            #region cw,cr,try catch
            //Console.WriteLine("Yashinizi daxil edin:");
            //string response = Console.ReadLine();
            //try
            //{
            //    int age = int.Parse(response);
            //    string result = age > 18 ? "okey" : "No";
            //    Console.WriteLine(result);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Zehmet olmasa eded daxil edin");
            //}
            //finally
            //{
            //    Console.WriteLine("finally ishledi");
            //}
            #endregion

            #region Value,referance
            //value
            //int a = 5;
            //int b = a; //b=5 same
            //b = 10;
            //Console.WriteLine("a="+a);
            //Console.WriteLine("b="+b);
            //int x = 5;
            //ChangeNum(x);
            //Console.WriteLine("x="+x);

            //referance
            //int[] arr = { 10, 20, 30 };
            //int[] arr1 = arr; //arr1={10,20,30} not same
            //arr1[0] = 100;
            //Console.WriteLine("arr[0]="+arr[0]);
            //Console.WriteLine("arr1[0]="+arr1[0]);
            //int[] arr = { 1, 2, 3 };
            //ChangeIndex(arr);
            //Console.WriteLine("arr[0]=" + arr[0]);
            #endregion

        }

        #region Value, referance
        //static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 500;
        //    Console.WriteLine("method: arr[0]=" + arr[0]);
        //}

        //static void ChangeNum(int x)
        //{
        //    x = 10;
        //    Console.WriteLine("method:"+x);
        //}

        #endregion
        #region Methods
        //static void Write(int n)
        //{
        //    Console.WriteLine(n);
        //}


        //static void Write(double n)
        //{
        //    Console.WriteLine(n);
        //}

        //static void Sum(int x, int y, int c = 1)
        //{
        //    int result = x + y + c;
        //    Console.WriteLine("3 params Sum method:" + result);
        //}

        //static void Sum(int x, int y)
        //{
        //    int result = x + y;
        //    Console.WriteLine("Main Sum method:" + result);
        //}

        //static void Sum(params int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int num in arr)
        //    {
        //        sum += num;
        //    }
        //    Console.WriteLine("params Sum method:" + sum);
        //}



        //Method signature - Method name,parametrs Count,parametrs Type
        //Method overloading
        //static void Info(string name)
        //{
        //    Console.WriteLine(name);
        //}

        //static void Info(string name,string surname)
        //{
        //    Console.WriteLine($"{name} {surname}");
        //}

        //static void Info(string name,string surname,int age)
        //{
        //    Console.WriteLine($"{name} {surname} {age}");
        //}

        //static int GetAverage(params int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int num in arr)
        //    {
        //        sum += num;
        //    }

        //    return sum / arr.Length;
        //}

        //method - reusable code block
        //static int Sum(int x,int y)
        //{
        //    return x + y;
        //}

        ///// <summary>
        ///// Join two string
        ///// </summary>
        ///// <param name="w1">w1 - first word</param>
        ///// <param name="w2">w2 - number</param>
        ///// <returns></returns>
        //static string CustomJoin(string w1,int w2)
        //{
        //    return w1 + w2;
        //}

        //static void Fullname(string name,string surname)
        //{
        //    Console.WriteLine($"{name} {surname}");
        //}

        //static void SumOrDifference(int a,int b=2,bool c=true)
        //{
        //    if (a > b)
        //    {
        //        Console.WriteLine(a-b);
        //        return;
        //    }
        //    Console.WriteLine(a+b);
        //} 
        #endregion


    }
}



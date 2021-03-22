using System;
using static System.Math;
using static System.Console;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建并管理类和对象
            //Circle c;
            //c = new Circle(45);
            //double a = c.Area();

            //Point origin = new Point();
            //Point right = new Point(10, 100);
            //double distance = origin.DistanceTo(right);
            //Console.WriteLine("distance是{0}", distance);
            //Console.WriteLine($"{Circle.NumCircles}");


            #endregion;

            #region  静态using语句

            //Console.WriteLine("你可是真牛逼");
            //WriteLine("傻子");//因为引用了using static System.Console;
            #endregion

            #region 写静态成员并且调用静态方法
            //Point origin = new Point();
            //Point right = new Point(1366, 768);
            //double distance = origin.DistanceTo(right);
            //Console.WriteLine($"NUmber of Point objects:{Point.ObjectCont()}");//2
            //#endregion
            #endregion

            #region demo
            //Animal[] ans = new Animal[3];
            //ans[0] = new LaoYing();
            //ans[1] = new Leopard();
            //foreach (var item in ans)
            //{
            //    item.Behavior();

            //}
            //Console.ReadKey();

            //LaoYing laoying = new LaoYing();
            //laoying.Behavior();
            //Leopard baozi = new Leopard();
            //baozi.Behavior();
            #endregion

            #region 复制值类型的变量和类
            int i = 42;
            int copyi=i;
            i++;
            #endregion
        }
    }
    #region demo
    //public abstract class Animal
    //{
    //    public abstract void Behavior();

    //}
    //public class Leopard : Animal
    //{
    //    public override void Behavior()
    //    {
    //        Console.WriteLine("跑");
    //    }
    //}

    //public class LaoYing : Animal
    //{
    //    public override void Behavior()
    //    {
    //        Console.WriteLine("飞");
    //    }
    //}
    #endregion


}

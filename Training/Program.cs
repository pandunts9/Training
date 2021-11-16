using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*****************************************
            * Polumorphism
            **************************************/

            if (true)
            {
                //    List<Shape> shapes = new List<Shape>()
                //{
                //    new Rectangle(),
                //    new Triangle(),
                //    new Circle()
                //};

                //    foreach (Shape shape in shapes)
                //    {
                //        shape.Draw();
                //    }

                //    Console.WriteLine("-------------------");

                //    Employee employe = new Employee();
                //    employe.Work();
                //    Courier courier = new Courier();
                //    courier.Work();
                //    Employee courier2 = new Courier();
                //    courier2.Work();

                //    List<Employee> employees = new List<Employee>();
                //    employees.Add(new Labeler());
                //    employees.Add(new WarehouseWorker());
                //    employees.Add(new Checker());
                //    employees.Add(new Courier());

                //    for (int i = 0; i < employees.Count; i++)
                //    {
                //        employees[i].Work();
                //    }

                //    Console.WriteLine("-------------------");

                //    MyBase instance1 = new MyBase("First");
                //    Console.WriteLine(instance1.myPublicFild);
                //    MyDerived instance2 = new MyDerived("first", "second");
                //    Console.WriteLine(instance2.myPublicFild);
                //    //Console.WriteLine(instance2.myProtectedFild);
            }

            /*****************************************
             * Interface 
             **************************************/

            Email email = new Email();
            Sms sms = new Sms();
            Envelope envelope = new Envelope();

            List<Notification> not = new List<Notification>();
            not.Add(new Notification(email));
            not.Add(new Notification(sms));
            not.Add(new Notification(envelope));
            /*****************************************
            is this true?(without notification list and without using Notification class)

            List<IMessage> notifications = new List<IMessage>();
            notifications.Add(new Email());
            notifications.Add(new Sms());
            notifications.Add(new Envelope());
            for (int i = 0; i < notifications.Count; i++)
            {
               notifications[i].SendMessage();
            }
            **************************************/
            for (int i = 0; i < not.Count; i++)
            {
               not[i].DoNotify();
            }
        }
    }
            
}

            

/*
public class Shape
{
    // A few example members
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }

    // Virtual method
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing tasks");
    }
}
public class Circle : Shape
{
    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}
public class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}
public class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }
}
*/


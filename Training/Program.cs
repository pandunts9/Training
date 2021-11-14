﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>()
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("-------------------");

            Employee employe = new Employee();
            employe.Work();
            Courier courier = new Courier();
            courier.Work();

            List<Employee> employees = new List<Employee>();
            employees.Add(new Labeler());
            employees.Add(new WarehouseWorker());
            employees.Add(new Checker());
            employees.Add(new Courier());

            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].Work();
            }
        }
    }
}
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

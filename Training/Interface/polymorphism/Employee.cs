using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    
    public interface ICarType
    {
        void GetCarType();
    }
    public interface IInfo
    {
        void GetInfo();
    }
    class Employee 
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        private IInfo _iinfo;
        private ICarType _icarType;
        public string FullName {get => $"{Name} {LastName}"; }

        public Employee(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public Employee(IInfo info)
        {
            _iinfo = info;
        }
        public Employee(ICarType carType)
        {
            _icarType = carType;
        }
        public virtual void Work()
        {
            Console.WriteLine("I do my work!");
        }
        public  void GetFullName()
        {
            Console.WriteLine(FullName);
        }
        public void GetCarType()
        {
            Console.WriteLine("employee has a car!");
            _icarType.GetCarType();
        }
        public void GetInfo()
        {
            Console.WriteLine("Company employee!");
            _iinfo.GetInfo();
        }
    }
}

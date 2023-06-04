using ConsoleApp3;
using System;
namespace InheritanceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.Greet();
            LabObject newLab = new LabObject(1,"Suraj");
            newLab.ShowDetails();
            LabObject newLab2 = new LabObject(2, "Samir");
            newLab2.ShowDetails();
            LabObject newLab3 = new LabObject();
            newLab3.ShowDetails();

            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);

            B operation = new B();
            operation.add();
            operation.sub();
            operation.multiplication();

            MultipleInheritance fruit = new MultipleInheritance();
            fruit.color();
            fruit.taste();

            //accessing the inherited members in parent class from child class
            ChildClass child = new ChildClass();
            child.getIdFromParentClass();

            //accessing the inherited members in parent class from another child class
            AnotherChildClass child2 = new AnotherChildClass();
            child2.getIdFromParentClass();


        }
    }
    class LabObject
    {
        private int id = 14;
        public string name = "Suraj";
        //Create Default value if no argument were pass on LabObject
        public LabObject()
        {
            this.id = 14;
            this.name = "Arjun";
        }
        //Constructor Create
        public LabObject(int id, string name) 
        {
            this.id = id;
            this.name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Name of Student:" + name + " ID:" + id);
        }
        public void SetID(int id) 
        {
            this.id = id;

        }
    }
}
using InterfaceDemo.Interface_ex1;
using InterfaceDemo.Interface_EX2;
using InterfaceDemo.interface_ex3;

namespace InterfaceDemo
{
    internal class Program
    {
        //static void Print10Numbers(SeriesByTwo series )
        //{
        //    {
        //        for(int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(series.Current);
        //            series.Next();
        //        }
        //        Console.WriteLine();
        //        series.Reset();
        //    }

        //}
        //static void Print10Numbers(SeriesByThree series )
        //{
        //    {
        //        for(int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(series.Current);
        //            series.Next();
        //        }
        //        Console.WriteLine();
        //        series.Reset();
        //    }

        //}
        //static void Print10Numbers(Iseries series)
        //{
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(series.Current);
        //            series.Next();
        //        }
        //        Console.WriteLine();
        //        series.Reset();
        //    }

        //}
        static void Main(string[] args)
        {
            ////    ////interface :Reference type
            ////    ////Code Contract Between Developer who write it and the developer who use it [Implemntation]
            ////    ////IMtype myType = new MyType();
            ////    ////NOTE :Yoy can not create opject from any  interface
            ////    ////MyType myType=new MyType();
            ////    ////myType.salary = 12000;
            ////    ////Console.WriteLine(myType.salary);
            ////    ////myType.Myfun();
            ////    ////IMyType mytype1=new IMyType();
            ////    ////mytype1.Myfun();
            ////    //IMyType mytype;
            ////    ////Ref -->Can Refer to object From Any Class Whicth Implemnted the interface "IMType"
            ////    //mytype = new MyType();
            ////    //mytype.salary = 12000;
            ////    //Console.WriteLine(mytype.salary);
            ////    //mytype.Myfun();
            ////    //mytype.print();
            ////    //SeriesByTwo seriesbytwo= new SeriesByTwo();
            ////    //Print10Numbers(seriesbytwo);
            ////    //SeriesByThree seriesByThree = new SeriesByThree();
            ////    //Print10Numbers(seriesByThree);



            ////    //int[]numbers = { 7,8,5,3,2,1,9 };
            ////    //Array.Sort(numbers);
            ////    //foreach (int item in numbers)
            ////    //{
            ////    //    Console.WriteLine(item);
            ////    //        //}   

            ////    //        Employee[] employees = new Employee[3]
            ////    //        {
            ////    //new Employee { ID=1,Name = "Ahmed", Salary = 12000, Age = 30 },
            ////    //new Employee { ID=2,Name = "Ali", Salary = 15000, Age = 25 },
            ////    //new Employee {ID=3, Name = "Sara", Salary = 18000, Age = 28 }
            ////    //       };
            ////    //        Array.Sort(employees);
            ////    //        foreach (Employee item in employees)
            ////    //        {
            ////    //            Console.WriteLine(item);
            ////    //        }
            ////    //--------------------------------------------------------------------------//
            ////    //Car car = new Car();
            ////    //car.speed = 100;
            ////    //car.Forward();
            ////    //AirPlane airPlane = new AirPlane();
            ////    //IMoveable moveable = airPlane; 
            ////    //moveable.Forward();

            ////---------------------------------------------------------------------------//
            ////shallow copy Vs deep copy
            ////int[] Arr01 = { 1, 2, 3 };
            ////int[] Arr02= { 4,5,6 };
            ////Console.WriteLine(Arr01.GetHashCode());
            ////Console.WriteLine(Arr02.GetHashCode());

            ////  Arr02 = Arr01; //shallow copy
            //////Copy Identity
            //////{1,2,3}-->Has two References Arr01 and Arr02  
            //////{ 4,5,6 } -->unReachable Object
            ////Console.WriteLine();
            ////Console.WriteLine(Arr01.GetHashCode());
            ////Console.WriteLine(Arr02.GetHashCode());

            //////Identity  (Address)+Object State [Data]
            ////Arr02[0] = 100;
            //////Console.WriteLine(Arr01[0]);
            //////--------------------------------------------------------------//
            ////int[] Arr01 = { 1, 2, 3 };
            ////int[] Arr02 = { 4, 5, 6 };
            ////Console.WriteLine(Arr01.GetHashCode());
            ////Console.WriteLine(Arr02.GetHashCode());

            ////Arr02 = (int[])Arr01.Clone(); //deep copy
            //////Clone Method will copy the opject  state of the caller
            //////ASssign the new Opject to Arr02,will generate new identity  
            ////////Copy Identity
            ////////{1,2,3}-->Has two References Arr01 and Arr02  
            ////////{ 4,5,6 } -->unReachable Object
            //////Console.WriteLine();
            //////Console.WriteLine(Arr01.GetHashCode());
            //////Console.WriteLine(Arr02.GetHashCode());

            //////Identity  (Address)+Object State [Data]
            ////Arr02[0] = 100;
            ////Console.WriteLine(Arr01[0]);

            ////---------------------------------------------------------------------------//
            //////--------------------------------------------------------------//
            ////string[] Arr01 = { "Ahmed", "Ali", "Omar"};
            ////string[] Arr02 = { "Ziad", "Adel", "Amr" };
            ////Arr01 = Arr02;
            ////Console.WriteLine(Arr01.GetHashCode());
            ////Console.WriteLine(Arr02.GetHashCode());

            ////Arr02[0] = "Mohamed";
            ////Console.WriteLine(Arr01[0]);


            ////Arr02 = (string[])Arr01.Clone(); //deep copy
            ////Clone Method will copy the opject  state of the caller
            ////ASssign the new Opject to Arr02,will generate new identity  
            //////Copy Identity
            //////{1,2,3}-->Has two References Arr01 and Arr02  
            //////{ 4,5,6 } -->unReachable Object
            ////Console.WriteLine();
            ////Console.WriteLine(Arr01.GetHashCode());
            ////Console.WriteLine(Arr02.GetHashCode());

            //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr02 = { "Ziad", "Adel", "Amr" };
            //Arr01 = (string[])Arr02.Clone();
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Arr02[0] = "Mohamed";
            //Console.WriteLine(Arr01[0]);

            //---------------------------------------------------------------------------//
            //Employee E01 = new Employee
            //{
            //    ID = 1,
            //    Name = "Ahmed",
            //    Age = 30,
            //    Salary = 12000
            //};
            //Employee E02= new Employee
            //{
            //    ID = 2,
            //    Name = "Amr",
            //    Age = 25,
            //    Salary = 15000
            //};
            //E01= E02; //Shallow Copy
            //Console.WriteLine(E01);
            //Console.WriteLine(E02);

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //E01 =(Employee)E02.Clone();
            //Console.WriteLine();
            //Console.WriteLine(E01);
            //Console.WriteLine(E02); 
            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //---------------------------------------------------------------------------//
            //Employee[] employees = new Employee[3]
            //            {
            //    new Employee { ID=1,Name = "Ahmed", Salary = 12000, Age = 30 },
            //    new Employee { ID=2,Name = "Ali", Salary = 15000, Age = 25 },
            //    new Employee {ID=3, Name = "Sara", Salary = 18000, Age = 28 }
            //           };
            //Array.Sort(employees);
            ////int x = employees[0].CompareTo(employees[1]);
            //////+ :Caller is greater than the parameter
            //////- :Caller is less than the parameter
            //////0 :Caller is equal to the parameter   
            //Array.Sort(employees);
            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            //-----------------------------------------------------------------------------//
            Employee[] employees = new Employee[3]
                       {
                new Employee { ID=1,Name = "Ahmed", Salary = 12000, Age = 30 },
                new Employee { ID=2,Name = "Ali", Salary = 15000, Age = 25 },
                new Employee {ID=3, Name = "Sara", Salary = 18000, Age = 28 }
                      };
            Array.Sort(employees, new EmployeeCompareSalary());
            
            Array.Sort(employees);
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }


        }
    }
}

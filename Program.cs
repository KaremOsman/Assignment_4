using System.Numerics;
using System.Security.Claims;
using System.Threading;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q_1
            //Write a class named Calculator that contains a method named Add. Overload the Add method to:


            // sol

            //Calculator.Add(1, 2); // Calls the first method
            //Calculator.Add(2, 3, 4); // Calls the second method
            //Calculator.Add(1.5, 2.5); // Calls the third method
            #endregion

            #region Q_2
            //Create a class named Rectangle with the following constructors:
            //A parameterless constructor that sets the width and height to 0.
            //A constructor that accepts width and height as integers.
            //A constructor that accepts a single integer and sets both width and height to that value.



            //sol




            #endregion

            #region Q_3
            //Define a class Complex Number that represents a complex number with real and imaginary parts
            //Overload the +, - operator to add and subtract two complex numbers.

            //sol


            //ComplexNmber C1 = new ComplexNmber()
            //{
            //real = 3,
            //imaginary = 4
            //};
            //ComplexNmber C2 = new ComplexNmber()
            //{
            //real = 1,
            //imaginary = 2
            //};
            //ComplexNmber C3 = C1 + C2; // Calls the overloaded operator +
            //Console.WriteLine(C3); // Output: 4 + 6i
            //ComplexNmber C4 = C3 - C1; // Calls the overloaded operator -
            //Console.WriteLine(C4); // Output: 1 + 2i

            #endregion

            #region Q_4

            #region Part A
            // Create a base class named Employee with method That Work as it prints    "Employee ‎is  working".‎

            //sol

            //Employee Emp = new Employee();
            //Emp.Work();// Calls the static method Work of Employee class
            #endregion

            #region Part B
            //Create a derived class named Manager that overrides the Work method to print ‎‎"Manager is managing". ‎

            // sol

            //Employee Mang = new Manager();

            //Mang.Work(); // Calls the static method Work of Manager class, which overrides the Employee's Work method
            #endregion

            #endregion

            #region Q_5

            //1 - Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            //2 - Override All System. Object Members[To String(), Equals(), GetHashCode()] .
            // 
            // 
            //3 - Define All Required Constructors to Produce this output:

            //Duration D1 = new Duration(1, 10, 15);
            //D1.ToString(); 
            //Output: Hours: 1, Minutes: 10, Seconds: 15

            //Duration D1 = new Duration(3600);
            //D1.ToString(); 
            //Output: Hours: 1, Minutes: 0, Seconds: 0

            //Duration D2 = new Duration(7800);
            //D2.ToString(); 
            //Output: Hours: 2, Minutes: 10, Seconds: 0

            //Duration D3 = new Duration(666);
            //D3.ToString(); 
            //Output: Minutes: 11, Seconds: 6


            //sol

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());
            //// Output: Hours: 1, Minutes: 10, Seconds: 15

            //D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());
            //// Output: Hours: 1, Minutes: 0, Seconds: 0

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());
            //// Output: Hours: 2, Minutes: 10, Seconds: 0

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());
            //// Output: Minutes: 11, Seconds: 6


            #endregion
            #endregion

            #region Part 02
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine($"D1 = {D1}"); 

            //Duration D2 = new Duration(7800);
            //Console.WriteLine($"D2 = {D2}"); 

            //Duration D3 = new Duration(666);
            //Console.WriteLine($"D3 = {D3}");

            //D3 = D1 + D2;
            //Console.WriteLine($"D3 = {D3}");


            //D3 = D1 + 7800;
            //Console.WriteLine($"D3 = {D3}");


            //D3 = 666 + D3;
            //Console.WriteLine($"D3 = {D3}");


            //D3 = ++D1;
            //Console.WriteLine($"D3 = {D3}");

            //D3 = --D2;
            //Console.WriteLine($"D3 = {D3}");

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //if (D1 > D2)
            //Console.WriteLine("D1 is greater than D2");
            //else
            //Console.WriteLine("D1 is not greater than D2");

            //if (D1 <= D2)
            //Console.WriteLine("D1 is less than or equal to D2");

            //if (D1)
            //Console.WriteLine("D1 has time");
            //else
            //Console.WriteLine("D1 is zero");

            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine("As DateTime: " + Obj);
            #endregion
        }
    }

}

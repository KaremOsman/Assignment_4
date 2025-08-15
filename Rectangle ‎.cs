using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    #region Part 01
    #region Q_2
    internal class Rectangle
    {
        double width { get; set; }
        double height { get; set; }


        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(int value)
        {
            width = value;
            height = value;
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return $"Width: {width}, Height: {height}";
        }
    }
    #endregion

    #region Q_3
    internal class ComplexNmber
    {
        #region Properties
        public int real { get; set; }
        public int imaginary { get; set; }
        #endregion


        public static ComplexNmber operator +(ComplexNmber R, ComplexNmber L)
        {
            return new ComplexNmber()
            {
                real = (R?.real ?? 0) + (L?.real ?? 0),
                imaginary = (R?.imaginary ?? 0) + (L?.imaginary ?? 0)
            };
        }
        public static ComplexNmber operator -(ComplexNmber R, ComplexNmber L)
        {
            return new ComplexNmber()
            {
                real = R.real - L.real,
                imaginary = R.imaginary - L.imaginary
            };
        }

        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
    #endregion

    #region Q_4
    #region part A
    internal class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee Is Working");
        }
    }
    #endregion

    #region part B
    internal class Manager : Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager Is Working");
        }
    }
    #endregion

    #endregion

    #region Q_5
    #region a
    //a) Create a base class BaseClass with a virtual method DisplayMessage that prints "Message from BaseClass".

    //sol
    public class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }
    #endregion

    #region b
    //b) Create a derived class DerivedClass1 that overrides the DisplayMessage method to print "Message from DerivedClass1".

    // sol
    public class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }
    // With override, it will be Late Binding, and the CLR will determine 
    // the method to execute based on the actual object type at runtime.
    #endregion

    #region c
    //C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.

    // sol
    public class DerivedClass2 : BaseClass
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }

    // With new, it will be Early Binding, and the method to execute 
    // is determined at compile time based on the reference type.
    #endregion
    #endregion
    #endregion

    #region Part 02
    public class Duration 
    {
        #region 01
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region 03
        public Duration(int hour, int minutes, int seconds)
        {
            Hours = hour;
            Minutes = minutes;
            Seconds = seconds;

        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        } 
        #endregion

        #region 02
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours : {Hours},Minutes : {Minutes}, Seconds : {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes : {Minutes}, Seconds : {Seconds}";
            }
            else
            {
                return $"Seconds : {Seconds}";
            }

        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours &&
                    Minutes == other.Minutes &&
                    Seconds == other.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }
        #endregion

        #region 04
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }
        public static Duration operator +(Duration D, int Seconds)
        {
            return new Duration(D.Hours, D.Minutes, D.Seconds+Seconds);
        }
        public static Duration operator +(int Seconds, Duration D)
        {
            return new Duration(D.Hours, D.Minutes, D.Seconds+Seconds);
        }
        public static Duration operator ++(Duration D)
        {
            return new Duration(D.Hours, D.Minutes +1, D.Seconds);
        }
        public static Duration operator --(Duration D)
        {
            return new Duration(D.Hours, D.Minutes -1, D.Seconds);
        }
        public static bool operator >(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) > (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }
        public static bool operator <(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) < (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            return (D1.Hours * 3600 + D1.Minutes * 60 + D1.Seconds) >= (D2.Hours * 3600 + D2.Minutes * 60 + D2.Seconds);
        }
        public static bool operator <=(Duration D1, Duration D2)
        {
            return (D1<D2)|| D1.Equals(D2);
        }
        public static bool operator true(Duration D)
        {
            return (D.Hours != 0 || D.Minutes != 0 || D.Seconds != 0);
        }
        public static bool operator false(Duration D)
        {
            return (D.Hours == 0 || D.Minutes == 0 || D.Seconds == 0);
        }

        public static explicit operator DateTime(Duration D)
        {
            return DateTime.Today
                .AddHours(D.Hours)
                .AddMinutes(D.Minutes)
                .AddSeconds(D.Seconds);
        }

        #endregion


    }
    #endregion

}


using common;
using System;
using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;

namespace Deno03
{
    // Byte => 0 -> 255 


    enum Season : byte
    { 
        Spring = 10, 
        Winter,
        Summer,
        Autumn
    }

    enum WeakDay
    { 
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday    
    }

    enum Gender
    { 
        M = 1,
        F = 2,
        Male = 1,
        Female = 2
    }

    // Read, Write, Execute, Delete


    enum Permissions
    { 
        Read,
        Write,
        Execute,
        Delete
    }


    internal class Program
    {


        //static void DoSomeCode()
        //{ 

        //    int X, Y, Z;
        //    X = int.Parse(Console.ReadLine());
        //    Y = int.Parse(Console.ReadLine());

        //    Z = X / Y;

        //    int[] Arr = { 1, 2, 3 };

        //    Arr[99] = 10;        
        //}

        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());

                Z = X / Y;

                int[] Arr = { 1, 2, 3 };

                Arr[99] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally");

                // Release | Deallocate | Disconnect | Dispose to UnManged Resourse 
            }
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }


        static void DoSomeProtectiveCode()
        {
            try
            {

                int X, Y, Z;
                bool Flag;
                do
                {
                    Console.WriteLine("Enter First Number: ");
                    Flag = int.TryParse(Console.ReadLine(), out X);

                } while (Flag == false);

                do
                {
                    Console.WriteLine("Enter Second Number: ");
                    Flag = int.TryParse(Console.ReadLine(), out Y);

                } while (Flag == false | Y == 0);

                Z = X / Y;

                int[] Arr = { 1, 2, 3 };

                if (99 < Arr?.Length)
                {
                    Arr[99] = 10;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);               
            }
        }


        static void Main()
        {
            #region V1_Boxing And-UnBoxing



            // Boxing : Casting From ValueType To ReferenceType 
            // UnBoxing : Casting From ReferenceType TO Value Type


            //object O1;

            //// O1 => Can Refer To instance Of "Object" Or Any Instance Of Any Type 

            //// O1 = 1;
            //// O1 = "Ahmed";


            // O1 = 3;              // Cast From ValueType[int] To ReferenceType        => Boxing
            // O1 = 1.5;              // Cast From ValueType[double] To ReferenceType        => Boxing
            // O1 = 'A';              // Cast From ValueType[char] To ReferenceType        => Boxing
            // O1 = true;              // Cast From ValueType[bool] To ReferenceType        => Boxing
            // O1 = new DateTime();              // Cast From ValueType[DateTime] To ReferenceType        => Boxing

            //int X = 5;

            //object O1 = X;

            //// Implict Casting
            //// Safe Casting
            //// Boxing
            //// Parent = Child => Child is Parent
            //// Animal = Dog => Dog is Animal


            //object O1 = 3;
            //int X = O1; // invalid Casting


            //object O1 = 3;
            //int X = (int) O1; // Valid Casting


            // Explicit Casting
            // UnSafe Casting [May Throw Exption]
            // UnBoxing
            // Dog = (Dog) Animal => Animal Is Dog
            // Child = Parent => Parent is Child  
            #endregion

            #region Nullable_Types

            #region V2_ nullable-ValueType

            // Nullable Types (?) 

            // Value Type
            // Reference Type



            // int X = 6;

            // X = null; // Not Valid 

            // Nullable Value Type => Value Type Allow Null as Valid Value

            // Nullable<int> : Allow int Value or Null As Valid Value
            //int? Age = 20;

            //Age = null;

            // Nullable<double> Allow double Value or Null As Valid Value 
            //double? Salary = 4000.5;

            //Salary = null;


            //int X = 5;

            //// Y : Nullable<int>
            //// Y : Allow int Value or Null

            //int? Y = /*(int?)*/ X;

            //// Implicit Casting
            //// Safe Casting

            //Console.WriteLine(Y);



            //int? X = 5;

            //X = null;

            //X = null;
            // Y = int
            // Y : Allow Int Value Only

            //int Y ;

            // Explicit Casting
            // May Throw Exception


            // Defensive Code

            //if (X != null) 
            //    Y = (int)X;
            //else
            //    Y = 0;

            // ======================



            //if (X is not  null)
            //    Y = (int)X;
            //else
            //    Y = 0;

            // ===================

            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;

            // ==================

            //Y = X.HasValue ? X.Value : 0;

            // ===================

            //Y = X is not null ? X.Value : 0;

            // =====================

            // Null Coalescing Operator ?? 

            //Y = X ?? 0; // Suntax Sugar :   X is not null ? X.Value : 0


            //Console.WriteLine(Y); 
            #endregion

            #region V3_Nullabe Reference Type-[C# 10.0 .Net 6.0]
            // Nullabe Reference Type [C# 10.0 .Net 6.0]

            //string Message = "Hello";
            //Message = null;

            //Console.WriteLine(Message);

            //String Message01 = null; // Required


            //string? Message02 = null; // Nullable

            //Console.WriteLine(Message01.Length);
            //Console.WriteLine(Message02);

            #endregion
            #endregion

            #region V4-Null-Propagation-Operator ?
            //// Null Propagation Operator ?

            //// double X = default; // 0
            //// bool C = default;  // False

            //// Console.Writeline(C);  

            //int[] Arr = default; // Null
            //                     // int[] Arr = { 1, 2, 3, 4, 5 };


            //// Best Practice
            ////if (Arr is not null)
            ////{
            ////    for (int i = 0; i < Arr.Length; i++)
            ////        Console.WriteLine(Arr[i]);
            ////}

            ////for (int i = 0; (Arr is not null) && i < Arr.Length; i ++)
            ////    Console.WriteLine(Arr[i]);

            ////for (int i = 0; (Arr is not null) && i < Arr?.Length; i++)
            ////    Console.WriteLine(Arr[i]);


            ////int Len = Arr is not null ? Arr.Length : 0;

            ////int? Len = Arr?.Length;

            ////int? Len = Arr?.Length is not null ? Arr.Length : 0;

            //int Len = Arr?.Length ?? -1;

            //Console.WriteLine(Len); 
            #endregion

            #region V5- Exception Handling And Protictive Code

            // Exception Handling And Protictive Code


            //DoSomeCode();
            //DoSomeProtectiveCode();

            //Console.WriteLine("Hello After Exception");



            //// Exception
            //// 1. SystemException
            ////   1.1.  FormatException
            ////   1.2.  EndexOutOfRangeException
            ////   1.3.  NullReferenceException
            ////   1.4.  ArithmeticException
            ////       1.4.1. OverFlowException 
            ////       1.4.2. DividedByZeroException 
            //// 2. ApplicationException

            #endregion

            #region V6 -Access Modifiers
            // Class Library 

            //common.TypeA typeA = new common.TypeA(); // Invalid TypeA is internal 


            //common.TypeB typeB = new TypeB(); // Valid TypeB is public 

            //typeB.X = 12; // Invalid Private
            //typeB.Y = 12; // Invalid internal
            //typeB.Z = 12; // Valid Puplic

            #endregion

            #region V7,8-Enum:Value Types

            // Enum : Value Types // (Create In NameSpace)
            // STACK  

            //int Number = 10;


            //Season S01 = Season.Winter;

            //S01 = Season.Spring;

            //Console.WriteLine((int)S01);


            // STACk 

            // CLR Represent Enum As Integer Value In Memory


            //Gender G01 = (Gender) 1;


            //Console.WriteLine(G01);



            //Gender G01 =(Gender) Enum.Parse(typeof(Gender), Console.ReadLine(), true);

            //Gender G01;
            //Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object O1);

            //G01 = (Gender) O1;

            //Console.WriteLine(G01);


            Permissions Per01 = Permissions.Read;
            Per01 ^= Permissions.Delete; // Toggle

            Console.WriteLine(Per01);

            #endregion

        }
    }
}

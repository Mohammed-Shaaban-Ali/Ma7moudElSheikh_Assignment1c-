using System;
using System.Drawing;

namespace c_Session1
{
    internal class DEMO
    {
        static void Main(string[] args)
        {
            #region MyRegion
            {
                //Console.WriteLine("Hello, World!");
                //Console.WriteLine("Hello, World!");
                //Console.WriteLine("Hello, World!");
                //Console.WriteLine("Hello, World!");


            }
            #endregion
            #region MyRegion
            // variable Declearation 
            //Datatype variableName 
            //int Number;  //Declear variable 
            //             // Allocate unitialized 4 bytes At Memory
            //Number = 5;  

            // 1.Name     :number
            // 2.Datatype   :int 
            //3.Size         :4bytes
            //4.Value        :5
            //5.Address       :0xF2A

            //Console.WriteLine(Number);
            //int Number = 5;    // Declear and intialization for the number
            //Console.WriteLine(Number);
            //int Number01;
            //int Number02;
            //int Number03;                 
            //int Number1;int Number2;int Number3;
            //Console.WriteLine(Number1);
            //Number1 =7
            //Console.WriteLine(Number2);
            //Console.WriteLine(Number3);
            #endregion

            #region
            //Data type (value type ): stack
            // Declare variable 
            //int Number;    // Value Type 
            ////Allocate un initialization 4 bytes At stack
            //// int :c#Keyword
            //Int32 Number02;
            //Number = 12;

            ////Console.WriteLine(Number);

            #endregion
            #region MyRegion
            //Point P01; // Referance 
            //////Declare Referance from type 'point' 
            ////// p01 :can refer to object from type 'point'
            ////// 8Byte will be allocate at stack for the 'p01'
            //////8 byte will be allocate at heap
            //////Console.WriteLine(P01); 
            //////Console.WriteLine(P01.X);
            //P01 = new Point();
            // NEW 
            //1.Allocate the number of required Bytes for the opject at Heap
            //2.intialize the allocated Bytes with the Defult value of the DTATA TYPE 
            //3.CALL User Defind constractor if Exsits
            //4.Assign The opject Address To The Referance 'p01'

            //Console.WriteLine(P01.X);  //0
            //Console.WriteLine(p01.y);  //0
            //Console.WriteLine(P01);  // C_Basic01G04.Point

            //Point P02 = new Point();

            //P02.X = 12;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);

            //P01 = P02;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);
            #endregion

            #region MyRegion
            //object 001;
            //object O01;
            //// Declare For Reference From Type 'Object'
            //// O01 : Can Refer To Instance From Type 'Object' Or Any Type Inherited From Object

            //O01 = new object();
            //O01 = 1;
            //O01 = 'A';
            //O01 = 1.2;
            //O01 = true;
            //O01 = new Point();

            //Console.WriteLine(O01);  
            #endregion

            // Casting : Convert From Any Datatype To Any Datatype
            // 1. Implicit Casting

            //int X = 5;

            //double Y = /*(double)*/ X;  // Implicit Casting (Safe Casting)

            //Console.WriteLine(Y);

            // 2. Explicit Casting

            //double X = 2.5;

            //int Y = (int)X; // Explicit Casting (UnSafe)

            //Console.WriteLine(Y);

            //long X = 1111111111111111111;

            //int Y = (int)X; // Explicit Casting (UnSafe)

            ////Console.WriteLine(Y);

            ////Console.WriteLine(int.MaxValue);


            // Parse : Function

            //Console.WriteLine("Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("GPA : " + GPA);

            // Convert : Class


            //Console.WriteLine(value: "Enter Your Age:");
            //int Age = Convert.ToInt32(Console.ReadLine());

            ////Console.WriteLine("Enter Your GPA:");
            ////double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            ////Console.WriteLine("GPA : " + GPA);
            ///


            // TryParse

            //Console.WriteLine(value: "Enter Your Age: ");
            //int Age;
            //bool Flag = int.TryParse(Console.ReadLine(), out Age);

            ////Console.WriteLine("Enter Your GPA : ");
            ////double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("Flag : " + Flag);

            //double X = 1.5;
            //float Y = 1.5F;
            //decimal Z = 1.5m;

            //int X = 1_000_000_000; // Discard _

            //Console.WriteLine(X);


            #region OPERATORS


            // 1. Unary Operators -> Works On One Operand (Variable) ++ --
            //int X = 10;

            //// ++
            //// Prefix [Increment then print]
            //Console.WriteLine(++X); // 11
            // Postfix [Print then Increment]
            //Console.WriteLine(X++); // 10
            //Console.WriteLine(X); // 11

            //// --
            //// Prefix [Decrement then print]
            //Console.WriteLine(--X); // 9
            //                        // Postfix [Print then Increment]
            //Console.WriteLine(X--); // 10
            //Console.WriteLine(X); // 9

            #endregion


            // 2. Binary Operators => Works on Two Operands (Variables)

            // + = / * %

            // int Sum, Mul, Sub, Mod;

            // int Number01 = 2, Number02 = 6;

            // Sum = Number01 + Number02; // 8

            // Mul = Number01 * Number02; // 12

            // Sub = Number01 - Number02; // -4

            // Mod = Number01 % Number02; // 2

            // 23 % 3 = 2

            //==================================

            // 3. Assignment Operators


            // int X;
            // X = 4;

            // X += 2; // X = X + 2 // 6
            // X -= 2; // X = X - 2
            // X *= 2; // X = X * 2
            // X /= 2; // X = X / 2
            // X %= 2; // X = X % 2

            // 4. Relational Operators

            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y);
            //Console.WriteLine(X != Y);
            //Console.WriteLine(X > Y);
            //Console.WriteLine(X < Y);
            //Console.WriteLine(X >= Y);
            //Console.WriteLine(X <= Y);

            // 5. Logical Operators [AND , OR , NOT]
            // Console.WriteLine(!false); // ! -> Not
            // Console.WriteLine(false && true); // && -> AND Short Circuit
            // Console.WriteLine(true || false); // || -> OR Short Circuit

            // 6. BitWise Operators
            // Console.WriteLine(!false); // ! -> Not
            // Console.WriteLine(false & true); // & -> AND Long Circuit
            // Console.WriteLine(false | true); // | -> OR Long Circuit

            // 7. Ternary Operator [Conditional Operator]

            // bool flag = 4 > 2;
            // Console.WriteLine(flag);
            //string flag = 4 < 2 ? "Correct" : "Not Correct";
            //Console.WriteLine(flag);

        }
    }
}

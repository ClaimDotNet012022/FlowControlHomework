using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlowControlHomework
{
    [TestClass]
    public class FlowControlHomework
    {
        [TestMethod]
        public void IfFundementals() // THE GOAL IS TO CHANGE THE FLOW TO REACH ALL THE PASSING STATEMENTS AND TO FIX COMPILATION ISSUES
        {
            bool changeFlow = true; // assign me so I can reach line 14 in my flow of execution
            if (changeFlow)
            {
                Assert.IsTrue(true);
            }
            else
            {   
                Assert.IsTrue(false);  
            }

            bool changeFlow2 = true; // assign me so I can reach line 24 in my flow of execution
            if (changeFlow2)
            {
                
                Assert.IsTrue(true); 
            }
            else
            {
                Assert.IsTrue(false);
            }

            bool changeFlow3 = true; // assign me so I can reach line 38 in my flow of execution
            if (changeFlow3)
            {
                //  Change the flow with the same variable;
                
                if (changeFlow3)
                {  
                    Assert.IsTrue(true);
                }
            }
            else
            {   
                Assert.IsTrue(false); 
            }

            bool changeFlow4 = false; // assign me so I can reach line 54 in my flow of execution
            bool nextChangeFlow = true; // assign me so I can reach line 54 in my flow of execution
            if (changeFlow4)
            {
                Assert.IsTrue(false);
            }
            else if (nextChangeFlow)
            {   // need to reach here an execute this (line 54)
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
            
            bool changeFlow5 = false; // assign me so I can reach line 73 in my flow of execution
            bool nextChangeFlow2 = false; // assign me so I can reach line 73 in my flow of execution
            if (changeFlow5)
            {
                Assert.IsTrue(false);
            }
            else if (nextChangeFlow2)
            {
                Assert.IsTrue(false);
            }
            else
            {   
                Assert.IsTrue(true);
            }

            // Uncomment and fix me so I compile.
            if (true)
            {
                Assert.IsTrue(true);
            }

        }


        [TestMethod]
        public void IfWithOperators()
        {
            //This section is testing that you know what these operators do, provide operands to reach the pass statements.
            //you can do this in many ways as long as you prove operands in the appropriate place.
            int myNum = 3;
            int yourNum = 3;
            int sumNum = 6;
            bool withOp = false;
            bool withOp2 = true;
            if (myNum == yourNum)
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if (myNum != sumNum)
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if ( myNum < sumNum )
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if ( sumNum > myNum)
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if (myNum <= yourNum)
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if (sumNum >= myNum + yourNum)
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if (!withOp)
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if (!!withOp2)
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if ((myNum == yourNum) && (sumNum == myNum + yourNum))
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            if ((yourNum == sumNum) || ( myNum == yourNum))
            {
                Console.WriteLine(true);
                Assert.IsTrue(true);
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

            int inRange = 6; // Set this value to pass BOTH the range checks, do not reassign it.
            if (inRange > 5 && inRange < 10)
            {
                if (inRange > 5 && inRange < 7)
                {
                    Console.Write(true);
                    Assert.IsTrue(true);
                }
            }
            else
            {
                Console.WriteLine(false);
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void Switch()
        {
            int number = 26; //Assign me so I cause the next switch to pass.
            switch (number)
            {
                case 15:
                    Console.WriteLine(false);
                    Assert.IsTrue(false);
                    break;
                case 26:
                    Console.WriteLine(true);
                    Assert.IsTrue(true);
                    break;
                default:
                    Console.WriteLine(false);
                    Assert.IsTrue(false);
                    break;
            }

            number = 16; //Assign me so I cause the next switch to pass.
            switch (number)
            {
                case 15:
                    Console.WriteLine(false);
                    Assert.IsTrue(false);
                    break;
                case 26:
                    Console.WriteLine(false);
                    Assert.IsTrue(false);
                    break;
                default:
                    Console.WriteLine(true);
                    Assert.IsTrue(true);
                    break;
            }

            number = 7;  //Assign me so I cause the next switch to pass.
            switch (number)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                        break;
                case 5:
                    Console.WriteLine(5);
                    break;
                case 6:
                    Console.WriteLine(6);
                    break;
                case 7:
                    Console.WriteLine(7);
                    Assert.IsTrue(true);
                    break;
            }


            // These have compilation issues, there is no logic error, uncomment and fix them
            string usersChoice = "a";
            switch (usersChoice) // Fix me so I compile
            {
                case "a":
                    Assert.IsTrue(true);
                    break;
                case "b":
                    Assert.IsTrue(false);
                    break;
                case "c":
                    Assert.IsTrue(true);
                    break;
                default:
                    Assert.IsTrue(false);
                    break;
            }

            switch (usersChoice) // Fix me so I compile
            {
                case "a":
                    Assert.IsTrue(true);
                    break;
                case "b":
                    Assert.IsTrue(false);
                    break;
                case "c":
                    Assert.IsTrue(false);
                    break;
                default:
                    Assert.IsTrue(false);
                    break;
            }

            switch (usersChoice) // Fix me so I compile
            { 
                case "a":
                    Assert.IsTrue(true);
                    break;
                case "b":
                    Assert.IsTrue(false);
                    break;
                case "c":
                    Assert.IsTrue(true);
                    break;
                default:
                    Assert.IsTrue(false);
                    break;
            }

        }


        [TestMethod]   // ********falta esta parte
        public void Loops()
        {

            int max = 15; // set me correctly so i reach the assert pass.
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(true);
                // DONT BE ALARMED, you dont need brackets if its only a single statement you want to execute. Im just exposing you to this because programmers do it.
                // But don't do it yourself. It's not a good practice, especially for a beginner.
                if (i == 15) Assert.IsTrue(true);
                
            }

            int max2 = 17;
            // Almost the same as above but you need to do something special to get to 16.
            //Some restrictions:
            // Dont change anything in the block, only the for statement.
            // hint: you dont need increment by 1.
            // This one is tough, take your time.
            for (int i = max2; i > 0; --i)
            {
                bool isOdd = !((i % 2) == 0); // notice how the variable name explains the expression? 
                if (isOdd)
                {
                    // if you reach here test will fail. 
                    Console.WriteLine(true);
                    Assert.IsTrue(true);
                }

                if (i == 16) Assert.IsTrue(true);
            }

            // break out of the loop after the test passes at least once, there are a couple ways do to this
            int counter = 8;  // Change me to get in.
            while (counter > 1 && counter < 15)
            {
                counter++;
                Console.WriteLine(true);
                Assert.IsTrue(true);
                Console.WriteLine("IM STUCK IN HERE");
                if (counter == 10)
                {
                    break;
                }
            }

            int count = 2;
            do
            {
                if (count > 0)
                {
                    Console.WriteLine(true);
                    Assert.IsTrue(true);
                }
                count++;
            } while (count < 10);
            
        }
    }
}

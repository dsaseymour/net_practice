using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.Arrays
{
    /*
    Given an unsorted array A of size N ofnon-negative integers, find a continuoussub-array which adds to a given number.*/

    /*

     Input:
    The first line of input contains an integer T denoting the number of test cases.
    Then T test cases follow. Each test case consists of two lines. 
    The first line of each test case is N and S, where N is the size of array and S is 
    the sum. The second line of each test case contains N space separated integers denoting 
    the array elements.

    Output:
    For each testcase, in a new line, print the starting and ending positions(1 indexing) of first such occuring subarray from
    the left if sum equals to subarray, else print -1.        
     */


    class SubarrayWithSum
    {


        public int [] findSolution (int [] unsortedArray, int sumGoal){
            int numOfTestCases= Console.Read();
            int sizeofArray;
            int sumofArray;
            int[] sol;
            for (int i=1;i<=numOfTestCases;i++)
            {
                if (i == 1)
                {
                    sizeofArray = Console.Read();
                    sumofArray = Console.Read();
                    sol = new int[sizeofArray];
                }
                else {
                    Console.ReadLine();                    



                }






            }









            sol[0] =1;
            return sol;
        }


    }
}

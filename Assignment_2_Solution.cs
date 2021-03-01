using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = {0,1,0,3,12};
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5,indices);
            Console.WriteLine();
            

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if(Isomorphic(s61,s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if(HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number",n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if(profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}",profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                //Logic - fill the data in the array from two indexs
                // 1 - From the begining i.e. index 0 and 
                // 2 - From the middle of array i.e. from n 
                
                //initialize variables and array of given length
                int index= 0;
                int [] arr = new int[nums.Length] ;
                
                //Create loop to add values in the index 0 and index n
                for(int i=0;i<n;i++){
                    arr[index] = nums[i];
                    index++;
                    arr[index] = nums[(i+(n))];
                    index++;
                }
            //Dispay the output array    
            Console.WriteLine("[{0}]", string.Join(", ", arr));   
                
            }
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
       /// Example:
       ///Input: [0,1,0,3,12]
       /// Output: [1,3,12,0,0]
       /// </summary>
       
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                //Logic - Add non-zero values to new array of required size and display output
                //New array is populated with initially zeroes (Which serves the purpose) 
                
                //initialize variables and array of given length 
                int j = 0;
                int []arr = new int[ar2.Length];

                //Create loop to add values in the index 0 and increament for non zero values
                //Zeroes are present at the remaining places
                
                for(int i=0; i< ar2.Length; i++)    {
                    if(ar2[i]>0)    {
                        arr[j] = ar2[i];
                        j++;
                    }
                } 
            //Dispay the output array
            Console.WriteLine("[{0}]", string.Join(", ", arr));   
            }
            
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }
        

        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                //Logic - Create two counters for count repeated numbers
                // Compare 1st and nth number
                //1st loop increases nth places till the end of array
                //2nd loop increases the 1st number till the end of array
                
                
                int Count = 0;
                //1st loop increases nth places till the end of array
                
                for(int i = 0; i < nums.Length; i++)  
                
                //2nd loop increases the 1st number till the end of array
                    for(int j = i+1; j < nums.Length; j++)    {
                        if(nums[i] ==nums[j])
                            Count++;
                    }
                    
                //Dispay the output count    
                Console.WriteLine(Count);        
                
            }
            
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
                private static void TwoSum(int[] nums, int target)
        {
            try
            {
                //Logic - add 2 numbers in array  
                //Create 2 loops to traverse over the array
                //check with the target number if addition matches
                
                //initialize variable
                int sum = 0;
                //Create 2 loops to travers the array and add
                for(int i = 0; i < nums.Length; i++)
                    for(int j = i+1; j < nums.Length; j++)    {
                        sum = nums[i] + nums[j];
                        //check with the target number if addition matches
                        if(sum ==target)
                        //Dispay the output array

                            Console.WriteLine("[{0}]", string.Join(", ", i,j));
                    }
                
            }
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] index)
        {
            try
            {
                //Logic - Create a new array 
                //Based on indices add the chars to the new array
                //Loop it over 
                //Dispay final output
                
                //initialize array of required lenght
                char[] arr = new char[index.Length];

                int n = index.Length;
                
                //Create loop to add values in the index 0 and increament for non zero values
                for(int i = 0; i < n; i++)   {
                    arr[index[i]] = s[i];
                    
                    // Step wise change in output
                    //Console.WriteLine("[{0}]", string.Join(", ",arr));
                }
            //Dispay the output array
            Console.WriteLine(arr);
            }
            
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string str1, string str2)
        {
            try
            {
                //Logic - consider every character of both strings 
                //Check if all occurrences of it maps to same character in ‘str2’
                
                // initialize variables,
                int size =256;
                int m = str1.Length;
                int n = str2.Length;
                
                //Check the length of both strings that must be same   
                if (m != n)
                    return false;
                //Check for visited chars 
                bool[] marked = new bool[size];

                for (int i = 0; i < size; i++)
                    marked[i] = false;

                int[] map = new int[size];

                for (int i = 0; i < size; i++)
                    map[i] = -1;

                //Iterate through string  
                for (int i = 0; i < n; i++)
                {
                    if (map[str1[i]] == -1)
                    {
                        if (marked[str2[i]] == true)
                            return false;
                        marked[str2[i]] = true;

                        //store current char
                        map[str1[i]] = str2[i];
                    }
                    else if (map[str1[i]] != str2[i])
                        return false;
                }
                //Return true if string are Isomorphic
                return true;
            }
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                //Logic - Create the dictionary to store the students data (id and scores)
                //Find the unique values of the IDs array. These will be the keys in the dictionary.
                //Create new top 5 value array and add
                //Take the average for each KeyValuePair
                
                //Create dictionary to store the students data
                Dictionary<int, int[]> highFiveDict = new Dictionary<int, int[]>();

                //Create an array of the first column, IDs.
                int noOfScores = items.GetLength(0);
                int[] idArray = new int[noOfScores];
                for (int i = 0; i < noOfScores; i++)
                {
                    idArray[i] = items[i, 0];
                }
                //Find the unique values of the IDs array. These will be the keys in the dictionary.
                int[] keysArray = idArray.Distinct().ToArray();

                //Adds the keys and values to our dictionary.
                foreach (int ID in keysArray)
                {
                    //Determine what size the value array should be (with Loop)             
                    int count = 0;
                    for (int i = 0; i < noOfScores; i++)
                    {
                        if (items[i, 0] == ID)
                        {
                            count++;
                        }
                    }
                    //Create Value array
                    int[] valuesArray = new int[count];

                    //Fill in the value array (2nd Loop).
                    int j = 0;
                    for (int i = 0; i < noOfScores; i++)
                    {
                        if (items[i, 0] == ID)
                        {

                            valuesArray[j] = items[i, 1];
                            j++;
                        }
                    }
                    //create a new one containing the top 5 scores.
                    int[] finalValuesArray = new int[5];

                    Array.Sort(valuesArray);
                    //Add the top 5 values to the final array.
                    for (int i = 0; i < 5; i++)
                    {
                        finalValuesArray[i] = valuesArray[valuesArray.Length - 1 - i];
                    }
                    //Add to dictionary
                    highFiveDict.Add(ID, finalValuesArray);
                }

               //For each KeyValuePair in the dictionary calculate the average and print.
                foreach (KeyValuePair<int, int[]> entry in highFiveDict)
                {
                    int sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        sum += entry.Value[i];
                    }
                    int average = sum / 5;
                    
                    //Dispay the output array
                    Console.WriteLine();
                    Console.Write("[" + entry.Key + ", " + average + "]  ");
                }
                Console.WriteLine();
            }
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                //Logic - seperate the number in quotient and reminder
                //Square the reminder & store in variable
                //Add the squared term to the variable and repeat 
                //Check if the final value comes out to be 1
                
                //Initialize required variables
                int remainder, sum=0; 
                
                //Loop until the sum reaches 1
                while(sum!=1)     { 
                    sum=0;
                    //Repeat to add the squared term to the variable
                    while(n>0)    { 
                        //Seperate the number and reminder
                        remainder=n%10; 
                        //Square the reminder & store in variable
                        sum+=(remainder*remainder); 
                        n=n/10;  
                    } 
                n=sum; 
                } 
           //Check if final sum comes out to be 1
            if(sum == 1) 
            return true; 
            else 
            return false;                
            }
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                //Logic - Check in the array if minimum price is higher than current price
                //Loop to find the minimum price
                //Maximum profit will be the differece of buying price and recently found minimum price
                //Update the difference
                //Return the maximum of the differece with our found minimum price
                
                
                int maxProfit=0; 
                int minPrice = int.MaxValue;
                //Loop to find the minimum price
                for(int i=0;i<prices.Length;i++)    {
                    if(prices[i]<minPrice)
                        minPrice = prices[i];
                    else
                        //Maximum profit will be the differece of buying price and recently found minimum price
                        maxProfit = Math.Max(maxProfit,prices[i]-minPrice);
                }
                return maxProfit;
            }
            //Throw exception if there should be any error
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int n)
        {
            try
            {
            //Logic - The answer the stairs problem is following Fibbonacci Series.
            //For 0 or 1 return the output as 1
            //For remaining numbers return the output as sum of previous 2 numbers
            //Create a loop adding the previous 2 numbers of Fibbonacci Series.
            
            ///For 0 or 1 input, return the output as 1
            if(n == 1 || n == 0)
				Console.WriteLine(1);
            else    {
                int result = 0;
    			int[] stairs = new int[n+1];
    			stairs[0] = 1;
    			stairs[1] = 1;
    			
    			    //Create a loop adding the previous 2 numbers of Fibbonacci Series
        			for(int i = 2; i <= n; i++)
        			{
        				result = stairs[i - 1] + stairs[i - 2];
        				stairs[i] = result;
        			}
        		//Dispay the output
    			Console.WriteLine(result);
                }
            }
            //Throw exception if there should be any error            
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                throw;
            }
        }
    }
}

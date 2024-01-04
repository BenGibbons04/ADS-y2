using System;
using System.Linq;


namespace RoundRobin
{
    class Exercises
    {

        static bool checkValue(int[,] queue, int i){
          if (queue[i,0] <= 0){
            return false;
          }
          else{
            return true;
          }
        }

        public static void Main(string[] args)
        {
          // Enter your code after this line

          
          int[,] queue = {{5,1}, {11,2}, {6,3}, {8,4}, {13,5}, {3,6}, {10,7},{16,8},{1,0}};  //Generates the dataset that will be cycled through, with the time taken to complete the task and the pointer to the nect item included
          int time_taken = 2;


          int QLen= (queue.GetLength(0));
          int total_Completed = 0;

          bool allCompleted = false;

          while (allCompleted != true){
            int[] orderCompleted = new int[]{};
            for(int i = 0; i <(QLen); i++){
              if(checkValue(queue, i) == true){
                queue[i, 0] = queue[i, 0] - time_taken;
                /*Console.WriteLine("Time Remaining on task :"+ (i+1) + ": " + queue[i, 0]);*/

                Console.WriteLine("Next Task: " + (queue[i, 1]));
              }
              else{
                if(i==0){
                  queue[(QLen-1),1]++;
                }
                else if(i ==0){
                  queue[i, 1]++;
                }
                total_Completed++;
                Console.WriteLine("Task " + (i+1) + " completed!");

                if (total_Completed== QLen){
                  allCompleted = true;
                } 
              }
            Console.WriteLine(queue[i, 1]);
              
          }
        }
        Console.WriteLine("All Tasks Completed!!");




          // Enter your code before this line
        }
  }
}

using System;
using System.Linq;


namespace Project2
{
    class Exercises
    {

        static int add(int total, string num){

            int num1 = Convert.ToInt32(num);
            return(total + num1);
        }

        static int sub(int total, string num){
            int num1 = Convert.ToInt32(num);
            return(total - num1);
        }

        static int mult(int total, string num){
            int num1 = Convert.ToInt32(num);
            return (total * num1);
        }

        static float div(int total, string num){
            int num1 = Convert.ToInt32(num);
            return (total / num1);
        }

        static bool Less(int total, string num){
            int num1 = Convert.ToInt32(num);
            return (total < num1);
        }

        static int sqr(int total, string num){
            int num1 = Convert.ToInt32(num);
            int result = total;
            for(int i = 0; i < (total-1); i++){
                result = result*total;
            } n
            return (result);
        }

        public static void Main(string[] args)
        {
          // Enter your code after this line

          
          string[] inputs = {};  
          Console.WriteLine("How many characters are in your expression?");
          int num_chars = int.Parse(Console.ReadLine());

          int total = 0;

          if(num_chars >= 3){
            for(int i =0; i<num_chars; i++){
                Console.WriteLine("Enter next character:");
                string inpchar = Console.ReadLine();
                inputs.Append(inpchar);
            }
            for(int o=0;o< inputs.Length; o++){
                float y = o/2;
                if((o/2)%1 !=0){
                    if(inputs[o]== "+"){
                        total = add(total, inputs[o+1]);
                    }
                    else if (inputs[o] == "-"){
                        total = sub(total, inputs[o+1]);
                    }
                    else if (inputs[o] == "*"){
                        total = mult(total, inputs[o+1]);
                    }

                   /* else if (inputs[o]== "/"){
                        float total = float.ToParse(total);
                        total = div(total, inputs[o+1]);
                    }*/

                    else if (inputs[o] == "<"){
                        Console.WriteLine(Less(total, inputs[o+1]));
                    }

                    else if (inputs[o] == "^"){
                        Console.WriteLine(sqr(total, inputs[o+1]));
                    }
                    



                }
                else if(o == 0){
                    total = int.Parse(inputs[0]);
                }
            }
            Console.WriteLine(total);
          }
 

          



          // Enter your code before this line
        }
  }
}

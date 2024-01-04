using System;
using System.Collections.Generic;

using System.Linq;


namespace PriorityQueue
{
    class Patients{
        public string name = "Dave";
        public int priority = 3;


        public Patients(string patientName, int setPriority){
            name = patientName;
            priority = setPriority;
        }
        

        public int returnPriority(){
            return priority;
        }

        public string returnPatientName(){
            return name;
        }
    }

    class Exercises
    {
        public static int itemPosition(List<Patients>PatientListSorted){

            Console.WriteLine("Which paitent do you want to find the position of?");
            string name = Console.ReadLine();
            int position = 0;

            foreach (Patients person in PatientListSorted)
            {
                if(person.name == name){
                    position = 0;
                }

                else if(person.name != name && position<PatientListSorted.Count){
                     position++;
                }

                else if (person.name != name && position>= PatientListSorted.Count){
                    Console.WriteLine("Error: Patient does not exist");
                    position = -1;
                }


            }
            return position;
        }
        

        public static int getPriorityAmount(List<Patients>PatientListOrdered)
        {
            Console.WriteLine("Which priority do you wnat to find the total amound of patients for?");
            int priorityCheck = int.Parse(Console.ReadLine());
            int amount = 0;

            foreach (Patients person in PatientListSorted)
            {
                if(person.priority == priorityCheck){
                    amount++;
                }
            }
            return position;
        }
        
        public static int getTotalPriorities(List<Patients>PatientListOrdered){
            
            int amount = 0;
            

            foreach (Patients person in PatientListSorted)
            {
                if(person.name == name){
                    position = 0;
                }

                else if(person.name != name && position<PatientListSorted.Count){
                     position++;
                }

                else if (person.name != name && position>= PatientListSorted.Count){
                    Console.WriteLine("Error: Patient does not exist");
                    position = -1;
                }


            }
            return position;
        }

        public static void Main(string[] args)
        {

            List<Patients> PatientList = new List<Patients>();


            PatientList.Add(new Patients("Ben Gibbons", 1));
            PatientList.Add(new Patients("Neel Beniwal", 2));
            PatientList.Add(new Patients("Praveen Kumar", 4));
            PatientList.Add(new Patients("Mahesh Chand", 3));
            PatientList.Add(new Patients("Raj Kumar", 2));

             List<Patients> PatientListOrdered = PatientList.OrderBy(Patients => Patients.priority).ToList();

            foreach (Patients person in PatientListOrdered) 
            {
                string name = person.name;
                Console.WriteLine(name + '\n');
            }
            
            Console.WriteLine("Which action do you want to complete: \n1) The position of the item in the List:\n 2) The number of tasks with the same priority\n 3) The number of different priorities");
            int userOption = int.Parse(Console.ReadLine());

            if(userOption == 1){
                itemPosition(PatientListOrdered);
            }
            else if (userOption == 2){
                getPriorityAmount(PatientListOrdered);
            }
            else if (userOption == 3){
                Console.WriteLine("-");
            }
            else{
                Console.WriteLine("Error: Invalid Input");
            }


        }
  }
}

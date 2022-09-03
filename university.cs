using System;
using System.Collections.Generic;
using System.Text;

namespace SessionOneReview
{
    public class University
    {
        //string[] name = new string[3];
        //int[] age = new int[3];

        string apple;
        int ball;

        List<Student> listOfStudents = new List<Student>();

        public void WelcomeMessage()
        {
            Console.WriteLine("*****Victoria University******");
        }
        public void TakeInput()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n\nEnter your name: ");
                //name[i] = Console.ReadLine();
                apple = Console.ReadLine();

                Console.Write("Now please enter your Age: ");
                //age[i] = Convert.ToInt32(Console.ReadLine());
                ball = Convert.ToInt32(Console.ReadLine());

                Student s = new Student
                {
                    Name = apple,
                    Age = ball
                };

                listOfStudents.Add(s);
            }
        }

        public void DisplayOutput()
        {
            //for (int j = 0; j < age.Length; j++)
            //{
            //    Console.WriteLine("Ah you are: {0} and your age is {1}", name[j], age[j]);
            //}

            foreach (var item in listOfStudents)
            {
                Console.WriteLine($"Ah u r {item.Name} and your age is {item.Age}");
                //Console.WriteLine("Ah u r {0} and your age is {1}", item.Name, item.Age);
            }
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class ChangeTo
    {
        public static void fn_AsEnumerable()
        {
            int[] NumArray = new int[] { 1, 2, 3, 4, 5 };

            //After applying the AsEnumerable method the output will be store in variable result  
            var result = NumArray.AsEnumerable();



            //Now we will print the value of variable result one by one with the help of foreach loop  
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            //This one for normal array

            //for(int i =0;i<NumArray.Length;i++)
            //{
            //    Console.WriteLine(NumArray[i]);
            //}

        }

        public static void fn_Dictionary()
        {
            List<Student1> objStudent = new List<Student1>()
            {
                new Student1() { Id=1,Name = "Vinay Tyagi", Gender = "Male",Location="Chennai" },
                new Student1() { Id=2,Name = "Vaishali Tyagi", Gender = "Female", Location="Chennai" },
                new Student1() { Id=3,Name = "Montu Tyagi", Gender = "Male",Location="Bangalore" },
                new Student1() { Id=4,Name = "Akshay Tyagi", Gender = "Male", Location ="Vizag"},
                new Student1() { Id=5,Name = "Arpita Rai", Gender = "Male", Location="Nagpur"}
             };
            /*here with the help of ToDictionary() method we are converting the colection  
            of information in the form of dictionary and will fetch only the required information*/
            var student = objStudent.ToDictionary(x => x.Id, x => x.Name);

            //foreach loop is used to print the information of the student  
            foreach (var stud in student)
            {
                Console.WriteLine(stud.Key + "\t" + stud.Value);
            }

        }
    }
    public class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
    }

}

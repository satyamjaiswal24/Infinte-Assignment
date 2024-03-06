using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    abstract class Student
    {
        private string name;
        private int studentID;
        private float grade;

        public int StudentID { get; set; }
        public string Name { get; set; }
        public float Grade { get; set; }


        public abstract bool isPassed(float grade);
    }
    class UnderGraduate : Student
    {
        public override bool isPassed(float grade)
        {
            if(grade > 70.0)
            {
                return true;    
            }
            return false;
        }
    }
    class Graduate : Student
    {
        public override bool isPassed(float grade)
        {
            if(grade > 80.0)
            {
                return true;    
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public Types Contentype {  get; set; }
        public DateTime SubmissionTime {  get; set; }
        //Related Table
        //Stydent
        public int StudentId {  get; set; } 
        public Student Student { get; set; }
        //Course
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public enum Types
        {
            Application,
            Pdf,
            Zip
        }
    }
}

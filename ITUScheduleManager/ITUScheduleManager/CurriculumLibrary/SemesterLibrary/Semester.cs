using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITUScheduleManager.CurriculumLibrary.SemesterLibrary.CourseLibrary;

namespace ITUScheduleManager.CurriculumLibrary.SemesterLibrary
{
    class Semester
    {
        public int SemesterNumber = 0;
        public List<Course> Courses = new List<Course>();
        public double TotalCredits = 0;

        public Semester()
        {

        }

        public double GetWeightedMean()
        {
            double TotalMean = 0;
            double TotalCredits = 0;
            foreach (Course course in this.Courses)
            {
                TotalMean += course.GetWeighted();
                TotalCredits += course.Credits;
            }
            this.TotalCredits = TotalCredits;
            return (double)TotalMean / (double)TotalCredits;
        }
    }
}
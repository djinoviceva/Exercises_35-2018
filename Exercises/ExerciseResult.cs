using Accessibility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class ExerciseResult
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentIndex{ get; set; }
        public int Points { get; set; }

        public ExerciseResult (int id, string name, string index, int points)
        {
            this.Id = id;
            this.StudentName = name;
            this.StudentIndex = index;
            this.Points = points;
        }

        public override string ToString()
        {
            return Id + " / " + StudentName + " - " + StudentIndex + " : " + Points; 
               
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
    }
}

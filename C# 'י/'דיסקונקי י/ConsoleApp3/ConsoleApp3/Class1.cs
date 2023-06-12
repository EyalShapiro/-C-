using System;
using System.Collections.Generic;
using System.Text;

namespace bagrusubject
{
    public class BagrutSubject
    {

        private string subject;
        private int code;
        private double testAvg;
        private double schoolAvg;
        private int students;
        private int failed;

        public BagrutSubject(string subject, int code, double testAvg, double schoolAvg, int students, int failed)
        {
            this.subject = subject;
            this.code = code;
            this.testAvg = testAvg;
            this.schoolAvg = schoolAvg;
            this.students = students;
            this.failed = failed;
        }

        public double GetTestAvg()
        {
            return this.testAvg;
        }

        public double GetSchoolAvg()
        {
            return this.schoolAvg;
        }

        public double GetFailed()
        {
            return this.failed;
        }

        public double GetStudents()
        {
            return this.students;
        }
    }
}
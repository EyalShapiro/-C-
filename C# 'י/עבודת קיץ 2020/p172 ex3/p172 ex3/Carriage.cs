using System;
using System.Collections.Generic;
using System.Text;

namespace p172_ex3
{
    class Carriage
    {
        //לא גמאור
        private int num;// מספר סידורי של קרון 
        private int max_expriments; //מספר הנוסים שיכולים לנסוע בו  
        private int expriments; //מספר הנוסים שיש בפועל 
        public Carriage(int num, int max_expriments, int expriments)
        {
            this.num = num;
            this.max_expriments = max_expriments;
            this.expriments = expriments;
        }
    }
}

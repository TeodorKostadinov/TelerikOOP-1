using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Call
    {
        //fields
        private DateTime time = new DateTime();
        private string dialed;
        private long duration;
        //properties
        public DateTime Time
        {
            get{return this.time;}
            set{this.time=value;}
        }
        public string Dialed
        {
            get { return this.dialed; }
            set { this.dialed = value; }
        }
        public long Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        //constructor
        public Call(DateTime aTime, string number, long aDuration)
        {
            this.time = aTime;
            this.dialed = number;
            this.duration = aDuration;
        }
        public Call(long aDuration)
        {
            
            this.duration = aDuration;
        }
        //method for printing
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Time: " + this.time);
            sb.AppendLine("Dialed: " + this.dialed);
            sb.AppendLine("Duration: " + this.duration);
            
            return sb.ToString();
        } 
    }

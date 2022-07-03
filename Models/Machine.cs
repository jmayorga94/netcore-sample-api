using System;
namespace sample_app.Models
{
    public class Machine
    {
        public Machine()
        {
        }
        public String Name { get; set; }
        public String Processors { get; set; }
        public String ThreatId { get; set; }
        public String OsVersion { get; set; }
    }
}

using System;

namespace ApiAudaces.Models
{
    public class ApiModel
    {
        public int Id { get; set; }
        public int Target { get; set; }
        public DateTime Date { get; set; }
        public string Sequence { get; set; }
        public string FoundSequence { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.Roster
{
    public class Roster
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int NR { get; set; }
        public double GAA { get; set; }
        public double SVS { get; set; }
        public int Goals { get; set; }
        public int Ass { get; set; }
        public string? Pos { get; set; }
        public int P { get; set; }
        public int GP { get; set; }


    }
}

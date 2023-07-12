namespace GymApp.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        //0--Active 1--Passive
        public int Status { get; set; }
    }
}

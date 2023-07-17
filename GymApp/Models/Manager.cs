using Microsoft.AspNetCore.Identity;

namespace GymApp.Models
{
    public class Manager
    {
       
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
    }
}

using System.ComponentModel.DataAnnotations;
namespace FinalApi.Models
{
    public class UserModel
    {
      
        public int Id { get; set; }
        public string ? FullName { get; set; }

        public string ?  UserName { get; set; }
        public string ?  Password { get; set; }
        public string  ? Mobile { get; set; }
        public string  ? UserType { get; set; }


    }
}

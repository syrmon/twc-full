using Entities.Concrete;
using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class UserForLoginDto : IDto
    {

        public int ID { get; set; }
        public int EmailID { get; set; }
        public Email Email { get; set; }
    }
}
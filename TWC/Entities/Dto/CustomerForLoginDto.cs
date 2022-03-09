using Entities.Concrete;
using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class CustomerForLoginDto : IDto
    {

        public int ID { get; set; }
        public int EmailID { get; set; }
        public Email Email { get; set; }
    }
}

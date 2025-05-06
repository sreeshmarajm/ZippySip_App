using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ZippySip.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public  List<OrderDetails>? OrderDetails { get; set; }
        [Required(ErrorMessage ="Please enter your FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter City")]
        public string City { get; set; }
        [Required(ErrorMessage ="Please enter phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Enter Email")]
        [EmailAddress]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced {  get; set; }



    }
}

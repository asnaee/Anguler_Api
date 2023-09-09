using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace EX_01
{
    public class LoginVM
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 8)]
        [Compare("Password")]
        public string Password { get; set; }
    }
}

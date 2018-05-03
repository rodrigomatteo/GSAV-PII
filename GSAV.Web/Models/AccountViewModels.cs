using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GSAV.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string user_id { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string password { get; set; }

        //[Display(Name = "¿Recordar cuenta?")]
        //public bool RememberMe { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using WebApplication_Pronia_AB107_22November.Models.Base;

namespace WebApplication_Pronia_AB107_22November.Models
{
    public class Slider:BaseEntity
    {

        [Required,StringLength(20,ErrorMessage ="max uzunluq 20 dir")]
        public String Title { get; set; }
        public String SubTitle { get; set; }    
        public String Description { get; set; }
    }
}

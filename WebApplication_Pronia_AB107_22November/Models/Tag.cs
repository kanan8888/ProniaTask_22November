using WebApplication_Pronia_AB107_22November.Models.Base;

namespace WebApplication_Pronia_AB107_22November.Models
{
    public class Tag:BaseEntity 
    {
        public string Name { get; set; }
        public List<TagProduct> TagProducts { get; set; }
    }
}

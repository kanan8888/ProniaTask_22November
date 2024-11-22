using WebApplication_Pronia_AB107_22November.Models.Base;

namespace WebApplication_Pronia_AB107_22November.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}

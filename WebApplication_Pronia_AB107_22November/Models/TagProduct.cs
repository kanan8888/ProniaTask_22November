using WebApplication_Pronia_AB107_22November.Models.Base;

namespace WebApplication_Pronia_AB107_22November.Models
{
    public class TagProduct:BaseEntity
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}

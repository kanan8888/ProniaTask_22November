using WebApplication_Pronia_AB107_22November.Models.Base;

namespace WebApplication_Pronia_AB107_22November.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImgUrl { get; set; }
        public bool Primary { get; set; }
        public int ProductId { get; set; }  
        public Product Product { get; set; }
    }
}

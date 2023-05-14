using ShopDAL;

namespace ShopWebAPI.DTO
{
    public class ProductWithImage : Product
    {
        public IFormFile? Image { get; set; }
    }
}

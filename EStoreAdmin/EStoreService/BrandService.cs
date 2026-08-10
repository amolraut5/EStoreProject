using EstoreModel.Models.BrandModels;

namespace EStoreService
{
    public class BrandService
    {
        public List<BrandModel> ListBrands()
        {
            List <BrandModel> brandModels = new List <BrandModel>();
            brandModels.Add(new BrandModel
            {
                Id = Guid.NewGuid(),
                Name = "Brand 1"
            });

            brandModels.Add(new BrandModel
            {
                Id = Guid.NewGuid(),
                Name = "Brand 2"
            });

            brandModels.Add(new BrandModel
            {
                Id = Guid.NewGuid(),
                Name = "Brand 3"
            });
            return brandModels;
        }

    }
}
